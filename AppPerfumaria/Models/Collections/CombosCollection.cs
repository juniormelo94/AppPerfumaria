using AppPerfumaria.Models.Pagination;
using AppPerfumaria.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPerfumaria.Models.Collections
{
    public class CombosCollection
    {
        public bool status { get; set; }
        public string? message { get; set; }
        public List<Combos>? data { get; set; }
        public LinksPagination? links { get; set; }
        public MetaPagination? meta { get; set; }
    }
}
