using ETHSLDWebScraping.DTOs;
using ETHSLDWebScraping.Models;
using System.Net.Http.Json;

namespace ETHSLDWebScraping
{
    public partial class Form : System.Windows.Forms.Form
    {
        private readonly HttpClient _httpClient;

        public Form()
        {
            InitializeComponent();
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("http://ethsld.aau.edu.et")
            };
        }

        private async Task StartScrappingAsync()
        {
            WordResponseDto? words = await GetWordsAsync();
            if (words != null)
            {
                if (words.Data?.Words != null)
                {
                    scrapingPrBar.Maximum = words.Total;
                    int j = 0;
                    foreach (var word in words.Data.Words)
                    {
                        wordLbl.Text = word.Term;
                        countLbl.Text = j.ToString();
                        j++;
                        scrapingPrBar.PerformStep();
                    }
                    //await GetWordsDetailAsync(words);
                }
                else
                {
                    MessageBox.Show("No words found.");
                }

            }
            else
            {
                MessageBox.Show("Failed to retrieve words.");
            }
        }

        private async Task GetWordsDetailAsync(WordResponseDto words)
        {
            Word[]? w = words.Data?.Words ?? null;
            if (w == null) return;
            int len = w.Length;

            for (int i = 0; i < len; i++)
            {
                int id = w[i].Id;
                var response = await _httpClient.GetAsync($"/ESLDS/public/api/Get-RandWord-Detail2/{id}");
                GetWordsVideoDataAsync(await response.Content.ReadFromJsonAsync<WordDetailResponseDto>() ?? null);
            }
        }

        private void GetWordsVideoDataAsync(WordDetailResponseDto? wordDetailResponseDto)
        {
            if (wordDetailResponseDto == null) return;

        }

        private async Task<WordResponseDto?> GetWordsAsync()
        {
            var response = await _httpClient.GetAsync("/ESLDS/public/api/Dictionary-Item/Word/0/3134");
            return await response.Content.ReadFromJsonAsync<WordResponseDto>() ?? null;
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            _ = StartScrappingAsync();
        }
    }
}
