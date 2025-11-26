using AppPerfumaria.Models.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPerfumaria.Models.Resources
{
    public class UsersResource
    {
        public bool status { get; set; }
        public string? message { get; set; }
        public UsersErros? erros { get; set; }
        public Users? data { get; set; }
    }

    public class UsersErros
    {
        public List<string>? id { get; set; }
        public List<string>? name { get; set; }
        public List<string>? email { get; set; }
        public List<string>? password { get; set; }
        public List<string>? email_verified_at { get; set; }
        public List<string>? created_at { get; set; }
        public List<string>? updated_at { get; set; }
    }
}
