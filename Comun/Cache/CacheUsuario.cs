using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comun.Cache
{
    
    public class CacheUsuario
    {
        public static int IdUsuario { get; set; }
        public static string Nombre { get; set; }
        public static string Apellido { get; set; }
        public static string DNI { get; set; }
        public static string Correo { get; set; }
        public static string Direccion { get; set; }
        public static string Telefono { get; set; }
        public static bool Activo { get; set; }
        public static int idRol { get; set; }
    }

}
