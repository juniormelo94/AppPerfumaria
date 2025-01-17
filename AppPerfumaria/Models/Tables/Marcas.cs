using System;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPerfumaria.Models.Tables
{
    public class Marcas
    {
        public int id { get; set; }
        [Required(ErrorMessage = "O nome é obrigatório.")]
        public string nome { get; set; }
        [Required(ErrorMessage = "O ramo é obrigatório.")]
        public string ramo { get; set; }
        public string? cnpj { get; set; }
        public string? logo_img { get; set; }
        [Required(ErrorMessage = "O status é obrigatório.")]
        public string status { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public List<InstalacoesMarcas>? instalacao_marcas { get; set; }
    }
}
