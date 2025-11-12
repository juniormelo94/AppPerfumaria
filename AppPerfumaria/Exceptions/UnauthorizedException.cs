using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPerfumaria.Exceptions
{
    public class UnauthorizedException : Exception
    {
        public UnauthorizedException(string message = "Sua sessão expirou. Faça login novamente.") : base(message)
        {
        }
    }
}
