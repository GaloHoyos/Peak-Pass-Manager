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

        public bool Login(string user, string pass)
        {
            using (var connection = GetConnection())
            {
                // Se abre la conexión
                connection.Open();

                // Se crea una consulta SQL para buscar el usuario y la contraseña en la tabla roles
                string query = "SELECT * FROM roles WHERE usuario = @usuario AND contrasena = @contrasena";

                // Se crea una instancia de SqlCommand con la consulta y la conexión
                using (SqlCommand comando = new SqlCommand(query, connection))
                {
                    // Se asignan los parámetros con los valores ingresados por el usuario
                    comando.Parameters.AddWithValue("@usuario", user);
                    comando.Parameters.AddWithValue("@contrasena", pass);

                    // Se ejecuta la consulta y se obtiene un SqlDataReader
                    using (SqlDataReader lector = comando.ExecuteReader())
                    {
                        // Se verifica si hay algún resultado
                        if (lector.HasRows)
                        {
                            // Se lee el primer resultado
                            lector.Read();

                            // Se obtiene el id_usuario del resultado
                            int id_usuario = lector.GetInt32(0);

                            // Se cierra el lector
                            lector.Close();

                            // Se crea una segunda consulta SQL para buscar los datos del usuario en la tabla usuarios
                            string query2 = "SELECT * FROM usuarios WHERE id_usuario = @id_usuario";

                            // Se crea una segunda instancia de SqlCommand con la segunda consulta y la conexión
                            using (SqlCommand comando2 = new SqlCommand(query2, connection))
                            {
                                // Se asigna el parámetro con el id_usuario obtenido
                                comando2.Parameters.AddWithValue("@id_usuario", id_usuario);

                                // Se ejecuta la segunda consulta y se obtiene un segundo SqlDataReader
                                using (SqlDataReader lector2 = comando2.ExecuteReader())
                                {
                                    // Se verifica si hay algún resultado
                                    if (lector2.HasRows)
                                    {
                                        // Se lee el primer resultado
                                        lector2.Read();

                                        // Se asignan los valores de las variables get set con los datos del resultado
                                        IdUsuario = lector2.GetInt32(0);
                                        Nombre = lector2.GetString(1);
                                        Apellido = lector2.GetString(2);
                                        DNI = lector2.GetString(3);
                                        Email = lector2.GetString(4);
                                        Direccion = lector2.GetString(5);
                                        Telefono = lector2.GetString(6);
                                        Usuario = user;
                                        Password = pass;


                                        // Se cierra el lector2
                                        lector2.Close();
                                        SqlCommand cmd = new SqlCommand("SELECT rol FROM roles WHERE id_usuario = '" + id_usuario + "'", connection); //Escribimos el comando (Querry) que queremos llevar a cabo en la base de datos
                                        cmd.CommandType = CommandType.Text; //Indica como se interpretará el comando anterior para mayor claridad al momento de ejecutarlo en el SQL
                                        cmd.ExecuteNonQuery();
                                        IdRol = Convert.ToInt32(cmd.ExecuteScalar());

                                        // Se retorna true para indicar que el login fue exitoso
                                        return true;
                                    }
                                    else
                                    {
                                        // Se retorna false para indicar que no se encontraron los datos del usuario
                                        return false;
                                    }
                                }
                            }
                        }
                        else
                        {
                            // Se retorna false para indicar que el usuario o la contraseña son incorrectos
                            return false;
                        }
                    }
                }


            }
        }
        //Crea una datatable y mete los datos de la tabla usuarios en ella
        public DataTable ActualizarLista()
        {
            DataTable dt = new DataTable();
            using (var connection = GetConnection())
            {

                SqlDataAdapter da = new SqlDataAdapter("Select * from usuarios ORDER BY 1", connection); //Escribimos el comando (Querry) que queremos llevar a cabo en la base de datos, en este caso para poder tomar los valores de una tabla
                da.SelectCommand.CommandType = CommandType.Text; //Indica como se interpretará el comando anterior para mayor claridad al momento de ejecutarlo en el SQL
                da.Fill(dt); //Obtiene los datos de la tabla
                return dt; //Envia los datos de la tabla
            }
        }
        //Crea una datatable y mete los datos de la tabla usuarios y roles en ella
        public DataTable ActualizarListaRoles()
        {
            DataTable dt = new DataTable();
            using (var connection = GetConnection())
            {

                SqlDataAdapter da = new SqlDataAdapter("SELECT usuarios.*, \r\n   CASE \r\n      WHEN roles.rol = 0 THEN 'cliente'\r\n      WHEN roles.rol = 1 THEN 'administrador'\r\n      WHEN roles.rol = 2 THEN 'vendedor'\r\n      ELSE 'sin rol'\r\n   END AS nombre_rol\r\nFROM usuarios \r\nLEFT JOIN roles ON usuarios.id_usuario = roles.id_usuario \r\nORDER BY usuarios.id_usuario;\r\n", connection); //Escribimos el comando (Querry) que queremos llevar a cabo en la base de datos, en este caso para poder tomar los valores de una tabla
                da.SelectCommand.CommandType = CommandType.Text; //Indica como se interpretará el comando anterior para mayor claridad al momento de ejecutarlo en el SQL
                da.Fill(dt); //Obtiene los datos de la tabla
                return dt; //Envia los datos de la tabla
            }
        }
        //metodo para agregar un usuario
        public void AgregarUsuario(string nombre, string apellido, string dni, string email, string direccion, string telefono, string usuario, string password, int idRol)
        {
            if (idRol == 0)
            {
                //agrega usuario con usuario y password nulo, y rol 0
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        SqlCommand cmd = new SqlCommand("Insert into usuarios values ('" + nombre + "','" + apellido + "','" + dni + "','" + email + "','" + direccion + "','" + telefono + "')", connection); //Escribimos el comando (Querry) que queremos llevar a cabo en la base de datos
                        cmd.CommandType = CommandType.Text; //Indica como se interpretará el comando anterior para mayor claridad al momento de ejecutarlo en el SQL

                        cmd.ExecuteNonQuery(); //Ejecuta el comando 
                        //Devuelve el id del usuario que se acaba de agregar
                        SqlCommand cmd2 = new SqlCommand("SELECT TOP 1 id_usuario FROM usuarios ORDER BY id_usuario DESC", connection); //Escribimos el comando (Querry) que queremos llevar a cabo en la base de datos
                        cmd2.CommandType = CommandType.Text; //Indica como se interpretará el comando anterior para mayor claridad al momento de ejecutarlo en el SQL
                        cmd2.ExecuteNonQuery();
                        IdUsuario = Convert.ToInt32(cmd2.ExecuteScalar());
                        //agrega el rol 0 al usuario
                        SqlCommand cmd3 = new SqlCommand("Insert into roles values ('" + IdUsuario + "','" +  idRol + "', NULL, NULL)", connection); //Escribimos el comando (Querry) que queremos llevar a cabo en la base de datos
                        cmd3.CommandType = CommandType.Text; //Indica como se interpretará el comando anterior para mayor claridad al momento de ejecutarlo en el SQL
                        cmd3.ExecuteNonQuery();
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
                        SqlCommand cmd = new SqlCommand("Insert into usuarios values ('" + nombre + "','" + apellido + "','" + dni + "','" + email + "','" + direccion + "','" + telefono + "')", connection); //Escribimos el comando (Querry) que queremos llevar a cabo en la base de datos
                        cmd.CommandType = CommandType.Text; //Indica como se interpretará el comando anterior para mayor claridad al momento de ejecutarlo en el SQL

                        cmd.ExecuteNonQuery(); //Ejecuta el comando 
                        //Devuelve el id del usuario que se acaba de agregar
                        SqlCommand cmd2 = new SqlCommand("SELECT TOP 1 id_usuario FROM usuarios ORDER BY id_usuario DESC", connection); //Escribimos el comando (Querry) que queremos llevar a cabo en la base de datos
                        cmd2.CommandType = CommandType.Text; //Indica como se interpretará el comando anterior para mayor claridad al momento de ejecutarlo en el SQL
                        cmd2.ExecuteNonQuery();
                        IdUsuario = Convert.ToInt32(cmd2.ExecuteScalar());
                        //agrega el rol correspondiente al usuario junto con el usuario y la contraseña
                        SqlCommand cmd3 = new SqlCommand("Insert into roles values ('" + IdUsuario + "','" + idRol + "','" + usuario + "','" + password + "')", connection); //Escribimos el comando (Querry) que queremos llevar a cabo en la base de datos
                        cmd3.CommandType = CommandType.Text; //Indica como se interpretará el comando anterior para mayor claridad al momento de ejecutarlo en el SQL
                        cmd3.ExecuteNonQuery();
                    }
                }
            }
        }
        public void ModificarUsuario(int idUsuario, string nombre, string apellido, string dni, string email, string direccion, string telefono, string usuario, string password, int idRol)
        {
            if (idRol == 0)
            {
                //modifica usuario con usuario y password nulo, y rol 0
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        SqlCommand cmd = new SqlCommand("UPDATE usuarios SET nombre = '" + nombre + "', apellido = '" + apellido + "', dni = '" + dni + "', email = '" + email + "', direccion = '" + direccion + "', telefono = '" + telefono + "' WHERE id_usuario = '" + idUsuario + "'", connection); //Escribimos el comando (Querry) que queremos llevar a cabo en la base de datos
                        cmd.CommandType = CommandType.Text; //Indica como se interpretará el comando anterior para mayor claridad al momento de ejecutarlo en el SQL
                        cmd.ExecuteNonQuery(); //Ejecuta el comando 
                        //modifica el rol 0 al usuario
                        SqlCommand cmd3 = new SqlCommand("UPDATE roles SET rol = '" + idRol + "', usuario = null, contrasena = null WHERE id_usuario = '" + idUsuario + "'", connection); //Escribimos el comando (Querry) que queremos llevar a cabo en la base de datos
                        cmd3.CommandType = CommandType.Text; //Indica como se interpretará el comando anterior para mayor claridad al momento de ejecutarlo en el SQL
                        cmd3.ExecuteNonQuery();
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
                        SqlCommand cmd = new SqlCommand("UPDATE usuarios SET nombre = '" + nombre + "', apellido = '" + apellido + "', dni = '" + dni + "', email = '" + email + "', direccion = '" + direccion + "', telefono = '" + telefono + "' WHERE id_usuario = '" + idUsuario + "'", connection); //Escribimos el comando (Querry) que queremos llevar a cabo en la base de datos
                        cmd.CommandType = CommandType.Text; //Indica como se interpretará el comando anterior para mayor claridad al momento de ejecutar
                        cmd.ExecuteNonQuery(); //Ejecuta el comando 
                        //modifica el rol correspondiente al usuario junto con el usuario y la contraseña
                        SqlCommand cmd3 = new SqlCommand("UPDATE roles SET rol = '" + idRol + "', usuario = '" + usuario + "', contrasena = '" + password + "' WHERE id_usuario = '" + idUsuario + "'", connection); //Escribimos el comando (Querry) que queremos llevar a cabo en la base de datos
                        cmd3.CommandType = CommandType.Text; //Indica como se interpretará el comando anterior para mayor claridad al momento de ejecutarlo en el SQL
                        cmd3.ExecuteNonQuery();
                    }
                }
            }
        }
        public void EliminarUsuario(int idUsuario)
        {
            //elimina el usuario y el rol correspondiente
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    SqlCommand cmd2 = new SqlCommand("DELETE FROM roles WHERE id_usuario = '" + idUsuario + "'", connection); //Escribimos el comando (Querry) que queremos llevar a cabo en la base de datos
                    cmd2.CommandType = CommandType.Text; //Indica como se interpretará el comando anterior para mayor claridad al momento de ejecutarlo en el SQL
                    cmd2.ExecuteNonQuery();
                    SqlCommand cmd = new SqlCommand("DELETE FROM usuarios WHERE id_usuario = '" + idUsuario + "'", connection); //Escribimos el comando (Querry) que queremos llevar a cabo en la base de datos
                    cmd.CommandType = CommandType.Text; //Indica como se interpretará el comando anterior para mayor claridad al momento de ejecutarlo en el SQL
                    cmd.ExecuteNonQuery(); //Ejecuta el comando 

                }
            }
        }

    }
}
// ZwBhAGwAbwAxADIA = galo12