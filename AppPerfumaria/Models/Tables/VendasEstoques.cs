﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPerfumaria.Models.Tables
{
    public class VendasEstoques
    {
        public int id { get; set; }
        [Required(ErrorMessage = "A venda é obrigatória.")]
        public int vendas_id { get; set; }
        [Required(ErrorMessage = "O item do estoque é obrigatório.")]
        public int estoques_id { get; set; }
        [Required(ErrorMessage = "O status da associação é obrigatório.")]
        public string status { get; set; }
        public DateTime? created_at { get; set; }
        public DateTime? updated_at { get; set; }
        public Estoques? estoque { get; set; }
    }
}
