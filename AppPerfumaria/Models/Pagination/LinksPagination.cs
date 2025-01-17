using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPerfumaria.Models.Pagination
{
    public class LinksPagination
    {
        public string? first { get; set; }
        public string? last { get; set; }
        public string? prev { get; set; }
        public string? next { get; set; }
    }
}
