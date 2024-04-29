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

        ModeloAuditoria modeloAuditoria = new ModeloAuditoria();
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

                SqlDataAdapter da = new SqlDataAdapter("select id_usuario, nombre, apellido, dni, correo, direccion, telefono, usuario ,contrasena, nombre_rol  from usuarios inner join roles on usuarios.id_rol = roles.id_rol where usuarios.activo = 1 ORDER BY 1", connection); //Escribimos el comando (Querry) que queremos llevar a cabo en la base de datos, en este caso para poder tomar los valores de una tabla
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

                SqlDataAdapter da = new SqlDataAdapter("select id_usuario, nombre, apellido, dni, correo, direccion, telefono, nombre_rol from usuarios inner join roles on usuarios.id_rol = roles.id_rol where usuarios.activo = 1 ORDER BY 1", connection); //Escribimos el comando (Querry) que queremos llevar a cabo en la base de datos, en este caso para poder tomar los valores de una tabla
                da.SelectCommand.CommandType = CommandType.Text; //Indica como se interpretará el comando anterior para mayor claridad al momento de ejecutarlo en el SQL
                da.Fill(dt); //Obtiene los datos de la tabla
                return dt; //Envia los datos de la tabla
            }
        }

        //metodo para agregar un usuario
        public void AgregarUsuario(string nombre, string apellido, string dni, string email, string direccion, string telefono, string usuario, string password, int idRol, bool activo)
        {
            int userActivo = 0;
            if (activo)
            {
                userActivo = 1;
            }
            if (idRol == 3)
            {
                //agrega usuario con usuario y password nulo, y rol 3
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand()) 
                    {
                        command.Connection = connection;
                        SqlCommand cmd = new SqlCommand("Insert into usuarios values ('" + nombre + "','" + apellido + "','" + dni + "','" + email + "','" + direccion + "','" + telefono + "',NULL,NULL,3,'" + userActivo + "')", connection);
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
                        SqlCommand cmd = new SqlCommand("Insert into usuarios values ('" + nombre + "','" + apellido + "','" + dni + "','" + email + "','" + direccion + "','" + telefono + "','" + usuario + "','" + password + "','" + idRol + "','" + userActivo + "')", connection);
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            modeloAuditoria.InsertarAuditoria(CacheUsuario.IdUsuario, "Agregar Usuario", "Se ha agregado un usuario: " + nombre + " " + apellido + ". Con ID: " + ObtenerIdPorDNI(dni));
        }
        public bool ModificarUsuario(int idUsuario, string nombre, string apellido, string dni, string email, string direccion, string telefono, string usuario, string password, int idRol, bool userActivo)
        {
            int activo = 0;
            if (userActivo)
            {
                activo = 1;
            }
            if (idRol == 3)
            {
                //modifica usuario con usuario y password nulo, y rol 3
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        SqlCommand cmd = new SqlCommand("UPDATE usuarios SET nombre = '" + nombre + "', apellido = '" + apellido + "', dni = '" + dni + "', correo = '" + email + "', direccion = '" + direccion + "', telefono = '" + telefono + "', activo = '" + activo + "' WHERE id_usuario = '" + idUsuario + "'", connection); //Escribimos el comando (Querry) que queremos llevar a cabo en la base de datos
                        cmd.CommandType = CommandType.Text; //Indica como se interpretará el comando anterior para mayor claridad al momento de ejecutarlo en el SQL
                        cmd.ExecuteNonQuery(); //Ejecuta el comando
                        modeloAuditoria.InsertarAuditoria(CacheUsuario.IdUsuario, "Modificar Usuario", "Se ha modificado un usuario: " + nombre + " " + apellido + ". Con ID: " + idUsuario);
                        return true;
                    }
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(usuario) && !string.IsNullOrEmpty(password))
                {
                    //verifica que el nombre de usuario no exista
                    if (!ExisteUsuario(usuario))
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
                                cmd.ExecuteNonQuery(); //Ejecuta el comando \
                                modeloAuditoria.InsertarAuditoria(CacheUsuario.IdUsuario, "Modificar Usuario", "Se ha modificado un usuario: " + nombre + " " + apellido + ". Con ID: " + idUsuario);
                            }
                        }
                        if (activo == 1)
                        {
                            ActivarUsuario(idUsuario);
                        }
                        return true;
                    }
                    else
                    {
                       return false;
                    }
                }
                else if (string.IsNullOrEmpty(usuario) && !string.IsNullOrEmpty(password))
                {
                    //modifica usuario con usuario nulo y password, y el rol correspondiente
                    using (var connection = GetConnection())
                    {
                        connection.Open();
                        using (var command = new SqlCommand())
                        {
                            command.Connection = connection;
                            SqlCommand cmd = new SqlCommand("UPDATE usuarios SET nombre = '" + nombre + "', apellido = '" + apellido + "', dni = '" + dni + "', correo = '" + email + "', direccion = '" + direccion + "', telefono = '" + telefono + "', contrasena = '" + password + "', id_rol = '" + idRol + "' WHERE id_usuario = '" + idUsuario + "'", connection); //Escribimos el comando (Querry) que queremos llevar a cabo en la base de datos
                            cmd.CommandType = CommandType.Text; //Indica como se interpretará el comando anterior para mayor claridad al momento de ejecutar
                            cmd.ExecuteNonQuery(); //Ejecuta el comando 
                            modeloAuditoria.InsertarAuditoria(CacheUsuario.IdUsuario, "Modificar Usuario", "Se ha modificado un usuario: " + nombre + " " + apellido + ". Con ID: " + idUsuario);
                        }
                        if (activo == 1)
                        {
                            ActivarUsuario(idUsuario);
                        }
                        return true;
                    }
                }
                else if (!string.IsNullOrEmpty(usuario) && string.IsNullOrEmpty(password))
                {
                    //verifica que el nombre de usuario no exista
                    if (!ExisteUsuario(usuario))
                    {
                        //modifica usuario con usuario y password nulo, y el rol correspondiente
                        using (var connection = GetConnection())
                        {
                            connection.Open();
                            using (var command = new SqlCommand())
                            {
                                command.Connection = connection;
                                SqlCommand cmd = new SqlCommand("UPDATE usuarios SET nombre = '" + nombre + "', apellido = '" + apellido + "', dni = '" + dni + "', correo = '" + email + "', direccion = '" + direccion + "', telefono = '" + telefono + "', usuario = '" + usuario + "', id_rol = '" + idRol + "' WHERE id_usuario = '" + idUsuario + "'", connection); //Escribimos el comando (Querry) que queremos llevar a cabo en la base de datos
                                cmd.CommandType = CommandType.Text; //Indica como se interpretará el comando anterior para mayor claridad al momento de ejecutar
                                cmd.ExecuteNonQuery(); //Ejecuta el comando 
                                modeloAuditoria.InsertarAuditoria(CacheUsuario.IdUsuario, "Modificar Usuario", "Se ha modificado un usuario: " + nombre + " " + apellido + ". Con ID: " + idUsuario);
                            }
                        }
                        if (activo == 1)
                        {
                            ActivarUsuario(idUsuario);
                        }
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else if(string.IsNullOrEmpty(usuario) && string.IsNullOrEmpty(password))
                {
                    //modifica usuario con usuario nulo y password nulo, y el rol correspondiente
                    using (var connection = GetConnection())
                    {
                        connection.Open();
                        using (var command = new SqlCommand())
                        {
                            command.Connection = connection;
                            SqlCommand cmd = new SqlCommand("UPDATE usuarios SET nombre = '" + nombre + "', apellido = '" + apellido + "', dni = '" + dni + "', correo = '" + email + "', direccion = '" + direccion + "', telefono = '" + telefono + "', id_rol = '" + idRol + "' WHERE id_usuario = '" + idUsuario + "'", connection); //Escribimos el comando (Querry) que queremos llevar a cabo en la base de datos
                            cmd.CommandType = CommandType.Text; //Indica como se interpretará el comando anterior para mayor claridad al momento de ejecutar
                            cmd.ExecuteNonQuery(); //Ejecuta el comando 
                            modeloAuditoria.InsertarAuditoria(CacheUsuario.IdUsuario, "Modificar Usuario", "Se ha modificado un usuario: " + nombre + " " + apellido + ". Con ID: " + idUsuario);
                        }
                    }
                    if (activo == 1)
                    {
                        ActivarUsuario(idUsuario);
                    }
                    return true;
                }
            }
            return false;
        }
        //Marca el usuario como inactivo
        public void DesactivarUsuario(int idUsuario)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    SqlCommand cmd = new SqlCommand("UPDATE usuarios SET activo = 0 WHERE id_usuario = '" + idUsuario + "'", connection);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    modeloAuditoria.InsertarAuditoria(CacheUsuario.IdUsuario, "Desactivar Usuario", "Se ha desactivado un usuario con ID: " + idUsuario);
                }
            }
        }
        //Marca el usuario como activo
        public void ActivarUsuario(int idUsuario)
        {
            bool rolActivo = false;
            using(var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    SqlCommand cmd = new SqlCommand("SELECT roles.activo from roles inner join usuarios on roles.id_rol = usuarios.id_rol where usuarios.id_usuario = '" + idUsuario + "'", connection);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            if (reader.GetInt32(0) == 1)
                            {
                                rolActivo = true;
                            }
                            else
                            {
                                rolActivo = false;
                            }
                        }
                    }
                }
                connection.Close();
            }
            //Si el rol esta activo, activa el usuario
            if (rolActivo)
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        SqlCommand cmd = new SqlCommand("UPDATE usuarios SET activo = 1 WHERE id_usuario = '" + idUsuario + "'", connection);
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();
                        modeloAuditoria.InsertarAuditoria(CacheUsuario.IdUsuario, "Activar Usuario", "Se ha activado un usuario con ID: " + idUsuario);
                    }
                }
            }
            //Si el rol esta inactivo, activa el usuario con rol de cliente, usuario y password nulos
            else
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        SqlCommand cmd = new SqlCommand("UPDATE usuarios SET activo = 1, id_rol = 3, usuario = NULL, contrasena = NULL WHERE id_usuario = '" + idUsuario + "'", connection);
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();
                        modeloAuditoria.InsertarAuditoria(CacheUsuario.IdUsuario, "Activar Usuario", "Se ha activado un usuario con ID: " + idUsuario);
                    }
                }
            }
        }
        //Obtener DNI del usuario
        public string ObtenerDNI(int idUsuario)
        {
            string dni = "";
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    SqlCommand cmd = new SqlCommand("select dni from usuarios where id_usuario = '" + idUsuario + "'", connection);
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            dni = reader.GetString(0);
                        }
                    }
                    reader.Close();
                }
            }
            return dni;
        }
        //Obtener ID del usuario mediante el DNI
        public int ObtenerIdPorDNI(string dni)
        {
            int id = 0;
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    SqlCommand cmd = new SqlCommand("select id_usuario from usuarios where dni = '" + dni + "'", connection);
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            id = reader.GetInt32(0);
                        }
                    }
                    reader.Close();
                }
            }
            return id;
        }
        // Elimina usuarios pero no puede eliminar usuarios que tengan pedidos asociados
        public bool EliminarUsuario(int usuario)
        {
            bool existenPedidos = false;
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    SqlCommand cmd = new SqlCommand("select * from pedidos where id_cliente = '" + usuario + "'", connection);
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        existenPedidos = true;
                    }
                    reader.Close();
                }
                if (existenPedidos == false)
                {
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        SqlCommand cmd = new SqlCommand("select * from pedidos where id_vendedor = '" + usuario + "'", connection);
                        cmd.CommandType = CommandType.Text;
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            existenPedidos = true;
                        }
                        reader.Close();
                    }

                }
                if (existenPedidos == false)
                {
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        SqlCommand cmd = new SqlCommand("DELETE FROM usuarios WHERE id_usuario = '" + usuario + "'", connection);
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();
                        modeloAuditoria.InsertarAuditoria(CacheUsuario.IdUsuario, "Eliminar Usuario", "Se ha eliminado un usuario con ID: " + usuario);
                    }
                }
            }
            return existenPedidos;
        }
        //Detecta si el usuario ya existe por medio del DNI
        public bool ExisteDNI(string dni)
        {
            bool existe = false;
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    SqlCommand cmd = new SqlCommand("select * from usuarios where dni = '" + dni + "'", connection);
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        existe = true;
                    }
                    reader.Close();
                }
            }
            return existe;
        }
        public bool ExisteUsuario(string usuario)
        {
            bool existe = false;
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    SqlCommand cmd = new SqlCommand("select * from usuarios where usuario = '" + usuario + "'", connection);
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        existe = true;
                    }
                    reader.Close();
                }
            }
            return existe;
        }
        //Detecta si el usuario se encuentra activo
        public bool UsuarioActivo(string dni)
        {
            bool activo = false;
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    SqlCommand cmd = new SqlCommand("select activo from usuarios where dni = '" + dni + "'", connection);
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            if (reader.GetInt32(0) == 1)
                            {
                                activo = true;
                            }
                        }
                    }
                    reader.Close();
                }
            }
            return activo;
        }
        public bool UsuarioActivoPorID(int idUsuario)
        {
            bool activo = false;
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    SqlCommand cmd = new SqlCommand("select activo from usuarios where id_usuario = '" + idUsuario + "'", connection);
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            if (reader.GetInt32(0) == 1)
                            {
                                activo = true;
                            }
                        }
                    }
                    reader.Close();
                }
            }
            return activo;
        }
        //Busca usuario
        public DataTable BuscarUsuarioActivoInactivo(string busqueda, string rol, int activo)
        {
            //Verifica si el string rol esta vacio
            if(rol == "Todos")
            {
                DataTable dt = new DataTable();
                using (var connection = GetConnection())
                {
                    SqlDataAdapter da = new SqlDataAdapter("select id_usuario, nombre, apellido, dni, correo, direccion, telefono, usuario ,contrasena, nombre_rol  from usuarios inner join roles on usuarios.id_rol = roles.id_rol where usuarios.activo = '" + activo + "' and (nombre like '%" + busqueda + "%' or apellido like '%" + busqueda + "%' or dni like '%" + busqueda + "%' or correo like '%" + busqueda + "%' or direccion like '%" + busqueda + "%' or telefono like '%" + busqueda + "%' or usuario like '%" + busqueda + "%' or nombre_rol like '%" + busqueda + "%') ORDER BY 1", connection); //Escribimos el comando (Querry) que queremos llevar a cabo en la base de datos, en este caso para poder tomar los valores de una tabla
                    da.SelectCommand.CommandType = CommandType.Text; //Indica como se interpretará el comando anterior para mayor claridad al momento de ejecutarlo en el SQL
                    da.Fill(dt); //Obtiene los datos de la tabla
                    return dt; //Envia los datos de la tabla
                }
            }
            else if (string.IsNullOrEmpty(busqueda))
            {
                DataTable dt = new DataTable();
                using (var connection = GetConnection())
                {
                    SqlDataAdapter da = new SqlDataAdapter("select id_usuario, nombre, apellido, dni, correo, direccion, telefono, usuario ,contrasena, nombre_rol  from usuarios inner join roles on usuarios.id_rol = roles.id_rol where usuarios.activo = '" + activo + "' and roles.nombre_rol = '" + rol + "' ORDER BY 1", connection); //Escribimos el comando (Querry) que queremos llevar a cabo en la base de datos, en este caso para poder tomar los valores de una tabla
                    da.SelectCommand.CommandType = CommandType.Text; //Indica como se interpretará el comando anterior para mayor claridad al momento de ejecutarlo en el SQL
                    da.Fill(dt); //Obtiene los datos de la tabla
                    return dt; //Envia los datos de la tabla
                }
            }
            else
            {
                DataTable dt = new DataTable();
                using (var connection = GetConnection())
                {
                    SqlDataAdapter da = new SqlDataAdapter(@"SELECT id_usuario, nombre, apellido, dni, correo, direccion, telefono, usuario, contrasena, nombre_rol FROM usuarios INNER JOIN roles ON usuarios.id_rol = roles.id_rol WHERE usuarios.activo = '" + activo + "' AND (nombre LIKE '%" + busqueda + @"%' OR apellido LIKE '%" + busqueda + @"%' OR dni LIKE '%" + busqueda + @"%' OR correo LIKE '%" + busqueda + @"%' OR direccion LIKE '%" + busqueda + @"%' OR telefono LIKE '%" + busqueda + @"%' OR usuario LIKE '%" + busqueda + @"%' OR nombre_rol LIKE '%" + busqueda + @"') AND roles.nombre_rol = '" + rol + @"' ORDER BY 1", connection);

                    da.SelectCommand.CommandType = CommandType.Text; //Indica como se interpretará el comando anterior para mayor claridad al momento de ejecutarlo en el SQL
                    da.Fill(dt); //Obtiene los datos de la tabla
                    return dt; //Envia los datos de la tabla
                }
            }

        }
        //Busca usuario
        public DataTable BuscarUsuario(string busqueda, string rol)
        {
            //Verifica si el string rol esta vacio
            if (rol == "Todos")
            {
                DataTable dt = new DataTable();
                using (var connection = GetConnection())
                {
                    SqlDataAdapter da = new SqlDataAdapter("select id_usuario, nombre, apellido, dni, correo, direccion, telefono, usuario ,contrasena, nombre_rol  from usuarios inner join roles on usuarios.id_rol = roles.id_rol where nombre like '%" + busqueda + "%' or apellido like '%" + busqueda + "%' or dni like '%" + busqueda + "%' or correo like '%" + busqueda + "%' or direccion like '%" + busqueda + "%' or telefono like '%" + busqueda + "%' or usuario like '%" + busqueda + "%' or nombre_rol like '%" + busqueda + "%' ORDER BY 1", connection); //Escribimos el comando (Querry) que queremos llevar a cabo en la base de datos, en este caso para poder tomar los valores de una tabla
                    da.SelectCommand.CommandType = CommandType.Text; //Indica como se interpretará el comando anterior para mayor claridad al momento de ejecutarlo en el SQL
                    da.Fill(dt); //Obtiene los datos de la tabla
                    return dt; //Envia los datos de la tabla
                }
            }
            else if (string.IsNullOrEmpty(busqueda))
            {
                DataTable dt = new DataTable();
                using (var connection = GetConnection())
                {
                    SqlDataAdapter da = new SqlDataAdapter("select id_usuario, nombre, apellido, dni, correo, direccion, telefono, usuario ,contrasena, nombre_rol  from usuarios inner join roles on usuarios.id_rol = roles.id_rol where roles.nombre_rol = '" + rol + "' ORDER BY 1", connection); //Escribimos el comando (Querry) que queremos llevar a cabo en la base de datos, en este caso para poder tomar los valores de una tabla
                    da.SelectCommand.CommandType = CommandType.Text; //Indica como se interpretará el comando anterior para mayor claridad al momento de ejecutarlo en el SQL
                    da.Fill(dt); //Obtiene los datos de la tabla
                    return dt; //Envia los datos de la tabla
                }
            }
            else
            {
                DataTable dt = new DataTable();
                using (var connection = GetConnection())
                {
                    SqlDataAdapter da = new SqlDataAdapter(@"SELECT id_usuario, nombre, apellido, dni, correo, direccion, telefono, usuario, contrasena, nombre_rol FROM usuarios INNER JOIN roles ON usuarios.id_rol = roles.id_rol WHERE nombre LIKE '%" + busqueda + @"%' OR apellido LIKE '%" + busqueda + @"%' OR dni LIKE '%" + busqueda + @"%' OR correo LIKE '%" + busqueda + @"%' OR direccion LIKE '%" + busqueda + @"%' OR telefono LIKE '%" + busqueda + @"%' OR usuario LIKE '%" + busqueda + @"%' OR nombre_rol LIKE '%" + busqueda + @"' AND roles.nombre_rol = '" + rol + @"' ORDER BY 1", connection);

                    da.SelectCommand.CommandType = CommandType.Text; //Indica como se interpretará el comando anterior para mayor claridad al momento de ejecutarlo en el SQL
                    da.Fill(dt); //Obtiene los datos de la tabla
                    return dt; //Envia los datos de la tabla
                }
            }

        }
    }
}
// ZwBhAGwAbwAxADIA = galo12