using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPerfumaria.Models.Tables
{
    public class Instalacoes
    {
        public int id { get; set; }
        [Required(ErrorMessage = "O endereço é obrigatório.")]
        public string endereco { get; set; }
        [Required(ErrorMessage = "O bairro é obrigatório.")]
        public string bairro { get; set; }
        [Required(ErrorMessage = "O número é obrigatório.")]
        public string numero { get; set; }
        public string? complemento { get; set; }
        [Required(ErrorMessage = "O cep é obrigatório.")]
        public string cep { get; set; }
        [Required(ErrorMessage = "A cidade é obrigatória.")]
        public string cidade { get; set; }
        [Required(ErrorMessage = "A unidade federativa é obrigatória.")]
        public string uf { get; set; }
        public string? email { get; set; }
        public string? telefone { get; set; }
        public string? celular { get; set; }
        public string? whatsapp { get; set; }
        public string? instagram { get; set; }
        public string? facebook { get; set; }
        public int divisoes_id { get; set; }
        [Required(ErrorMessage = "O status é obrigatório.")]
        public string status { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }
}
