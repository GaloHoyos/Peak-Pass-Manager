using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acceso_a_Datos;

namespace Dominio
{
    public class ModeloProducto
    {
        //atributos del producto
        private int idProducto;
        private string nombre;
        private int precio;
        private string catalogo;
        ProductoDao productoDao = new ProductoDao();

        public DataTable ActualizarLista()
        {
            DataTable dt = new DataTable();
            dt = productoDao.ActualizarLista();
            return dt;
        }
    }
}
