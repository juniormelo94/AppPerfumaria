using AppPerfumaria.Models.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPerfumaria.Models.Resources
{
    public class MaquinasCartaoResource
    {
        public bool status { get; set; }
        public string? message { get; set; }
        public MaquinasCartaoErros? erros { get; set; }
        public Vendas? data { get; set; }
    }

    public class MaquinasCartaoErros
    {
        public List<string>? id { get; set; }
        public List<string>? modelo { get; set; }
        public List<string>? empresa_responsavel { get; set; }
        public List<string>? bandeiras_aceitas { get; set; }
        public List<string>? taxa_debito { get; set; }
        public List<string>? taxas_parcelas { get; set; }
        public List<string>? taxas_links_parcelas { get; set; }
        public List<string>? taxa_pix { get; set; }
        public List<string>? instalacoes_id { get; set; }
        public List<string>? status { get; set; }
        public List<string>? created_at { get; set; }
        public List<string>? updated_at { get; set; }
    }
}
