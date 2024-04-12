using System.Data.SqlClient;

namespace Acceso_a_Datos
{
    public abstract class ConexionSQL1
    {
        private readonly string stringConexion;

        public ConexionSQL1()
        {
			stringConexion = "Data Source=LALEGION;Initial Catalog=PeakPassManager;Integrated Security=True";
		}
        protected SqlConnection GetConnection()
        {
			return new SqlConnection(stringConexion);
		}
    }
}

//ZwBhAGwAbwAxADIA