using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Acceso_a_Datos
{
    public class ModeloPedido : ConexionSQL1
    {
        ModeloAuditoria auditoria = new ModeloAuditoria();
        public DataTable ActualizarLista()
        {
            DataTable dt = new DataTable();
            using (var connection = GetConnection())
            {

                SqlDataAdapter da = new SqlDataAdapter("SELECT p.id_venta, p.id_vendedor, u_vendedor.nombre AS nombre_vendedor, p.id_cliente, u_cliente.nombre AS nombre_cliente, u_cliente.apellido AS apellido_cliente, p.costo_total, p.fecha FROM pedidos AS p JOIN usuarios AS u_vendedor ON p.id_vendedor = u_vendedor.id_usuario JOIN usuarios AS u_cliente ON p.id_cliente = u_cliente.id_usuario;", connection); //Escribimos el comando (Querry) que queremos llevar a cabo en la base de datos
                da.SelectCommand.CommandType = CommandType.Text; //Indica como se interpretará el comando anterior para mayor claridad al momento de ejecutarlo en el SQL
                da.Fill(dt); //Obtiene los datos de la tabla
                return dt; //Envia los datos de la tabla
            }
        }
        public void AgregarPedido(int idVendedor, int idCliente, int total)
        {
            //metodo para agregar un pedido
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    SqlCommand cmd = new SqlCommand("Insert into pedidos values ('" + idVendedor + "','" + idCliente + "','" + total + "', GETDATE())", connection); //Escribimos el comando (Querry) que queremos llevar a cabo en la base de datos
                    cmd.CommandType = CommandType.Text; //Indica como se interpretará el comando anterior para mayor claridad al momento de ejecutarlo en el SQL

                    cmd.ExecuteNonQuery();
                }
            }
            auditoria.InsertarAuditoria(idVendedor, "Agregar Pedido", "Se ha agregado un pedido con un total de " + total + " al cliente con id " + idCliente);
        }
        public int GetIdVenta()
        {
            int idVenta = 0;
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    SqlCommand cmd = new SqlCommand("SELECT TOP 1 id_venta FROM pedidos ORDER BY id_venta DESC", connection); //Escribimos el comando (Querry) que queremos llevar a cabo en la base de datos
                    cmd.CommandType = CommandType.Text; //Indica como se interpretará el comando anterior para mayor claridad al momento de ejecutarlo en el SQL

                    idVenta = Convert.ToInt32(cmd.ExecuteScalar()); //Ejecuta el comando 
                }
            }
            return idVenta;
        }
        public string GetNombreCliente(int idCliente)
        {
            string nombreCliente = "";
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    SqlCommand cmd = new SqlCommand("SELECT nombre FROM usuarios WHERE id_usuario = '" + idCliente + "'", connection); //Escribimos el comando (Querry) que queremos llevar a cabo en la base de datos
                    cmd.CommandType = CommandType.Text; //Indica como se interpretará el comando anterior para mayor claridad al momento de ejecutarlo en el SQL

                    nombreCliente = Convert.ToString(cmd.ExecuteScalar()); //Ejecuta el comando 
                }
            }
            return nombreCliente;
        }
        public string GetNombreVendedor(int idVendedor)
        {
            string nombreVendedor = "";
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    SqlCommand cmd = new SqlCommand("SELECT nombre FROM usuarios WHERE id_usuario = '" + idVendedor + "'", connection); //Escribimos el comando (Querry) que queremos llevar a cabo en la base de datos
                    cmd.CommandType = CommandType.Text; //Indica como se interpretará el comando anterior para mayor claridad al momento de ejecutarlo en el SQL

                    nombreVendedor = Convert.ToString(cmd.ExecuteScalar()); //Ejecuta el comando 
                }
            }
            return nombreVendedor;
        }

        public DataTable BuscarPedidos(string searchString)
        {
            DataTable dt = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    DateTime parsedDate;
                    string dateFilter = string.Empty;
                    if (DateTime.TryParseExact(searchString, new[] { "dd/MM/yyyy", "MM/dd/yyyy" }, CultureInfo.InvariantCulture, DateTimeStyles.None, out parsedDate))
                    {
                        dateFilter = " OR CONVERT(VARCHAR, p.fecha, 103) = @searchDate ";
                    }

                    SqlCommand cmd = new SqlCommand(
                        $@"SELECT DISTINCT p.id_venta, p.id_vendedor, u_vendedor.nombre AS nombre_vendedor, 
                                 p.id_cliente, u_cliente.nombre AS nombre_cliente, 
                                 u_cliente.apellido AS apellido_cliente, p.costo_total, p.fecha 
                          FROM pedidos AS p
                          JOIN usuarios AS u_vendedor ON p.id_vendedor = u_vendedor.id_usuario
                          JOIN usuarios AS u_cliente ON p.id_cliente = u_cliente.id_usuario
                          LEFT JOIN pedidos_detalles AS pd ON p.id_venta = pd.id_venta
                          LEFT JOIN productos AS pr ON pd.id_producto = pr.id_producto
                          LEFT JOIN usuarios AS u_detalle_cliente ON pd.id_cliente = u_detalle_cliente.id_usuario
                          WHERE u_vendedor.nombre LIKE @search 
                             OR u_cliente.nombre LIKE @search 
                             OR u_cliente.apellido LIKE @search 
                             OR pr.nombre_producto LIKE @search 
                             OR u_detalle_cliente.nombre LIKE @search 
                             OR u_detalle_cliente.apellido LIKE @search 
                             {dateFilter}", connection);

                    cmd.Parameters.AddWithValue("@search", "%" + searchString + "%");
                    if (!string.IsNullOrEmpty(dateFilter))
                    {
                        cmd.Parameters.AddWithValue("@searchDate", parsedDate.ToString("dd/MM/yyyy"));
                    }
                    cmd.CommandType = CommandType.Text;

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            return dt;
        }


    }
}
