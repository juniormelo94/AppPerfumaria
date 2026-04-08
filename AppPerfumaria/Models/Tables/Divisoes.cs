using System;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPerfumaria.Models.Tables
{
    public class Divisoes
    {
        public int id { get; set; }
        [Required(ErrorMessage = "O nome é obrigatório.")]
        public string nome { get; set; }
        [Required(ErrorMessage = "O ramo é obrigatório.")]
        public string ramo { get; set; }
        public string? cnpj { get; set; }
        [Required(ErrorMessage = "A cor primária é obrigatória.")]
        public string cor_primaria { get; set; }
        public string? cor_secundaria { get; set; }
        public string? cor_tercearia { get; set; }
        public string? logo_img { get; set; }
        [Required(ErrorMessage = "O status é obrigatório.")]
        public string status { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }
}
