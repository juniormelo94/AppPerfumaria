using AppPerfumaria.Models.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPerfumaria.Models.Resources
{
    public class TiposUsersResource
    {
        public bool status { get; set; }
        public string? message { get; set; }
        public TiposUsersErros? erros { get; set; }
        public TiposUsers? data { get; set; }
    }

    public class TiposUsersErros
    {
        public List<string>? id { get; set; }
        public List<string>? tipo { get; set; }
        public List<string>? descricao { get; set; }
        public List<string>? status { get; set; }
        public List<string>? created_at { get; set; }
        public List<string>? updated_at { get; set; }
    }
}
