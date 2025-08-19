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
        public string Term { get; set; }
        public string Grammatical_Class { get; set; }
        public string? Meaning { get; set; }
        public int Status { get; set; }
        public int typeID { get; set; }
        public DateTime Updated_At { get; set; }
        public DateTime Created_At { get; set; }
        public string Type { get; set; }
    }
}
