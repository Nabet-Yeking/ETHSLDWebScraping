using ETHSLDWebScraping.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace ETHSLDWebScraping.DTOs
{
    internal sealed class WordResponseDto
    {
        public bool Success { get; set; }
        public string? Message { get; set; }
        public string? Language { get; set; }
        public WordData? Data { get; set; }

        public sealed class WordData
        {
            public int Current_Page { get; set; }
            [JsonPropertyName("data")]
            public Word[]? Words { get; set; }
            public string? First_Page_Url { get; set; }
            public int From { get; set; }
            public int Last_Page { get; set; }
            public string? Last_Page_Url { get; set; }
            public Link[]? Links { get; set; }
            public string? Next_Page_Url { get; set; }
            public string? Path { get; set; }
            public int Per_Page { get; set; }
            public string? Prev_Page_Url { get; set; }
            public int To { get; set; }
            public int Total { get; set; }
        }

        public int Total { get; set; }
    }
}
