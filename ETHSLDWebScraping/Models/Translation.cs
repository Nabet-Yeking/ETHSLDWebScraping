using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETHSLDWebScraping.Models
{
    internal class Translation
    {
        public int Id { get; set; }
        public string? TransTerm { get; set; }
        public string? TransMeaning { get; set; }
        public string? Code { get; set; }
        public string? Name { get; set; }
    }
}
