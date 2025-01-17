using AppPerfumaria.Models.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPerfumaria.Models.Resources
{
    public class EstoquesResource
    {
        public bool status { get; set; }
        public string? message { get; set; }
        public EstoquesErros? erros { get; set; }
        public Estoques? data { get; set; }
    }

    public class EstoquesErros
    {
        public List<string>? id { get; set; }
        public List<string>? desconto_compra { get; set; }
        public List<string>? preco_compra_original { get; set; }
        public List<string>? preco_compra_desconto { get; set; }
        public List<string>? desconto_venda { get; set; }
        public List<string>? preco_venda_original { get; set; }
        public List<string>? preco_venda_desconto { get; set; }
        public List<string>? vendido { get; set; }
        public List<string>? vencimento { get; set; }
        public List<string>? produtos_id { get; set; }
        public List<string>? instalacoes_id { get; set; }
        public List<string>? status { get; set; }
        public List<string>? created_at { get; set; }
        public List<string>? updated_at { get; set; }
    }
}
