using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetaTipicaRD.Infrastructure.Exceptions
{
    public class UsuarioRTNotFoundException : Exception
    {
        public UsuarioRTNotFoundException(int id)
            : base($"El usuario con ID {id} no fue encontrado.")
        {
        }
    }
}
