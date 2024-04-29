using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acceso_a_Datos
{
    public class ModeloAuditoria : ConexionSQL1
    {
        public void InsertarAuditoria(int idUsuario, string accion, string descripcion)
        {
            using(var connection = GetConnection())
            {
                connection.Open();
                using(var command = connection.CreateCommand())
                {
                    command.CommandText = "INSERT INTO auditoria VALUES (@idUsuario, @accion, @descripcion, @fecha)";
                    command.Parameters.AddWithValue("@idUsuario", idUsuario);
                    command.Parameters.AddWithValue("@fecha", DateTime.Now);
                    command.Parameters.AddWithValue("@accion", accion);
                    command.Parameters.AddWithValue("@descripcion", descripcion);
                    command.ExecuteNonQuery();
                }
            }
        }
        public DataTable ObtenerAuditoria()
        {
            DataTable tabla = new DataTable();
            using(var connection = GetConnection())
            {
                connection.Open();
                using(var command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT auditoria.id_auditoria, usuarios.id_usuario, usuarios.nombre, auditoria.accion, auditoria.descripcion, auditoria.fecha FROM auditoria INNER JOIN usuarios ON auditoria.id_usuario = usuarios.id_usuario;";
                    using(var reader = command.ExecuteReader())
                    {
                        tabla.Load(reader);
                    }
                }
            }
            return tabla;
        }
    }
}
