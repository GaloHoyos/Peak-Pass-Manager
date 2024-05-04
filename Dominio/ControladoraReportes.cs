using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acceso_a_Datos;

namespace Dominio
{
    public class ControladoraReportes
    {
        ModeloReportes reportes = new ModeloReportes();
        public DataTable ProductosMasVendidos()
        {
            return reportes.ProductosMasVendidos();
        }
        public DataTable CategoriasMasVendidas()
        {
            return reportes.CategoriasMasVendidas();
        }
        public DataTable ProductosPorCategoria()
        {
            return reportes.ProductosPorCategoria();
        }
        public DataTable VentasPorMes()
        {
            return reportes.VentasPorMes();
        }
    }
}
