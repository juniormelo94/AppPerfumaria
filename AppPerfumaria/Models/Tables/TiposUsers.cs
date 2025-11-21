using System;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPerfumaria.Models.Tables
{
    public class TiposUsers
    {
        public int id { get; set; }
        [Required(ErrorMessage = "O tipo é obrigatório.")]
        public string tipo { get; set; }
        public string? descricao { get; set; }
        [Required(ErrorMessage = "O status é obrigatório.")]
        public string status { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }
}
