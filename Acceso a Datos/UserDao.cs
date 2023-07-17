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
    public class UserDao: ConexionSQL1
    {
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
                            CacheLogin.IdUsuario = reader.GetInt32(0);
                            CacheLogin.Usuario = reader.GetString(1);
                            CacheLogin.Contrasena = reader.GetString(2);
                            CacheLogin.Nombre = reader.GetString(3);
                            CacheLogin.Apellido = reader.GetString(4);
                            CacheLogin.DNI = reader.GetString(5);
                            CacheLogin.Email = reader.GetString(6);
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
