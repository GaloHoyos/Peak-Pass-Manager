using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acceso_a_Datos;

namespace Dominio
{
    public class ControladoraProducto
    {
        Acceso_a_Datos.ModeloProducto productoDao = new Acceso_a_Datos.ModeloProducto();

        public DataTable ActualizarLista()
        {
            DataTable dt = new DataTable();
            dt = productoDao.ActualizarLista();
            return dt;
        }
        public string VerDescripcion(int id)
        {
            string descripcion;
            descripcion = productoDao.VerDescripcion(id);
            return descripcion;
        }
    }
}
