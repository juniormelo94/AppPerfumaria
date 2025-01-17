using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPerfumaria.Models.Pagination
{
    public class MetaPagination
    {
        public int? current_page { get; set; }
        public int? from { get; set; }
        public int last_page { get; set; }
        public List<LinksMeta>? links { get; set; }
        public string? path { get; set; }
        public int per_page { get; set; }
        public int? to { get; set; }
        public int total { get; set; }
    }

    public class LinksMeta
    {
        public string url { get; set; }
        public string label { get; set; }
        public bool active { get; set; }
    }
}
