using AppPerfumaria.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPerfumaria.Models.Auth
{
    public class Auth
    {
        public string? token_type { get; set; }
        public string? token { get; set; }
        public Users? data { get; set; }
    }
}
