using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acceso_a_Datos
{
    public class ModeloPedidoDetalle : ConexionSQL1
    {
        public DataTable ActualizarLista(int idVenta)
        {
            DataTable dt = new DataTable();
            using (var connection = GetConnection())
            {

                SqlDataAdapter da = new SqlDataAdapter("Select usuarios.id_usuario, usuarios.nombre, usuarios.apellido, productos.id_producto, productos.nombre_producto, pedidos_detalles.precio_producto, pedidos_detalles.cantidad FROM pedidos_detalles INNER JOIN productos ON pedidos_detalles.id_producto = productos.id_producto INNER JOIN usuarios ON pedidos_detalles.id_cliente = usuarios.id_usuario WHERE id_venta = '" + idVenta + "'", connection); //Escribimos el comando (Querry) que queremos llevar a cabo en la base de datos
                da.SelectCommand.CommandType = CommandType.Text; //Indica como se interpretará el comando anterior para mayor claridad al momento de ejecutarlo en el SQL
                da.Fill(dt); //Obtiene los datos de la tabla
                return dt; //Envia los datos de la tabla
            }
        }

        public void AgregarDetallePedido(int idVenta, int idProducto, int idCliente, int precio, int cantidad)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    SqlCommand cmd = new SqlCommand("INSERT INTO pedidos_detalles (id_venta, id_producto, id_cliente, precio_producto, cantidad) VALUES ('" + idVenta + "', '" + idProducto + "', '" + idCliente + "', '" + precio + "', '" + cantidad + "')", connection); //Escribimos el comando (Querry) que queremos llevar a cabo en la base de datos
                    cmd.CommandType = CommandType.Text; //Indica como se interpretará el comando anterior para mayor claridad al momento de ejecutarlo en el SQL
                    cmd.ExecuteNonQuery(); //Ejecuta el comando 
                }
            }
        }
        public string GetNombreProducto(int idProducto)
        {
            string nombreProducto = "";
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    SqlCommand cmd = new SqlCommand("SELECT nombre_producto FROM productos WHERE id_producto = '" + idProducto + "'", connection); //Escribimos el comando (Querry) que queremos llevar a cabo en la base de datos
                    cmd.CommandType = CommandType.Text; //Indica como se interpretará el comando anterior para mayor claridad al momento de ejecutarlo en el SQL

                    nombreProducto = Convert.ToString(cmd.ExecuteScalar()); //Ejecuta el comando 
                }
            }
            return nombreProducto;
        }
    }
}
