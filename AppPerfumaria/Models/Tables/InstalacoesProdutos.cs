using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPerfumaria.Models.Tables
{
    public class InstalacoesProdutos
    {
        public int id { get; set; }
        public string? observacoes { get; set; }
        [Required(ErrorMessage = "A instalação é obrigatório.")]
        public int instalacoes_id { get; set; }
        [Required(ErrorMessage = "O produto é obrigatório.")]
        public int produtos_id { get; set; }
        [Required(ErrorMessage = "O status da associação é obrigatório.")]
        public string status { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public Produtos? produto { get; set; }
        public List<Estoques>? estoque { get; set; }
    }
}
