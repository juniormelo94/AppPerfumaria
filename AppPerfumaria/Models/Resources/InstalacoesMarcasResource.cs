using AppPerfumaria.Models.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPerfumaria.Models.Resources
{
    public class InstalacoesMarcasResource
    {
        public bool status { get; set; }
        public string? message { get; set; }
        public InstalacoesMarcasErros? erros { get; set; }
        public InstalacoesMarcas? data { get; set; }
    }

    public class InstalacoesMarcasErros
    {
        public List<string>? id { get; set; }
        public List<string>? observacoes { get; set; }
        public List<string>? instalacoes_id { get; set; }
        public List<string>? marcas_id { get; set; }
        public List<string>? status { get; set; }
        public List<string>? created_at { get; set; }
        public List<string>? updated_at { get; set; }
    }
}
