using Comun.Cache;
using Dominio;
using System.Data;


namespace Dominio
{
    public class ControladoraUsuarioConAuditoria : IControladoraUsuario
    {
        private readonly IControladoraUsuario _controladoraUsuario;
        private readonly ControladoraAuditoria _auditoria;

        public ControladoraUsuarioConAuditoria(IControladoraUsuario controladoraUsuario)
        {
            _controladoraUsuario = controladoraUsuario;
            _auditoria = new ControladoraAuditoria();
        }

        public string LoginUser(string user, string pass)
        {
            var resultado = _controladoraUsuario.LoginUser(user, pass);
            if (resultado == "true")
            {
                _auditoria.InsertarAuditoria(CacheUsuario.IdUsuario, "Login", "El usuario ha iniciado sesión");
            }
            return resultado;
        }

        // Otros métodos de IControladoraUsuario con funcionalidad de auditoría...

        public string ObtenerNombre() => _controladoraUsuario.ObtenerNombre();
        public string ObtenerApellido() => _controladoraUsuario.ObtenerApellido();
        public string ObtenerDNI() => _controladoraUsuario.ObtenerDNI();
        public string ObtenerEmail() => _controladoraUsuario.ObtenerEmail();
        public string ObtenerDireccion() => _controladoraUsuario.ObtenerDireccion();
        public string ObtenerTelefono() => _controladoraUsuario.ObtenerTelefono();
        public string ObtenerUsuario() => _controladoraUsuario.ObtenerUsuario();
        public string ObtenerPassword() => _controladoraUsuario.ObtenerPassword();
        public int ObtenerIDUsuario() => _controladoraUsuario.ObtenerIDUsuario();
        public int ObtenerIDRol() => _controladoraUsuario.ObtenerIDRol();
        public string ObtenerRol() => _controladoraUsuario.ObtenerRol();
        public DataTable ActualizarLista() => _controladoraUsuario.ActualizarLista();
        public DataTable ActualizarClientes() => _controladoraUsuario.ActualizarClientes();
        public string AgregarUsuario(int cliente, string nombre, string apellido, string dni, string email, string direccion, string telefono, string usuario, string password, int idRol, bool activo)
        {
            var resultado = _controladoraUsuario.AgregarUsuario(cliente, nombre, apellido, dni, email, direccion, telefono, usuario, password, idRol, activo);
            _auditoria.InsertarAuditoria(CacheUsuario.IdUsuario, "Agregar Usuario", "Se ha agregado un usuario: " + nombre + " " + apellido + ". Con ID: " + ObtenerIdPorDNI(dni));
            return resultado;
        }
        public bool ModifcarUsuario(int idUsuario, string nombre, string apellido, string dni, string email, string direccion, string telefono, string usuario, string password, int idRol, bool userActivo)
        {
            var resultado = _controladoraUsuario.ModifcarUsuario(idUsuario, nombre, apellido, dni, email, direccion, telefono, usuario, password, idRol, userActivo);
            if (resultado)
            {
                _auditoria.InsertarAuditoria(CacheUsuario.IdUsuario, "Modificar Usuario", "Se ha modificado un usuario: " + nombre + " " + apellido + ". Con ID: " + idUsuario);
            }
            return resultado;
        }
        public bool EliminarUsuario(int idUsuario)
        {
            var resultado = _controladoraUsuario.EliminarUsuario(idUsuario);
            if (resultado == false)
            {
                _auditoria.InsertarAuditoria(CacheUsuario.IdUsuario, "Eliminar Usuario", "Se ha eliminado un usuario con ID: " + idUsuario);
            }
            return resultado;
        }
        public void DesactivarUsuario(int idUsuario)
        {
            _controladoraUsuario.DesactivarUsuario(idUsuario);
            _auditoria.InsertarAuditoria(CacheUsuario.IdUsuario, "Desactivar Usuario", "Se ha desactivado un usuario con ID: " + idUsuario);
        }
        public void ActivarUsuario(int idUsuario)
        {
            _controladoraUsuario.ActivarUsuario(idUsuario);
            _auditoria.InsertarAuditoria(CacheUsuario.IdUsuario, "Activar Usuario", "Se ha activado un usuario con ID: " + idUsuario);
        }

        public void LlenarCacheUsuario() => _controladoraUsuario.LlenarCacheUsuario();
        public string ObtenerDNI(int idUsuario) => _controladoraUsuario.ObtenerDNI(idUsuario);
        public int ObtenerIdPorDNI(string dni) => _controladoraUsuario.ObtenerIdPorDNI(dni);
        public bool ExisteDNI(string dni) => _controladoraUsuario.ExisteDNI(dni);
        public DataTable BuscarUsuarioActivoInactivo(string busqueda, string rol, int activo) => _controladoraUsuario.BuscarUsuarioActivoInactivo(busqueda, rol, activo);
        public DataTable BuscarUsuario(string busqueda, string rol) => _controladoraUsuario.BuscarUsuario(busqueda, rol);
        public bool UsuarioActivo(string DNI) => _controladoraUsuario.UsuarioActivo(DNI);
    }

}