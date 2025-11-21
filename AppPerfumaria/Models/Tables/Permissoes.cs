using System;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPerfumaria.Models.Tables
{
    public class Permissoes
    {
        public int id { get; set; }
        [Required(ErrorMessage = "A chave é obrigatória.")]
        public string chave { get; set; }
        public string? grupo { get; set; }
        public string? descricao { get; set; }
        [Required(ErrorMessage = "O status é obrigatório.")]
        public string status { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }
}
