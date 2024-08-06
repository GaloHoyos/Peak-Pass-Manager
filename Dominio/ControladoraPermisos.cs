using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acceso_a_Datos;

namespace Dominio
{
    public class ControladoraPermisos
    {
        public static bool CatalogoSeleccion { get; set; }
        public static bool ClientesSeleccion { get; set; }
        public static bool OpcionesSeleccion { get; set; }
        public static bool PedidosSeleccion { get; set; }
        public static bool UsuariosSeleccion { get; set; }
        public static bool EditarPermisosSeleccion { get; set; }
        public static bool EditarCatalogosSeleccion { get; set; }
        public static bool EditarProductosSeleccion { get; set; }
        public static bool ReportesSeleccion { get; set; }
        public static bool AuditoriaSeleccion { get; set; }
        public static bool AgregarClientesSeleccion { get; set; }
        public static bool ModificarClientesSeleccion { get; set; }
        public static bool EliminarClientesSeleccion { get; set; }
        public static bool AgregarUsuariosSeleccion { get; set; }
        public static bool ModificarUsuariosSeleccion { get; set; }
        public static bool EliminarUsuariosSeleccion { get; set; }
        public static bool AgregarRolesSeleccion { get; set; }
        public static bool EliminarRolesSeleccion { get; set; }


        ModeloPermisos modeloPermisos = new ModeloPermisos();
        //obtener los permisos del usuario
        public bool Catalogo()
        {
            return ModeloPermisos.Catalogo;
        }
        public bool Clientes()
        {
            return ModeloPermisos.Clientes;
        }
        public bool Opciones()
        {
            return ModeloPermisos.Opciones;
        }
        public bool Pedidos()
        {
            return ModeloPermisos.Pedidos;
        }
        public bool Usuarios()
        {
            return ModeloPermisos.Usuarios;
        }
        public bool EditarPermisos()
        {
            return ModeloPermisos.EditarPermisos;
        }
        public bool EditarCatalogos()
        {
            return ModeloPermisos.EditarCatalogos;
        }
        public bool EditarProductos()
        {
            return ModeloPermisos.EditarProductos;
        }
        public bool Reportes()
        {
            return ModeloPermisos.Reportes;
        }
        public bool Auditoria()
        {
            return ModeloPermisos.Auditoria;
        }
        public bool AgregarClientes()
        {
            return ModeloPermisos.AgregarClientes;
        }
        public bool ModificarClientes()
        {
            return ModeloPermisos.ModificarClientes;
        }
        public bool EliminarClientes()
        {
            return ModeloPermisos.EliminarClientes;
        }
        public bool AgregarUsuarios()
        {
            return ModeloPermisos.AgregarUsuarios;
        }
        public bool ModificarUsuarios()
        {
            return ModeloPermisos.ModificarUsuarios;
        }
        public bool EliminarUsuarios()
        {
            return ModeloPermisos.EliminarUsuarios;
        }
        public bool AgregarRoles()
        {
            return ModeloPermisos.AgregarRoles;
        }
        public bool EliminarRoles()
        {
            return ModeloPermisos.EliminarRoles;
        }
        //Modificar permisos con una lista de permisos
        public void ModificarPermisos(int idRol, List<int> permisos)
        {
            modeloPermisos.ModificarPermisos(idRol, permisos);
        }
        //Ver permisos de un rol
        public bool AgregarRol(string nombreRol)
        {
            bool existe = modeloPermisos.AgregarRol(nombreRol);
            return existe;
        }
        public bool EliminarRol(int idRol)
        {
            bool existenUsuarios = modeloPermisos.EliminarRol(idRol);
            return existenUsuarios;
        }
        public int ObtenerIdRol(string nombreRol)
        {
            int idRol = modeloPermisos.ObtenerIdRol(nombreRol);
            return idRol;
        }
        public List<string> ObtenerRolesActivos()
        {
            List<string> roles = modeloPermisos.ObtenerRolesActivos();
            return roles;
        }
        public List<string> ObtenerRolesInactivos()
        {
            List<string> roles = modeloPermisos.ObtenerRolesInactivos();
            return roles;
        }
        public void HabilitarRol(int idRol)
        {
            modeloPermisos.HabilitarRol(idRol);
        }
        public void DeshabilitarRol(int idRol)
        {
            modeloPermisos.DeshabilitarRol(idRol);
        }
        //Llena las variables de la controladora con los permisos del rol seleccionado
        public void LlenarPermisos(int idRol)
        {
            CatalogoSeleccion = false;
            ClientesSeleccion = false;
            OpcionesSeleccion = false;
            PedidosSeleccion = false;
            UsuariosSeleccion = false;
            EditarPermisosSeleccion = false;
            EditarCatalogosSeleccion = false;
            EditarProductosSeleccion = false;
            ReportesSeleccion = false;
            AuditoriaSeleccion = false;
            AgregarClientesSeleccion = false;
            ModificarClientesSeleccion = false;
            EliminarClientesSeleccion = false;
            AgregarUsuariosSeleccion = false;
            ModificarUsuariosSeleccion = false;
            EliminarUsuariosSeleccion = false;
            AgregarRolesSeleccion = false;
            EliminarRolesSeleccion = false;
            List<string> permisos = modeloPermisos.VerPermisos(idRol);
            foreach (string permiso in permisos)
            {
                switch (permiso)
                {
                    case "Catalogo":
                        CatalogoSeleccion = true;
                        break;
                    case "Clientes":
                        ClientesSeleccion = true;
                        break;
                    case "Opciones":
                        OpcionesSeleccion = true;
                        break;
                    case "Pedidos":
                        PedidosSeleccion = true;
                        break;
                    case "Usuarios":
                        UsuariosSeleccion = true;
                        break;
                    case "Editar Permisos":
                        EditarPermisosSeleccion = true;
                        break;
                    case "Editar Catalogos":
                        EditarCatalogosSeleccion = true;
                        break;
                    case "Editar Productos":
                        EditarProductosSeleccion = true;
                        break;
                    case "Reportes":
                        ReportesSeleccion = true;
                        break;
                    case "Auditoria":
                        AuditoriaSeleccion = true;
                        break;
                    case "Agregar Clientes":
                        AgregarClientesSeleccion = true;
                        break;
                    case "Modificar Clientes":
                        ModificarClientesSeleccion = true;
                        break;
                    case "Eliminar Clientes":
                        EliminarClientesSeleccion = true;
                        break;
                    case "Agregar Usuarios":
                        AgregarUsuariosSeleccion = true;
                        break;
                    case "Modificar Usuarios":
                        ModificarUsuariosSeleccion = true;
                        break;
                    case "Eliminar Usuarios":
                        EliminarUsuariosSeleccion = true;
                        break;
                    case "Agregar Roles":
                        AgregarRolesSeleccion = true;
                        break;
                    case "Eliminar Roles":
                        EliminarRolesSeleccion = true;
                        break;
                }
            }
        }
    }
}
