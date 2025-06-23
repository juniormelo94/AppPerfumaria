using System;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPerfumaria.Models.Tables
{
    public class ProdutosDivulgacoes
    {
        public int id { get; set; }
        public string? img_padrao_1 { get; set; }
        public string? img_padrao_2 { get; set; }
        public string? img_padrao_3 { get; set; }
        public string? img_promocao_1 { get; set; }
        public string? img_promocao_2 { get; set; }
        public string? img_promocao_3 { get; set; }
        [Required(ErrorMessage = "O produto é obrigatório.")]
        public int produtos_id { get; set; }
        [Required(ErrorMessage = "O status é obrigatório.")]
        public string status { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public bool? exists { get; set; }
    }
}
