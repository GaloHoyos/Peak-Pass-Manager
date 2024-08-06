using Acceso_a_Datos;
using Comun;
using Comun.Cache;
using System.Data;


namespace Dominio
{
    public class ControladoraUsuario : IControladoraUsuario
    {
        ModeloUsuario modeloUsuario = new ModeloUsuario();
        public string LoginUser(string user, string pass)
        {
            Verificaciones verificaciones = new Verificaciones();
            string passEncriptada = verificaciones.Encriptar(pass);
            var loginExitoso = modeloUsuario.Login(user, passEncriptada);
            if(loginExitoso == "true")
            {
                LlenarCacheUsuario();
            }
            return loginExitoso;
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
        public string AgregarUsuario(int cliente, string nombre, string apellido, string dni, string email, string direccion, string telefono, string usuario, string password, int idRol, bool activo)
        {
            if (cliente == 1)
            {
                if (modeloUsuario.ExisteDNI(dni))
                {
                    if (modeloUsuario.UsuarioActivo(dni))
                    {
                        return "Usuario Existente";
                    }
                    else
                    {
                        return "Inactivo y Existente";
                    }
                }
                else
                {
                    Verificaciones verificaciones = new Verificaciones();
                    string passEncriptada = verificaciones.Encriptar(password);
                    modeloUsuario.AgregarUsuario(nombre, apellido, dni, email, direccion, telefono, usuario, passEncriptada, idRol, activo);
                    return "No Existente";
                }
            }
            else if (cliente == 0) 
            {
                if (modeloUsuario.ExisteDNI(dni))
                {
                    if (modeloUsuario.UsuarioActivo(dni))
                    {
                        return "DNI Existente";
                    }
                    else
                    {
                        return "Inactivo y Existente";
                    }
                }
                else if (modeloUsuario.ExisteUsuario(usuario))
                {
                    return "Usuario Existente";
                }
                else
                {
                    Verificaciones verificaciones = new Verificaciones();
                    string passEncriptada = verificaciones.Encriptar(password);
                    modeloUsuario.AgregarUsuario(nombre, apellido, dni, email, direccion, telefono, usuario, passEncriptada, idRol, activo);
                    return "No Existente";
                }
            }
            else
            {
                return "Error";
            }
        }
        public bool ModifcarUsuario(int idUsuario, string nombre, string apellido, string dni, string email, string direccion, string telefono, string usuario, string password, int idRol, bool userActivo)
        {
            Verificaciones verificaciones = new Verificaciones();
            string passEncriptada = verificaciones.Encriptar(password);
            bool modificado = modeloUsuario.ModificarUsuario(idUsuario, nombre, apellido, dni, email, direccion, telefono, usuario, passEncriptada, idRol, userActivo);
            return modificado;
        }
        public bool EliminarUsuario(int idUsuario)
        {
            bool existePedido = modeloUsuario.EliminarUsuario(idUsuario);
            return existePedido;
        }
        public void DesactivarUsuario(int idUsuario)
        {
            modeloUsuario.DesactivarUsuario(idUsuario);
        }
        public void ActivarUsuario(int idUsuario)
        {
            modeloUsuario.ActivarUsuario(idUsuario);
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
            CacheUsuario.Activo = ModeloUsuario.Activo;
            CacheUsuario.idRol = ModeloUsuario.IdRol;
        }
        public string ObtenerDNI(int idUsuario)
        {
            return modeloUsuario.ObtenerDNI(idUsuario);
        }
        public int ObtenerIdPorDNI(string dni)
        {
            return modeloUsuario.ObtenerIdPorDNI(dni);
        }
        public bool ExisteDNI(string dni)
        {
            return modeloUsuario.ExisteDNI(dni);
        }

        //Buscar usuario
        public DataTable BuscarUsuarioActivoInactivo(string busqueda, string rol, int activo)
        {
            DataTable dt = new DataTable();
            dt = modeloUsuario.BuscarUsuarioActivoInactivo(busqueda, rol, activo);
            return dt;
        }
        public DataTable BuscarUsuario(string busqueda, string rol)
        {
            DataTable dt = new DataTable();
            dt = modeloUsuario.BuscarUsuario(busqueda, rol);
            return dt;
        }
        public bool UsuarioActivo(string DNI)
        {
            return modeloUsuario.UsuarioActivo(DNI);
        }

    }
}