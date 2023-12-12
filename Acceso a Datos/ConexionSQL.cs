using System.Data.SqlClient;

namespace Acceso_a_Datos
{
    public abstract class ConexionSQL1
    {
        private readonly string stringConexion;

        public ConexionSQL1()
        {
			stringConexion = "Data Source=DESKTOP-AM7P5VD;Initial Catalog=PeakPassManager;Integrated Security=True;Pooling=False";
		}
        protected SqlConnection GetConnection()
        {
			return new SqlConnection(stringConexion);
		}
    }
}