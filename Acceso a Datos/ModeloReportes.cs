using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Acceso_a_Datos
{
    public class ModeloReportes : ConexionSQL1
    {
        public ModeloReportes()
        {

        }
        public DataTable ProductosMasVendidos()
        {
            DataTable dt = new DataTable();
            using (var connection = GetConnection())
            {
                SqlCommand cmd = new SqlCommand("ProdPreferidos1", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
        }
        public DataTable CategoriasMasVendidas()
        {
            DataTable dt = new DataTable();
            using (var connection = GetConnection())
            {
                SqlCommand cmd = new SqlCommand("CategoriaMasVentas", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
        }
        public DataTable ProductosPorCategoria()
        {
            DataTable dt = new DataTable();
            using (var connection = GetConnection())
            {
                SqlCommand cmd = new SqlCommand("ProdPorCategoria1", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
        }
        public DataTable VentasPorMes()
        {
            DataTable dt = new DataTable();
            using (var connection = GetConnection())
            {
                SqlCommand cmd = new SqlCommand("VentasPorMes2", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
        }
    }
}
