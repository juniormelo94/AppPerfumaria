using System;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPerfumaria.Models.Tables
{
    public class Produtos
    {
        public int id { get; set; }
        [Required(ErrorMessage = "O nome é obrigatório.")]
        public string nome { get; set; }
        [Required(ErrorMessage = "O tipo é obrigatório.")]
        public string tipo { get; set; }
        [Required(ErrorMessage = "A descrição é obrigatória.")]
        public string descricao { get; set; }
        public string? codigo_barras { get; set; }
        public string? qr_code { get; set; }
        public string? img_1 { get; set; }
        public string? img_2 { get; set; }
        public string? img_3 { get; set; }
        [Required(ErrorMessage = "A marca é obrigatória.")]
        public int marcas_id { get; set; }
        [Required(ErrorMessage = "O status é obrigatório.")]
        public string status { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public bool divulgacao_existe { get; set; }
        public Marcas? marca { get; set; }
        public Estoques? estoque { get; set; }
        public List<InstalacoesProdutos>? instalacao_produtos { get; set; }
    }
}
