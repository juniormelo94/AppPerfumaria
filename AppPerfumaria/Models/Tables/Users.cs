using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPerfumaria.Models.Tables
{
    public class Users
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string? password { get; set; }
        public string email_verified_at { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public ColaboradoresUsers? colaborador_user { get; set; }
    }
}
