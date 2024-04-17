using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Comun.Cache;


namespace Acceso_a_Datos
{
    public class ModeloUsuario: ConexionSQL1
    {
        public static int IdUsuario { get; set; }
        public static string Nombre { get; set; }
        public static string Apellido { get; set; }
        public static string DNI { get; set; }
        public static string Email { get; set; }
        public static string Direccion { get; set; }
        public static string Telefono { get; set; }
        public static string Usuario { get; set; }
        public static string Password { get; set; }
        public static int IdRol { get; set; }
        public static string Rol { get; set; }

        public string Login(string user, string pass)
        {
            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "SELECT * FROM usuarios WHERE usuario = @user AND contrasena = @pass";
                        command.Parameters.AddWithValue("@user", user);
                        command.Parameters.AddWithValue("@pass", pass);
                        command.CommandType = CommandType.Text;
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                IdUsuario = reader.GetInt32(0);
                                Nombre = reader.GetString(1);
                                Apellido = reader.GetString(2);
                                DNI = reader.GetString(3);
                                Email = reader.GetString(4);
                                Direccion = reader.GetString(5);
                                Telefono = reader.GetString(6);
                                Usuario = reader.GetString(7);
                                Password = reader.GetString(8);
                                IdRol = reader.GetInt32(9);
                            }
                            reader.Close(); // Cierra el primer DataReader antes de abrir el segundo
                            using (var command2 = new SqlCommand())
                            {
                                command2.Connection = connection;
                                command2.CommandText = "select nombre_rol from roles inner join usuarios on roles.id_rol = usuarios.id_rol where usuarios.id_usuario = @idUsuario";
                                command2.Parameters.AddWithValue("@idUsuario", IdUsuario);
                                command2.CommandType = CommandType.Text;
                                SqlDataReader reader2 = command2.ExecuteReader();
                                if (reader2.HasRows)
                                {
                                    while (reader2.Read())
                                    {
                                        Rol = reader2.GetString(0);
                                    }
                                }
                                reader2.Close();
                            }
                            return "true";
                        }
                        else
                        {
                            return "false";
                        }
                    }
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }
        //Crea una datatable y mete los datos de la tabla usuarios en ella
        public DataTable ActualizarLista()
        {
            DataTable dt = new DataTable();
            using (var connection = GetConnection())
            {

                SqlDataAdapter da = new SqlDataAdapter("select id_usuario, nombre, apellido, dni, correo, direccion, telefono, usuario ,contrasena, nombre_rol  from usuarios inner join roles on usuarios.id_rol = roles.id_rol ORDER BY 1", connection); //Escribimos el comando (Querry) que queremos llevar a cabo en la base de datos, en este caso para poder tomar los valores de una tabla
                da.SelectCommand.CommandType = CommandType.Text; //Indica como se interpretará el comando anterior para mayor claridad al momento de ejecutarlo en el SQL
                da.Fill(dt); //Obtiene los datos de la tabla
                return dt; //Envia los datos de la tabla
            }
        }

        public DataTable ActualizarClientes()
        {
            DataTable dt = new DataTable();
            using (var connection = GetConnection())
            {

                SqlDataAdapter da = new SqlDataAdapter("select id_usuario, nombre, apellido, dni, correo, direccion, telefono from usuarios ORDER BY 1", connection); //Escribimos el comando (Querry) que queremos llevar a cabo en la base de datos, en este caso para poder tomar los valores de una tabla
                da.SelectCommand.CommandType = CommandType.Text; //Indica como se interpretará el comando anterior para mayor claridad al momento de ejecutarlo en el SQL
                da.Fill(dt); //Obtiene los datos de la tabla
                return dt; //Envia los datos de la tabla
            }
        }

        //metodo para agregar un usuario
        public void AgregarUsuario(string nombre, string apellido, string dni, string email, string direccion, string telefono, string usuario, string password, int idRol)
        {
            if (idRol == 3)
            {
                //agrega usuario con usuario y password nulo, y rol 3
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand()) 
                    {
                        command.Connection = connection;
                        SqlCommand cmd = new SqlCommand("Insert into usuarios values ('" + nombre + "','" + apellido + "','" + dni + "','" + email + "','" + direccion + "','" + telefono + "',NULL,NULL,3)", connection);
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            else
            {
                //agrega usuario con usuario y password, y el rol correspondiente
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        SqlCommand cmd = new SqlCommand("Insert into usuarios values ('" + nombre + "','" + apellido + "','" + dni + "','" + email + "','" + direccion + "','" + telefono + "','" + usuario + "','" + password + "','" + idRol + "')", connection);
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }
        public void ModificarUsuario(int idUsuario, string nombre, string apellido, string dni, string email, string direccion, string telefono, string usuario, string password, int idRol)
        {
            if (idRol == 3)
            {
                //modifica usuario con usuario y password nulo, y rol 3
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        SqlCommand cmd = new SqlCommand("UPDATE usuarios SET nombre = '" + nombre + "', apellido = '" + apellido + "', dni = '" + dni + "', correo = '" + email + "', direccion = '" + direccion + "', telefono = '" + telefono + "' WHERE id_usuario = '" + idUsuario + "'", connection); //Escribimos el comando (Querry) que queremos llevar a cabo en la base de datos
                        cmd.CommandType = CommandType.Text; //Indica como se interpretará el comando anterior para mayor claridad al momento de ejecutarlo en el SQL
                        cmd.ExecuteNonQuery(); //Ejecuta el comando
                    }
                }
            }
            else
            {
                //modifica usuario con usuario y password, y el rol correspondiente
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        SqlCommand cmd = new SqlCommand("UPDATE usuarios SET nombre = '" + nombre + "', apellido = '" + apellido + "', dni = '" + dni + "', correo = '" + email + "', direccion = '" + direccion + "', telefono = '" + telefono + "', usuario = '" + usuario + "', contrasena = '" + password + "', id_rol = '" + idRol + "' WHERE id_usuario = '" + idUsuario + "'", connection); //Escribimos el comando (Querry) que queremos llevar a cabo en la base de datos
                        cmd.CommandType = CommandType.Text; //Indica como se interpretará el comando anterior para mayor claridad al momento de ejecutar
                        cmd.ExecuteNonQuery(); //Ejecuta el comando 
                    }
                }
            }
        }
        public void EliminarUsuario(int idUsuario)
        {
            //elimina el usuario
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM usuarios WHERE id_usuario = '" + idUsuario + "'", connection); //Escribimos el comando (Querry) que queremos llevar a cabo en la base de datos
                    cmd.CommandType = CommandType.Text; //Indica como se interpretará el comando anterior para mayor claridad al momento de ejecutarlo en el SQL
                    cmd.ExecuteNonQuery(); //Ejecuta el comando 

                }
            }
        }
    }
}
// ZwBhAGwAbwAxADIA = galo12