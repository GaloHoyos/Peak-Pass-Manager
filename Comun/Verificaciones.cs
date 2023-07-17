using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comun
{
    public class Verificaciones
    {
        public bool VerificacionCrearCliente(string nombre, string apellido, string dni, string correo, string direccion, string telefono)
        {
            if (nombre == string.Empty || apellido == string.Empty || dni == string.Empty || correo == string.Empty || direccion == string.Empty || telefono == string.Empty)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
