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
        public string? tipo_user { get; set; }
        public List<string>? permissoes { get; set; }
        public List<string>? divisoes_ids { get; set; }
        public List<string>? instalacoes_ids { get; set; }
        public int colaboradores_id { get; set; }
        public int users_id { get; set; }
        public string status { get; set; }
    }
}
