using System.Data;

namespace Dominio
{
    public interface IControladoraUsuario
    {
        string LoginUser(string user, string pass);
        string ObtenerNombre();
        string ObtenerApellido();
        string ObtenerDNI();
        string ObtenerEmail();
        string ObtenerDireccion();
        string ObtenerTelefono();
        string ObtenerUsuario();
        string ObtenerPassword();
        int ObtenerIDUsuario();
        int ObtenerIDRol();
        string ObtenerRol();
        DataTable ActualizarLista();
        DataTable ActualizarClientes();
        string AgregarUsuario(int cliente, string nombre, string apellido, string dni, string email, string direccion, string telefono, string usuario, string password, int idRol, bool activo);
        bool ModifcarUsuario(int idUsuario, string nombre, string apellido, string dni, string email, string direccion, string telefono, string usuario, string password, int idRol, bool userActivo);
        bool EliminarUsuario(int idUsuario);
        void DesactivarUsuario(int idUsuario);
        void ActivarUsuario(int idUsuario);
        void LlenarCacheUsuario();
        string ObtenerDNI(int idUsuario);
        int ObtenerIdPorDNI(string dni);
        bool ExisteDNI(string dni);
        DataTable BuscarUsuarioActivoInactivo(string busqueda, string rol, int activo);
        DataTable BuscarUsuario(string busqueda, string rol);
        bool UsuarioActivo(string DNI);
    }

}
