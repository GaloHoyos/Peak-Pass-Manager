using System;
using System.Collections.Generic;
using System.Linq;
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
                                }
                           }
                    }
                }
            }
        }

    }
}
