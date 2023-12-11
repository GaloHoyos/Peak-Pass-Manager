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
        public static string Usuario { get; set; }
        public static string Contrasena { get; set; }
        public static string Email { get; set; }
        public static string DNI { get; set; }

        public bool Login(string user, string pass)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from vendedores where usuario=@user and contrasena=@pass";
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            IdUsuario = reader.GetInt32(0);
                            Usuario = reader.GetString(1);
                            Contrasena = reader.GetString(2);
                            Nombre = reader.GetString(3);
                            Apellido = reader.GetString(4);
                            DNI = reader.GetString(5);
                            Email = reader.GetString(6);
                        }
                        return true;
                    }
                    else
                        return false;
                }
            }
        }
    }
}
// ZwBhAGwAbwAxADIA = galo12