using Acceso_a_Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class ModeloPedidoDetalle
    {
        PedidoDetalleDao pedidoDetalleDao = new PedidoDetalleDao();

        public void AgregarDetallePedido(int idVenta, int idProducto, int cantidad)
        {
            pedidoDetalleDao.AgregarDetallePedido(idVenta, idProducto, cantidad);
        }
        public DataTable ActualizarLista(int idVenta)
        {
            DataTable dt = new DataTable();
            dt = pedidoDetalleDao.ActualizarLista(idVenta);
            return dt;
        }
    }
}
