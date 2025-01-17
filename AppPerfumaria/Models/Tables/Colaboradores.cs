using System;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPerfumaria.Models.Tables
{
    public class Colaboradores
    {
        public int id { get; set; }
        [Required(ErrorMessage = "O nome completo é obrigatório.")]
        public string nome_completo { get; set; }
        [Required(ErrorMessage = "O primeiro nome é obrigatório.")]
        public string primeiro_nome { get; set; }
        [Required(ErrorMessage = "O último nome é obrigatório.")]
        public string ultimo_nome { get; set; }
        public string? apelido { get; set; }
        [Required(ErrorMessage = "O CPF é obrigatório.")]
        public string cpf { get; set; }
        [Required(ErrorMessage = "A data de nascimento é obrigatória.")]
        public DateTime? data_nascimento { get; set; }
        public string? rg { get; set; }
        [Required(ErrorMessage = "O sexo é obrigatório.")]
        public string sexo { get; set; }
        public string? estado_civil { get; set; }
        public string? img { get; set; }
        [EmailAddress(ErrorMessage = "O e-mail precisa está em um formato válido.")]
        public string? email_pessoal { get; set; }
        public string? telefone_pessoal { get; set; }
        public string? celular_pessoal { get; set; }
        public string? whatsapp_pessoal { get; set; }
        public string? instagram_pessoal { get; set; }
        public string? facebook_pessoal { get; set; }
        [Required(ErrorMessage = "O status é obrigatório.")]
        public string status { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public List<InstalacoesColaboradores>? instalacao_colaboradores { get; set; }
    }
}
