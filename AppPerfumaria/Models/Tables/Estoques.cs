using System;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPerfumaria.Models.Tables
{
    public class Estoques
    {
        public int id { get; set; }
        public double? desconto_compra { get; set; }
        [Required(ErrorMessage = "O preço de compra original é obrigatório.")]
        public double? preco_compra_original { get; set; }
        public double? preco_compra_desconto { get; set; }
        public double? desconto_venda { get; set; }
        [Required(ErrorMessage = "O preço original para venda é obrigatório.")]
        public double? preco_venda_original { get; set; }
        public double? preco_venda_desconto { get; set; }
        public double? preco_venda_avista { get; set; }
        [Required(ErrorMessage = "O vendido é obrigatório.")]
        public bool vendido { get; set; }
        [Required(ErrorMessage = "O desconto de pagamento à vista é obrigatório.")]
        public bool desconto_pagamento_avista { get; set; }
        public DateTime? vencimento { get; set; }
        [Required(ErrorMessage = "O produto é obrigatório.")]
        public int produtos_id { get; set; }
        [Required(ErrorMessage = "A instalação é obrigatória.")]
        public int instalacoes_id { get; set; }
        [Required(ErrorMessage = "O status é obrigatório.")]
        public string status { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public Produtos? produto { get; set; }
    }
}
