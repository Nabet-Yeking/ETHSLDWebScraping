using ETHSLDWebScraping.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETHSLDWebScraping.DTOs
{
    internal sealed class WordDetailResponseDto
    {
        public bool Success { get; set; }
        public string? Message { get; set; }
        public WordDetailData? Data { get; set; }

        public sealed class WordDetailData
        {
            public int Id { get; set; }
            public string? Term { get; set; }
            public string? Meaning { get; set; }
            public string? Type { get; set; }
            public int Status { get; set; }
            public Content[]? Contents { get; set; }
            public Translation[]? Translations { get; set; }
        }
    }
}
