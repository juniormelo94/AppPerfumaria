using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPerfumaria.Models.Tables
{
    public class TiposUsersPermissoes
    {
        public int id { get; set; }
        [Required(ErrorMessage = "O tipo de usuário é obrigatório.")]
        public int tipos_users_id { get; set; }
        [Required(ErrorMessage = "A permissão é obrigatória.")]
        public int permissoes_id { get; set; }
        public DateTime? created_at { get; set; }
        public DateTime? updated_at { get; set; }
        public Permissoes? permissao { get; set; }
    }
}
