using AppPerfumaria.Models.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPerfumaria.Models.Resources
{
    public class ProdutosResource
    {
        public bool status { get; set; }
        public string? message { get; set; }
        public ProdutosErros? erros { get; set; }
        public Produtos? data { get; set; }
    }

    public class ProdutosErros
    {
        public List<string>? id { get; set; }
        public List<string>? tipo { get; set; }
        public List<string>? descricao { get; set; }
        public List<string>? codigo_barras { get; set; }
        public List<string>? qr_code { get; set; }
        public List<string>? img_1 { get; set; }
        public List<string>? img_2 { get; set; }
        public List<string>? img_3 { get; set; }
        public List<string>? marcas_id { get; set; }
        public List<string>? status { get; set; }
        public List<string>? created_at { get; set; }
        public List<string>? updated_at { get; set; }
        public List<string>? divulgacao_existe { get; set; }

    }
}
