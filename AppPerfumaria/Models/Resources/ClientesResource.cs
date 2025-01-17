using AppPerfumaria.Models.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPerfumaria.Models.Resources
{
    public class ClientesResource
    {
        public bool status { get; set; }
        public string? message { get; set; }
        public ColaboradoresErros? erros { get; set; }
        public Clientes? data { get; set; }
    }

    public class ClientesErros
    {
        public List<string>? id { get; set; }
        public List<string>? nome_completo { get; set; }
        public List<string>? primeiro_nome { get; set; }
        public List<string>? ultimo_nome { get; set; }
        public List<string>? apelido { get; set; }
        public List<string>? cpf { get; set; }
        public List<string>? data_nascimento { get; set; }
        public List<string>? rg { get; set; }
        public List<string>? sexo { get; set; }
        public List<string>? estado_civil { get; set; }
        public List<string>? img { get; set; }
        public List<string>? email_pessoal { get; set; }
        public List<string>? telefone_pessoal { get; set; }
        public List<string>? celular_pessoal { get; set; }
        public List<string>? whatsapp_pessoal { get; set; }
        public List<string>? instagram_pessoal { get; set; }
        public List<string>? facebook_pessoal { get; set; }
        public List<string>? status { get; set; }
        public List<string>? created_at { get; set; }
        public List<string>? updated_at { get; set; }
    }
}
