using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acceso_a_Datos
{
    public class ModeloProducto : ConexionSQL1
    {
        public DataTable ActualizarLista()
        {
            DataTable dt = new DataTable();
            using (var connection = GetConnection())
            {

                SqlDataAdapter da = new SqlDataAdapter("Select id_producto, nombre_producto, precio_producto, nombre_catalogo from productos ORDER BY 1", connection); //Escribimos el comando (Querry) que queremos llevar a cabo en la base de datos, en este caso para poder tomar los valores de una tabla
                da.SelectCommand.CommandType = CommandType.Text; //Indica como se interpretará el comando anterior para mayor claridad al momento de ejecutarlo en el SQL
                da.Fill(dt); //Obtiene los datos de la tabla
                return dt; //Envia los datos de la tabla
            }
        }
        public string VerDescripcion(int id)
        {
            string descripcion = "";
            using (var connection = GetConnection())
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("Select descripcion from productos where id_producto = @id", connection);
                cmd.Parameters.AddWithValue("@id", id);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    descripcion = reader["descripcion"].ToString();
                }
                connection.Close();
                return descripcion;
            }
        }
    }
}
