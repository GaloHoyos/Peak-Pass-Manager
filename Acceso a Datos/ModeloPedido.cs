using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Acceso_a_Datos
{
    public class ModeloPedido : ConexionSQL1
    {

        public DataTable ActualizarLista()
        {
            DataTable dt = new DataTable();
            using (var connection = GetConnection())
            {

                SqlDataAdapter da = new SqlDataAdapter("Select * from pedidos ORDER BY 1", connection); //Escribimos el comando (Querry) que queremos llevar a cabo en la base de datos, en este caso para poder tomar los valores de una tabla
                da.SelectCommand.CommandType = CommandType.Text; //Indica como se interpretará el comando anterior para mayor claridad al momento de ejecutarlo en el SQL
                da.Fill(dt); //Obtiene los datos de la tabla
                return dt; //Envia los datos de la tabla
            }
        }
        public void AgregarPedido(int idVendedor, int idCliente, int Total)
        {
            //metodo para agregar un pedido
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    SqlCommand cmd = new SqlCommand("Insert into pedidos values ('" + idVendedor + "','" + idCliente + "','" + Total + "')", connection); //Escribimos el comando (Querry) que queremos llevar a cabo en la base de datos
                    cmd.CommandType = CommandType.Text; //Indica como se interpretará el comando anterior para mayor claridad al momento de ejecutarlo en el SQL

                    cmd.ExecuteNonQuery(); //Ejecuta el comando 
                }
            }
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
    }
}
