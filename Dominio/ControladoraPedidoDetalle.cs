using Acceso_a_Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class ControladoraPedidoDetalle
    {
        Acceso_a_Datos.ModeloPedidoDetalle pedidoDetalleDao = new Acceso_a_Datos.ModeloPedidoDetalle();

        public void AgregarDetallePedido(int idVenta, int idProducto, int idCliente, int precio, int cantidad)
        {
            pedidoDetalleDao.AgregarDetallePedido(idVenta, idProducto, idCliente, precio, cantidad);
        }
        public DataTable ActualizarLista(int idVenta)
        {
            DataTable dt = new DataTable();
            dt = pedidoDetalleDao.ActualizarLista(idVenta);
            return dt;
        }
    }
}
