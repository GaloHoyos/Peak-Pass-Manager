using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acceso_a_Datos
{
    public class ModeloCliente : ConexionSQL1
    {
        //metodo para obtener todos los clientes
        public DataTable ActualizarLista() 
        {
            DataTable dt = new DataTable();
            using (var connection = GetConnection()) 
            {

                SqlDataAdapter da = new SqlDataAdapter("Select * from clientes ORDER BY 1", connection); //Escribimos el comando (Querry) que queremos llevar a cabo en la base de datos, en este caso para poder tomar los valores de una tabla
                da.SelectCommand.CommandType = CommandType.Text; //Indica como se interpretará el comando anterior para mayor claridad al momento de ejecutarlo en el SQL
                da.Fill(dt); //Obtiene los datos de la tabla
                return dt; //Envia los datos de la tabla
            }
        }
        public void AgregarCliente(string Nombre, string Apellido, string DNI, string Correo, string Direccion, string Telefono)
        {
            //metodo para agregar un cliente
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    SqlCommand cmd = new SqlCommand("Insert into clientes(nombre,apellido,dni,correo,direccion,telefono) values ('" + Nombre + "','" + Apellido + "','" + DNI + "','" + Correo + "','" + Direccion + "','" + Telefono + "')", connection); //Escribimos el comando (Querry) que queremos llevar a cabo en la base de datos
                    cmd.CommandType = CommandType.Text; //Indica como se interpretará el comando anterior para mayor claridad al momento de ejecutarlo en el SQL

                    cmd.ExecuteNonQuery(); //Ejecuta el comando 
                    ActualizarLista(); //Actualiza la lista de clientes
                }
            }
        }
        public void ModificarClienteSeleccionado(int ID, string Nombre, string Apellido, string DNI, string Correo, string Direccion, string Telefono)
        {
            //metodo para modificar un cliente
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    SqlCommand cmd = new SqlCommand("UPDATE clientes SET nombre = '" + Nombre + "', apellido = '" + Apellido + "', dni = '" + DNI + "', correo = '" + Correo + "', direccion = '" + Direccion + "', telefono = '" + Telefono + "' WHERE id_cliente = '" + ID + "'", connection); //Escribimos el comando (Querry) que queremos llevar a cabo en la base de datos
                    cmd.CommandType = CommandType.Text; //Indica como se interpretará el comando anterior para mayor claridad al momento de ejecutarlo en el SQL

                    cmd.ExecuteNonQuery(); //Ejecuta el comando 
                    ActualizarLista(); //Actualiza la lista de clientes
                }
            }
        }
        public void EliminarCliente(int ID)
        {
            //metodo para eliminar un cliente
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    SqlCommand cmd = new SqlCommand("DELETE FROM clientes WHERE id_cliente = '" + ID + "'", connection); //Escribimos el comando (Querry) que queremos llevar a cabo en la base de datos
                    cmd.CommandType = CommandType.Text; //Indica como se interpretará el comando anterior para mayor claridad al momento de ejecutarlo en el SQL

                    cmd.ExecuteNonQuery(); //Ejecuta el comando 
                    ActualizarLista(); //Actualiza la lista de clientes
                }
            }
        }

    }
}
