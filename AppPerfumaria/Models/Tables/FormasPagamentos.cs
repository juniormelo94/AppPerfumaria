using System;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPerfumaria.Models.Tables
{
    public class FormasPagamentos
    {
        public int id { get; set; }
        [Required(ErrorMessage = "O nome é obrigatório.")]
        public string nome { get; set; }
        [Required(ErrorMessage = "O tipo de pagamento é obrigatório.")]
        public string tipo_pagamento { get; set; }
        [Required(ErrorMessage = "O status é obrigatório.")]
        public string status { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }
}
