using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPerfumaria.Models.Tables
{
    public class CombosProdutos
    {
        public int id { get; set; }
        [Required(ErrorMessage = "O combo é obrigatório.")]
        public int combos_id { get; set; }
        [Required(ErrorMessage = "O produto é obrigatório.")]
        public int produtos_id { get; set; }
        [Required(ErrorMessage = "O status da associação é obrigatório.")]
        public string status { get; set; }
        public DateTime? created_at { get; set; }
        public DateTime? updated_at { get; set; }
        public Produtos? produto { get; set; }
    }
}
