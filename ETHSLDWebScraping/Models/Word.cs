using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETHSLDWebScraping.Models
{
    internal class Word
    {
        public int Id { get; set; }
        public string Term { get; set; } = string.Empty;
        public string Grammatical_Class { get; set; } = string.Empty;
        public string? Meaning { get; set; }
        public int Status { get; set; }
        public int typeID { get; set; }
        public string Updated_At { get; set; } = string.Empty;
        public string Created_At { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
    }
}
