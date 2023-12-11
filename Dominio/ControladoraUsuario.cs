using Acceso_a_Datos;
using Comun;


namespace Dominio
{
    public class ControladoraUsuario
    {
        ModeloUsuario userDao = new ModeloUsuario();
        public bool LoginUser(string user, string pass)
        {
            Verificaciones verificaciones = new Verificaciones();
            string passEncriptada = verificaciones.Encriptar(pass);
            return userDao.Login(user, passEncriptada);
        }
        //get de datos de usuario
        public string ObtenerNombre()
        {
            return ModeloUsuario.Nombre;
        }
        public string ObtenerApellido()
        {
            return ModeloUsuario.Apellido;
        }
        public string ObtenerUsuario()
        {
            return ModeloUsuario.Usuario;
        }
        public string ObtenerContrasena()
        {
            return ModeloUsuario.Contrasena;
        }
        public string ObtenerEmail()
        {
            return ModeloUsuario.Email;
        }
        public string ObtenerDNI()
        {
            return ModeloUsuario.DNI;
        }
        public int ObtenerIdUsuario()
        {
            return ModeloUsuario.IdUsuario;
        }

    }
}