using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPerfumaria.Models.Tables
{
    public class MaquinasCartao
    {
        public int id { get; set; }
        public string modelo { get; set; }
        public string empresa_responsavel { get; set; }
        public List<string>? bandeiras_aceitas { get; set; }
        public double? taxa_debito { get; set; }
        public Dictionary<string, double>? taxas_parcelas { get; set; }
        public Dictionary<string, double>? taxas_links_parcelas { get; set; }
        public double? taxa_pix { get; set; }
        public int instalacoes_id { get; set; }
        public string status { get; set; }
    }
}
