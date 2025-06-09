using AppPerfumaria.Models.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPerfumaria.Models.Resources
{
    public class VendasResource
    {
        public bool status { get; set; }
        public string? message { get; set; }
        public VendasErros? erros { get; set; }
        public Vendas? data { get; set; }
    }

    public class VendasErros
    {
        public List<string>? id { get; set; }
        public List<string>? preco_total { get; set; }
        public List<string>? lucro_total_original { get; set; }
        public List<string>? lucro_total_desconto { get; set; }
        public List<string>? maquina_cartao { get; set; }
        public List<string>? quantidade_parcelas { get; set; }
        public List<string>? valor_pacelas { get; set; }
        public List<string>? taxa_juros { get; set; }
        public List<string>? formas_pagamentos_id { get; set; }
        public List<string>? clientes_id { get; set; }
        public List<string>? colaboradores_id { get; set; }
        public List<string>? instalacoes_id { get; set; }
        public List<string>? estoques_ids { get; set; }
        public List<string>? status { get; set; }
        public List<string>? created_at { get; set; }
        public List<string>? updated_at { get; set; }
    }
}
