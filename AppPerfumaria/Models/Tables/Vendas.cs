using MudBlazor;
using System;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AppPerfumaria.Models.Tables
{
    public class Vendas
    {
        public int id { get; set; }
        public double? preco_total { get; set; }
        public double? lucro_total_original { get; set; }
        public double? lucro_total_desconto { get; set; }
        [RequiredIfCustom(nameof(formas_pagamentos_id), 2, 3, ErrorMessage = "A máquina cartão é obrigatória.")]
        public string? maquina_cartao { get; set; }
        [RequiredIfCustom(nameof(formas_pagamentos_id), 2, ErrorMessage = "A quantidade de parcelas é obrigatória.")]
        public int? quantidade_parcelas { get; set; }
        public double? valor_pacelas { get; set; }
        public double? taxa_juros { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "A forma de pagamento é obrigatória.")]
        [Required(ErrorMessage = "A forma de pagamento é obrigatória.")]
        public int formas_pagamentos_id { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "O cliente é obrigatório.")]
        [Required(ErrorMessage = "O cliente é obrigatório.")]
        public int clientes_id { get; set; }
        public int colaboradores_id { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "A instalação é obrigatória.")]
        [Required(ErrorMessage = "A instalação é obrigatória.")]
        public int instalacoes_id { get; set; }
        public List<int>? estoques_ids { get; set; }
        [Required(ErrorMessage = "O status é obrigatório.")]
        public string status { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public Clientes? cliente { get; set; }
        public Colaboradores? colaborador { get; set; }
        public FormasPagamentos? forma_pagamento { get; set; }
        public List<VendasEstoques>? vendas_estoques { get; set; }
    }

    public class RequiredIfCustomAttribute(string otherProperty, params object[] targetValues) : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var otherPropertyValue = validationContext.ObjectType
                                                      .GetProperty(otherProperty)?
                                                      .GetValue(validationContext.ObjectInstance);

            if (otherPropertyValue is null || !targetValues.Contains(otherPropertyValue))
            {
                return ValidationResult.Success;
            }

            if (value is null && targetValues.Contains(otherPropertyValue))
            {
                return new ValidationResult(ErrorMessage ?? "Esse campo é obrigatório.", new[] { validationContext.MemberName });
            }

            return ValidationResult.Success;
        }
    }
}
