using System;
using System.Collections.Generic;
using System.Linq;
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
                    }

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
                    }
                }
            }
        }
        //Ver permisos de un rol
        public bool VerPermisos(int idRol, int idPermiso)
        {
            bool permiso = false;
            using (var con = GetConnection())
            {
                con.Open();
                using (var cmd = con.CreateCommand())
                {
                    cmd.CommandText = "select * from roles_permisos where id_rol = @id_rol and id_permiso = @id_permiso";
                    cmd.Parameters.AddWithValue("@id_rol", idRol);
                    cmd.Parameters.AddWithValue("@id_permiso", idPermiso);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            permiso = true;
                        }
                    }
                }
            }
            return permiso;
        }


    }
}
