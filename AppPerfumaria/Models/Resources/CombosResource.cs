using AppPerfumaria.Models.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPerfumaria.Models.Resources
{
    public class CombosResource
    {
        public bool status { get; set; }
        public string? message { get; set; }
        public CombosErros? erros { get; set; }
        public Produtos? data { get; set; }
    }

    public class CombosErros
    {
        public List<string>? id { get; set; }
        public List<string>? tipo { get; set; }
        public List<string>? descricao { get; set; }
        public List<string>? codigo_barras { get; set; }
        public List<string>? qr_code { get; set; }
        public List<string>? img_1 { get; set; }
        public List<string>? img_2 { get; set; }
        public List<string>? img_3 { get; set; }
        public List<string>? instalacoes_id { get; set; }
        public List<string>? produtos_ids { get; set; }
        public List<string>? status { get; set; }
        public List<string>? created_at { get; set; }
        public List<string>? updated_at { get; set; }
    }
}
