using AppPerfumaria.Models.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPerfumaria.Models.Resources
{
    public class MarcasResource
    {
        public bool status { get; set; }
        public string? message { get; set; }
        public MarcasErros? erros { get; set; }
        public Marcas? data { get; set; }
    }

    public class MarcasErros
    {
        public List<string>? id { get; set; }
        public List<string>? nome { get; set; }
        public List<string>? ramo { get; set; }
        public List<string>? cnpj { get; set; }
        public List<string>? logo_img { get; set; }
        public List<string>? status { get; set; }
        public List<string>? created_at { get; set; }
        public List<string>? updated_at { get; set; }
    }
}
