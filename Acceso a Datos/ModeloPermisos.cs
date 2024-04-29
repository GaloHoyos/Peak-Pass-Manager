using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Acceso_a_Datos
{
    public class ModeloPermisos : ConexionSQL1
    {
        public static bool Catalogo { get; set; }
        public static bool Clientes { get; set; }
        public static bool Opciones { get; set; }
        public static bool Pedidos { get; set; }
        public static bool Usuarios { get; set; }
        public static bool EditarPermisos { get; set; }
        public static bool EditarCatalogos { get; set; }
        public static bool EditarProductos { get; set; }
        public static bool Reportes { get; set; }
        public static bool Auditoria { get; set; }
        public static bool AgregarClientes { get; set; }
        public static bool ModificarClientes { get; set; }
        public static bool EliminarClientes { get; set; }
        public static bool AgregarUsuarios { get; set; }
        public static bool ModificarUsuarios { get; set; }
        public static bool EliminarUsuarios { get; set; }
        public static bool AgregarRoles { get; set; }
        ModeloAuditoria modeloAuditoria = new ModeloAuditoria();
        public ModeloPermisos()
        {
            Catalogo = false;
            Clientes = false;
            Opciones = false;
            Pedidos = false;
            Usuarios = false;
            EditarPermisos = false;
            EditarCatalogos = false;
            EditarProductos = false;
            Reportes = false;
            Auditoria = false;
            AgregarClientes = false;
            ModificarClientes = false;
            EliminarClientes = false;
            AgregarUsuarios = false;
            ModificarUsuarios = false;
            EliminarUsuarios = false;
            //Obtener los permisos del usuario
            using (var con = GetConnection())
            {
                con.Open();
                using (var cmd = con.CreateCommand())
                {
                    cmd.CommandText = "select id_permiso from roles_permisos inner join usuarios on roles_permisos.id_rol = usuarios.id_rol where usuarios.id_usuario = @id_usuario";
                    cmd.Parameters.AddWithValue("@id_usuario", ModeloUsuario.IdUsuario);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                           switch (reader.GetInt32(0))
                           {
                                case 1:
                                    Catalogo = true;
                                    break;
                                case 2:
                                    Clientes = true;
                                    break;
                                case 3:
                                    Opciones = true;
                                    break;
                                case 4:
                                    Pedidos = true;
                                    break;
                                case 5:
                                    Usuarios = true;
                                    break;
                                case 6:
                                    EditarPermisos = true;
                                    break;
                                case 7:
                                    EditarCatalogos = true;
                                    break;
                                case 8:
                                    EditarProductos = true;
                                    break;
                                case 9:
                                    Reportes = true;
                                    break;
                                case 10:
                                    Auditoria = true;
                                    break;
                                case 11:
                                    AgregarClientes = true;
                                    break;
                                case 12:
                                    ModificarClientes = true;
                                    break;
                                case 13:
                                    EliminarClientes = true;
                                    break;
                                case 14:
                                    AgregarUsuarios = true;
                                    break;
                                case 15:
                                    ModificarUsuarios = true;
                                    break;
                                case 16:
                                    EliminarUsuarios = true;
                                    break;
                                case 17:
                                    AgregarRoles = true;
                                    break;
                           }
                        }
                    }
                }
            }
        }
        //Modificar los permisos del rol seleccionado
        public void AgregarPermisos(int idRol, int idPermiso)
        {
            EliminarPermisos(idRol, idPermiso);
            using (var con = GetConnection())
            {
                con.Open();
                using (var cmd = con.CreateCommand())
                {
                    cmd.CommandText = "insert into roles_permisos values(@id_rol, @id_permiso)";
                    cmd.Parameters.AddWithValue("@id_rol", idRol);
                    cmd.Parameters.AddWithValue("@id_permiso", idPermiso);
                    cmd.ExecuteNonQuery();
                    switch (idPermiso)
                    {
                        case 1:
                            Catalogo = true;
                            break;
                        case 2:
                            Clientes = true;
                            break;
                        case 3:
                            Opciones = true;
                            break;
                        case 4:
                            Pedidos = true;
                            break;
                        case 5:
                            Usuarios = true;
                            break;
                        case 6:
                            EditarPermisos = true;
                            break;
                        case 7:
                            EditarCatalogos = true;
                            break;
                        case 8:
                            EditarProductos = true;
                            break;
                        case 9:
                            Reportes = true;
                            break;
                        case 10:
                            Auditoria = true;
                            break;
                        case 11:
                            AgregarClientes = true;
                            break;
                        case 12:
                            ModificarClientes = true;
                            break;
                        case 13:
                            EliminarClientes = true;
                            break;
                        case 14:
                            AgregarUsuarios = true;
                            break;
                        case 15:
                            ModificarUsuarios = true;
                            break;
                        case 16:
                            EliminarUsuarios = true;
                            break;
                        case 17:
                            AgregarRoles = true;
                            break;
                    }
                    modeloAuditoria.InsertarAuditoria(ModeloUsuario.IdUsuario, "Agregar Permiso", "Se ha agregado el permiso '" + VerNombrePermiso(idPermiso) + "' al rol '" + VerNombreRol(idRol) + "' con ID " + idRol);
                }
            }
        }
        //Eliminar los permisos del rol seleccionado
        public void EliminarPermisos(int idRol, int idPermiso)
        {
            using (var con = GetConnection())
            {
                con.Open();
                using (var cmd = con.CreateCommand())
                {
                    cmd.CommandText = "delete from roles_permisos where id_rol = @id_rol and id_permiso = @id_permiso";
                    cmd.Parameters.AddWithValue("@id_rol", idRol);
                    cmd.Parameters.AddWithValue("@id_permiso", idPermiso);
                    cmd.ExecuteNonQuery();
                    switch (idPermiso)
                    {
                        case 1:
                            Catalogo = false;
                            break;
                        case 2:
                            Clientes = false;
                            break;
                        case 3:
                            Opciones = false;
                            break;
                        case 4:
                            Pedidos = false;
                            break;
                        case 5:
                            Usuarios = false;
                            break;
                        case 6:
                            EditarPermisos = false;
                            break;
                        case 7:
                            EditarCatalogos = false;
                            break;
                        case 8:
                            EditarProductos = false;
                            break;
                        case 9:
                            Reportes = false;
                            break;
                        case 10:
                            Auditoria = false;
                            break;
                        case 11:
                            AgregarClientes = false;
                            break;
                        case 12:
                            ModificarClientes = false;
                            break;
                        case 13:
                            EliminarClientes = false;
                            break;
                        case 14:
                            AgregarUsuarios = false;
                            break;
                        case 15:
                            ModificarUsuarios = false;
                            break;
                        case 16:
                            EliminarUsuarios = false;
                            break;
                        case 17:
                            AgregarRoles = false;
                            break;
                    }
                    modeloAuditoria.InsertarAuditoria(ModeloUsuario.IdUsuario, "Eliminar Permiso", "Se ha eliminado el permiso '" + VerNombrePermiso(idPermiso) + "' del rol '" + VerNombreRol(idRol) + "' con ID " + idRol);
                }
            }
        }
        //Ver nombre de un permiso
        public string VerNombrePermiso(int idPermiso)
        {
            string nombrePermiso = "";
            using (var con = GetConnection())
            {
                con.Open();
                using (var cmd = con.CreateCommand())
                {
                    cmd.CommandText = "select nombre_permiso from permisos where id_permiso = @id_permiso";
                    cmd.Parameters.AddWithValue("@id_permiso", idPermiso);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            nombrePermiso = reader.GetString(0);
                        }
                    }
                }
            }
            return nombrePermiso;
        }
        //Ver nombre de un rol
        public string VerNombreRol(int idRol)
        {
            string nombreRol = "";
            using (var con = GetConnection())
            {
                con.Open();
                using (var cmd = con.CreateCommand())
                {
                    cmd.CommandText = "select nombre_rol from roles where id_rol = @id_rol";
                    cmd.Parameters.AddWithValue("@id_rol", idRol);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            nombreRol = reader.GetString(0);
                        }
                    }
                }
            }
            return nombreRol;
        }
        //Ver todos los nombres de los permisos de un rol
        public List<string> VerPermisos(int idRol)
        {
            List<string> permisos = new List<string>();
            using (var con = GetConnection())
            {
                con.Open();
                using (var cmd = con.CreateCommand())
                {
                    cmd.CommandText = "select nombre_permiso from roles_permisos inner join permisos on roles_permisos.id_permiso = permisos.id_permiso where id_rol = @id_rol";
                    cmd.Parameters.AddWithValue("@id_rol", idRol);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            permisos.Add(reader.GetString(0));
                        }
                    }
                }
            }
            return permisos;
        }

        public bool AgregarRol(string nombreRol)
        {
            bool existe = false;
            using (var con = GetConnection())
            {
                con.Open();
                using (var cmd = con.CreateCommand())
                {
                    cmd.CommandText = "select * from roles where nombre_rol = @nombre_rol";
                    cmd.Parameters.AddWithValue("@nombre_rol", nombreRol);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            existe = true;
                            return existe;
                        }
                    }
                }
            }
            if (!existe)
            {
                using (var con = GetConnection())
                {
                    con.Open();
                    using (var cmd = con.CreateCommand())
                    {
                        cmd.CommandText = "insert into roles values(@nombre_rol, 1)";
                        cmd.Parameters.AddWithValue("@nombre_rol", nombreRol);
                        cmd.ExecuteNonQuery();
                        modeloAuditoria.InsertarAuditoria(ModeloUsuario.IdUsuario, "Agregar Rol", "Se ha agregado el rol '" + nombreRol + "' con ID " + ObtenerIdRol(nombreRol));
                        return existe;
                    }
                }
            }
            else
            {
                return existe;
            }
        }
        //Elimina Roles si no hay usuarios asignados a ese rol
        public bool EliminarRol(int idRol)
        {
            bool existenUsuarios = false;
            using (var con = GetConnection())
            {
                con.Open();
                using (var cmd = con.CreateCommand())
                {
                    cmd.CommandText = "select * from usuarios where id_rol = @id_rol";
                    cmd.Parameters.AddWithValue("@id_rol", idRol);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            existenUsuarios = true;
                            return existenUsuarios;
                        }
                    }
                }
            }
            if (!existenUsuarios)
            {
                using (var con = GetConnection())
                {
                    con.Open();
                    using (var cmd = con.CreateCommand())
                    {
                        cmd.CommandText = "delete from roles_permisos where id_rol = @id_rol";
                        cmd.Parameters.AddWithValue("@id_rol", idRol);
                        cmd.ExecuteNonQuery();
                    }
                }
                using (var con = GetConnection())
                {
                    con.Open();
                    using (var cmd = con.CreateCommand())
                    {
                        cmd.CommandText = "delete from roles where id_rol = @id_rol";
                        cmd.Parameters.AddWithValue("@id_rol", idRol);
                        cmd.ExecuteNonQuery();
                        modeloAuditoria.InsertarAuditoria(ModeloUsuario.IdUsuario, "Eliminar Rol", "Se ha eliminado el rol '" + VerNombreRol(idRol) + "' con ID " + idRol);
                        return existenUsuarios;
                    }
                }
            }
            else
            {
                return existenUsuarios;
            }
        }
        //Busca el id del rol seleccionado
        public int ObtenerIdRol(string nombreRol)
        {
            int idRol = 0;
            using (var con = GetConnection())
            {
                con.Open();
                using (var cmd = con.CreateCommand())
                {
                    cmd.CommandText = "select id_rol from roles where nombre_rol = @nombre_rol";
                    cmd.Parameters.AddWithValue("@nombre_rol", nombreRol);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            idRol = reader.GetInt32(0);
                        }
                    }
                }
            }
            return idRol;
        }
        //Devuelve una lista con los nombres de los roles
        public List<string> ObtenerRolesActivos()
        {
            List<string> roles = new List<string>();
            using (var con = GetConnection())
            {
                con.Open();
                using (var cmd = con.CreateCommand())
                {
                    cmd.CommandText = "select nombre_rol from roles where activo = 1";
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            roles.Add(reader.GetString(0));
                        }
                    }
                }
            }
            return roles;
        }
        //Devuelve una lista con los nombres de los roles inactivos
        public List<string> ObtenerRolesInactivos()
        {
            List<string> roles = new List<string>();
            using (var con = GetConnection())
            {
                con.Open();
                using (var cmd = con.CreateCommand())
                {
                    cmd.CommandText = "select nombre_rol from roles where activo = 0";
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            roles.Add(reader.GetString(0));
                        }
                    }
                }
            }
            return roles;
        }
        //Modificar permisos
        public void ModificarPermisos(int idRol, List<int> permisos)
        {
            List<int> permisosActuales = new List<int>();
            using (var con = GetConnection())
            {
                con.Open();
                using (var cmd = con.CreateCommand())
                {
                    cmd.CommandText = "select id_permiso from roles_permisos where id_rol = @id_rol";
                    cmd.Parameters.AddWithValue("@id_rol", idRol);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            permisosActuales.Add(reader.GetInt32(0));
                        }
                    }
                }
            }
            foreach (int permiso in permisosActuales)
            {
                if (!permisos.Contains(permiso))
                {
                    EliminarPermisos(idRol, permiso);
                }
            }
            foreach (int permiso in permisos)
            {
                if (!permisosActuales.Contains(permiso))
                {
                    AgregarPermisos(idRol, permiso);
                }
            }
        }
        //Habilitar rol
        public void HabilitarRol(int idRol)
        {
            using (var con = GetConnection())
            {
                con.Open();
                using (var cmd = con.CreateCommand())
                {
                    cmd.CommandText = "update roles set activo = 1 where id_rol = @id_rol";
                    cmd.Parameters.AddWithValue("@id_rol", idRol);
                    cmd.ExecuteNonQuery();
                    modeloAuditoria.InsertarAuditoria(ModeloUsuario.IdUsuario, "Habilitar Rol", "Se ha habilitado el rol '" + VerNombreRol(idRol) + "' con ID " + idRol);
                }
            }
        }
        //Deshabilitar rol y usuarios asignados a ese rol
        public void DeshabilitarRol(int idRol)
        {
            using (var con = GetConnection())
            {
                con.Open();
                using (var cmd = con.CreateCommand())
                {
                    cmd.CommandText = "update roles set activo = 0 where id_rol = @id_rol";
                    cmd.Parameters.AddWithValue("@id_rol", idRol);
                    cmd.ExecuteNonQuery();
                    modeloAuditoria.InsertarAuditoria(ModeloUsuario.IdUsuario, "Deshabilitar Rol", "Se ha deshabilitado el rol '" + VerNombreRol(idRol) + "' con ID " + idRol);
                }
            }
            using (var con = GetConnection())
            {
                con.Open();
                using (var cmd = con.CreateCommand())
                {
                    cmd.CommandText = "update usuarios set activo = 0 where id_rol = @id_rol";
                    cmd.Parameters.AddWithValue("@id_rol", idRol);
                    cmd.ExecuteNonQuery();
                    modeloAuditoria.InsertarAuditoria(ModeloUsuario.IdUsuario, "Deshabilitar Usuarios", "Se han deshabilitado los usuarios asignados al rol '" + VerNombreRol(idRol) + "' con ID " + idRol);
                }
            }
        }
    }
}
