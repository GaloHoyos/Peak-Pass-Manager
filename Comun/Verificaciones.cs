using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Comun
{
    public class Verificaciones
    {

        private ValidadorUsuario validador = new ValidadorUsuario();

        public bool VerificacionCrearUsuario(string nombre, string apellido, string dni, string correo, string direccion, string telefono, string usuario, string contraseña)
        {
            Usuario user = new Usuario
            {
                Nombre = nombre,
                Apellido = apellido,
                Dni = dni,
                Correo = correo,
                Direccion = direccion,
                Telefono = telefono,
                NombreUsuario = usuario,
                Contraseña = contraseña
            };

            return validador.VerificacionCrearUsuario(user);
        }

        public bool VerificacionCrearCliente(string nombre, string apellido, string dni, string correo, string direccion, string telefono)
        {
            Usuario cliente = new Usuario
            {
                Nombre = nombre,
                Apellido = apellido,
                Dni = dni,
                Correo = correo,
                Direccion = direccion,
                Telefono = telefono,
            };

            return validador.VerificacionCrearCliente(cliente);
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
        public bool VerificarFecha(string fecha)
        {
            if (DateTime.Parse(fecha) > DateTime.Now)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Verificar codigo de seguridad
        public bool VerificarCVV(string codigo)
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
    public class Usuario
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
    }
    public class ValidadorUsuario
    {
        public bool VerificacionCrearUsuario(Usuario usuario)
        {
            if (string.IsNullOrWhiteSpace(usuario.Nombre) ||
                string.IsNullOrWhiteSpace(usuario.Apellido) ||
                !ValidarDni(usuario.Dni) ||
                !ValidarCorreo(usuario.Correo) ||
                string.IsNullOrWhiteSpace(usuario.Direccion) ||
                !ValidarTelefono(usuario.Telefono) ||
                string.IsNullOrWhiteSpace(usuario.NombreUsuario) ||
                !ValidarContraseña(usuario.Contraseña))
            {
                return false;
            }
            return true;
        }
        public bool VerificacionCrearCliente(Usuario cliente)
        {
            if (string.IsNullOrWhiteSpace(cliente.Nombre) ||
                string.IsNullOrWhiteSpace(cliente.Apellido) ||
                !ValidarDni(cliente.Dni) ||
                !ValidarCorreo(cliente.Correo) ||
                string.IsNullOrWhiteSpace(cliente.Direccion) ||
                !ValidarTelefono(cliente.Telefono))
            {
                return false;
            }
            return true;
        }

        private bool ValidarDni(string dni)
        {
            // Ejemplo de validación básica de longitud, puedes ajustar según tus necesidades
            return !string.IsNullOrWhiteSpace(dni) && dni.Length == 8 && dni.All(char.IsDigit);
        }

        private bool ValidarCorreo(string correo)
        {
            // Ejemplo de validación de correo electrónico
            return Regex.IsMatch(correo, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        private bool ValidarTelefono(string telefono)
        {
            // Ejemplo de validación de teléfono
            return Regex.IsMatch(telefono, @"^\+?[0-9]{7,15}$");
        }

        private bool ValidarContraseña(string contraseña)
        {
            // Ejemplo de validación de contraseña (mínimo 8 caracteres)
            return !string.IsNullOrWhiteSpace(contraseña) && contraseña.Length >= 6;
        }
    }

}
