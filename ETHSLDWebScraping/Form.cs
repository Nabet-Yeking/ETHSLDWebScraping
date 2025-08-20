using ETHSLDWebScraping.DTOs;
using ETHSLDWebScraping.Models;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Net.Http.Json;

namespace ETHSLDWebScraping
{
    public partial class Form : System.Windows.Forms.Form
    {
        private readonly HttpClient _httpClient;
        private readonly string _word_url;
        private readonly string _word_detail_url;
        private readonly string _video_data_url;

        public Form()
        {
            InitializeComponent();
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("http://ethsld.aau.edu.et")
            };
            _httpClient.Timeout = TimeSpan.FromMinutes(10); // Set a longer timeout for the HTTP requests
            _word_url = "/ESLDS/public/api/Dictionary-Item/Word/0/3134";
            _word_detail_url = "/ESLDS/public/api/Get-RandWord-Detail2";
            _video_data_url = "/ESLDS/public/assets/uploads/media_content";
        }

        private async void StartScrappingAsync()
        {
            WordResponseDto? words = await GetWordsAsync();
            if (words != null)
            {
                if (words.Data?.Words != null)
                {
                    try
                    {
                        await GetWordsDetailAsync(words);
                    }
                    catch(Exception e)
                    {
                        ShowErrorMessage(e.Message);
                    }
                }
                else
                {
                    ShowErrorMessage("No words found.");
                }

            }
            else
            {
                ShowErrorMessage("Failed to retrieve words.");
            }
        }

        private async Task GetWordsDetailAsync(WordResponseDto words)
        {
            try
            {
                Word[]? w = words.Data?.Words ?? null;
                if (w == null) return;
                int len = w.Length;
                scrapingPrBar.Maximum = len;

                for (int i = 0; i < len; i++)
                {
                    int id = w[i].Id;
                    var response = await _httpClient.GetAsync($"{_word_detail_url}/{id}");
                    await GetWordsVideoDataAsync(await response.Content.ReadFromJsonAsync<WordDetailResponseDto>() ?? null);
                    updateUI(id, i + 1, len);
                }
                ShowErrorMessage($"{len} videos succesfully saved!", "Success");
            }
            catch (Exception e) 
            {
                ShowErrorMessage(e.Message);
            }
        }

        private void updateUI(int wordId, int ct, int total)
        {
            wordURILbl.Text = _word_url;
            wordDetailURILbl.Text = $"{_word_detail_url}/{wordId}";
            countLbl.Text = $"{scrapingPrBar.Value}";
            scrapingPrBar.PerformStep();
        }

        private async Task GetWordsVideoDataAsync(WordDetailResponseDto? wordDetailResponseDto)
        {
            try
            {
                if (wordDetailResponseDto == null) return;
                if (wordDetailResponseDto.Data == null) return;
                if (wordDetailResponseDto.Data.Contents == null) return;
                if (wordDetailResponseDto.Data.Contents.Length == 0) return;
                if (wordDetailResponseDto.Data.Translations == null) return;

                string? fileName = wordDetailResponseDto.Data.Contents[0].FileName;
                string? term = wordDetailResponseDto.Data.Translations[0].TransTerm;
                DirectoryInfo directoryInfo = Directory.CreateDirectory("DataSet");
                var response = await _httpClient.GetAsync($"{_video_data_url}/{fileName}");
                videoDataURILbl.Text = $"{_video_data_url}/{fileName}";
                wordLbl.Text = term;

                if (response.Content != null)
                {
                    FileStream fileStream = new FileStream($"{directoryInfo.Name}/{fileName}", FileMode.Create, FileAccess.ReadWrite);
                    await response.Content.CopyToAsync(fileStream);
                    WriteMetaData(directoryInfo, fileName, term);
                    fileStream.Close();
                }
            }
            catch (Exception ex) 
            {
                ShowErrorMessage(ex.Message);
            }
        }

        private void WriteMetaData(DirectoryInfo directoryInfo, string fileName, string term)
        {
            try
            {
                FileStream fstream;
                StreamWriter streamWriter;
                bool isFileExist = true;

                if (!File.Exists($"{directoryInfo.Name}/labels.csv"))
                {
                    isFileExist = false;
                }

                fstream = new FileStream($"{directoryInfo.Name}/labels.csv", FileMode.Append, FileAccess.Write);
                streamWriter = new StreamWriter(fstream);

                if (!isFileExist)
                {
                    streamWriter.WriteLine("filename,label");
                }
                streamWriter.WriteLine($"{fileName},{term}");
                streamWriter.Close();

            }
            catch (Exception ex) 
            {
                ShowErrorMessage(ex.Message);
            }
        }

        private async Task<WordResponseDto?> GetWordsAsync()
        {
            try
            {
                var response = await _httpClient.GetAsync(_word_url);
                return await response.Content.ReadFromJsonAsync<WordResponseDto>() ?? null;
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
                return null;
            }
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            StartScrappingAsync();
            startBtn.Enabled = false;
        }

        private void ShowErrorMessage(string e, string title = "Error")
        {
            MessageBox.Show(e, title, MessageBoxButtons.OK);
        }
    }
}