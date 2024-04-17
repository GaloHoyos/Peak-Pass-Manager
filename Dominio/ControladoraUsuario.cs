using Acceso_a_Datos;
using Comun;
using Comun.Cache;
using System.Data;


namespace Dominio
{
    public class ControladoraUsuario
    {
        ModeloUsuario modeloUsuario = new ModeloUsuario();
        public string LoginUser(string user, string pass)
        {
            Verificaciones verificaciones = new Verificaciones();
            string passEncriptada = verificaciones.Encriptar(pass);
            return modeloUsuario.Login(user, passEncriptada);
        }
        //metodo obtener el nombre del usuario
        public string ObtenerNombre()
        {
            return ModeloUsuario.Nombre;
        }
        public string ObtenerApellido()
        {
            return ModeloUsuario.Apellido;
        }
        public string ObtenerDNI()
        {
            return ModeloUsuario.DNI;
        }
        public string ObtenerEmail()
        {
            return ModeloUsuario.Email;
        }
        public string ObtenerDireccion()
        {
            return ModeloUsuario.Direccion;
        }
        public string ObtenerTelefono()
        {
            return ModeloUsuario.Telefono;
        }
        public string ObtenerUsuario()
        {
            return ModeloUsuario.Usuario;
        }
        public string ObtenerPassword()
        {
            return ModeloUsuario.Password;
        }
        public int ObtenerIDUsuario()
        {
            return ModeloUsuario.IdUsuario;
        }
        public int ObtenerIDRol()
        {
            return ModeloUsuario.IdRol;
        }
        public string ObtenerRol()
        {
            return ModeloUsuario.Rol;
        }

        //Crea una tabla y mete los datos de ModeloUsuario en ella
        public DataTable ActualizarLista()
        {
            DataTable dt = new DataTable();
            dt = modeloUsuario.ActualizarLista();
            return dt;
        }

        public DataTable ActualizarClientes()
        {
            DataTable dt = new DataTable();
            dt = modeloUsuario.ActualizarClientes();
            return dt;
        }

        //metodo para agregar un usuario
        public void AgregarUsuario(string nombre, string apellido, string dni, string email, string direccion, string telefono, string usuario, string password, int idRol)
        {
            Verificaciones verificaciones = new Verificaciones();
            string passEncriptada = verificaciones.Encriptar(password);
            modeloUsuario.AgregarUsuario(nombre, apellido, dni, email, direccion, telefono, usuario, passEncriptada, idRol);
        }
        public void ModifcarUsuario(int idUsuario, string nombre, string apellido, string dni, string email, string direccion, string telefono, string usuario, string password, int idRol)
        {
            Verificaciones verificaciones = new Verificaciones();
            string passEncriptada = verificaciones.Encriptar(password);
            modeloUsuario.ModificarUsuario(idUsuario, nombre, apellido, dni, email, direccion, telefono, usuario, passEncriptada, idRol);
        }
        public void EliminarUsuario(int idUsuario)
        {
            modeloUsuario.EliminarUsuario(idUsuario);
        }

        //Llenar cache de usuario con los datos del usuario logueado
        public void LlenarCacheUsuario()
        {
            CacheUsuario.IdUsuario = ModeloUsuario.IdUsuario;
            CacheUsuario.Nombre = ModeloUsuario.Nombre;
            CacheUsuario.Apellido = ModeloUsuario.Apellido;
            CacheUsuario.DNI = ModeloUsuario.DNI;
            CacheUsuario.Correo = ModeloUsuario.Email;
            CacheUsuario.Direccion = ModeloUsuario.Direccion;
            CacheUsuario.Telefono = ModeloUsuario.Telefono;

        }

    }
}