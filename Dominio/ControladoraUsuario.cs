using Acceso_a_Datos;


namespace Dominio
{
    public class ControladoraUsuario
    {
        ModeloUsuario userDao = new ModeloUsuario();
        public bool LoginUser(string user, string pass)
        {
            return userDao.Login(user, pass);
        }
    }
}