using AppPerfumaria.Models.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPerfumaria.Models.Resources
{
    public class ProdutosDivulgacoesResource
    {
        public bool status { get; set; }
        public string? message { get; set; }
        public ProdutosDivulgacoesErros? erros { get; set; }
        public ProdutosDivulgacoes? data { get; set; }
    }

    public class ProdutosDivulgacoesErros
    {
        public List<string>? id { get; set; }
        public List<string>? img_padrao_1 { get; set; }
        public List<string>? img_padrao_2 { get; set; }
        public List<string>? img_padrao_3 { get; set; }
        public List<string>? img_promocao_1 { get; set; }
        public List<string>? img_promocao_2 { get; set; }
        public List<string>? img_promocao_3 { get; set; }
        public List<string>? produtos_id { get; set; }
        public List<string>? status { get; set; }
        public List<string>? created_at { get; set; }
        public List<string>? updated_at { get; set; }
    }
}
