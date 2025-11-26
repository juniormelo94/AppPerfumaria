using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPerfumaria.Models.Tables
{
    public class ColaboradoresUsers
    {
        public int id { get; set; }
        public string? cargo { get; set; }
        public List<string>? divisoes_ids { get; set; }
        public List<string>? instalacoes_ids { get; set; }
        public int colaboradores_id { get; set; }
        public int users_id { get; set; }
        public int tipos_users_id { get; set; }
        public string status { get; set; }
        public TiposUsers? tipo_user { get; set; }
    }
}
