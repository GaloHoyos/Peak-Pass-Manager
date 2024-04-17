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
        //encriptacion de contraseña
        public string Encriptar(string cadenaAencriptar)
        {
            string result = string.Empty;
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(cadenaAencriptar);
            result = Convert.ToBase64String(encryted);
            return result;
        }
        //desencriptacion de contraseña
        public string Desencriptar(string cadenaAdesencriptar)
        {
            string result = string.Empty;
            byte[] decryted = Convert.FromBase64String(cadenaAdesencriptar);
            result = System.Text.Encoding.Unicode.GetString(decryted, 0, decryted.ToArray().Length);
            return result;
        }
        public bool VerificacionCrearUsuario(string nombre, string apellido, string dni, string correo, string direccion, string telefono, string usuario, string contraseña)
        {
            if (nombre == string.Empty || apellido == string.Empty || dni == string.Empty || correo == string.Empty || direccion == string.Empty || telefono == string.Empty || usuario == string.Empty || contraseña == string.Empty)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        //Detectar tipo de tarjeta
        public string TipoTarjeta(string tarjeta)
        {
            if (tarjeta.StartsWith("4"))
            {
                return "Visa";
            }
            else if (tarjeta.StartsWith("5"))
            {
                return "MasterCard";
            }
            else if (tarjeta.StartsWith("3"))
            {
                return "American Express";
            }
            else
            {
                return "Desconocida";
            }
        }
        //Verificar tarjeta
        public bool VerificarTarjeta(string tarjeta)
        {
            if (tarjeta.Length == 16)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Verificar fecha de vencimiento
        public bool VerificarFechaVencimiento(string fecha)
        {
            if (fecha.Length == 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Verificar codigo de seguridad
        public bool VerificarCodigoSeguridad(string codigo)
        {
            if (codigo.Length == 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
