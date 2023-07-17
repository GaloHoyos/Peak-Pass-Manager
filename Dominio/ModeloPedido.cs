using Acceso_a_Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class ModeloPedido
    {
        PedidoDao pedidoDao = new PedidoDao();
        
        public DataTable ActualizarLista()
        {
            DataTable dt = new DataTable();
            dt = pedidoDao.ActualizarLista();
            return dt;
        }
        public void AgregarPedido(int idVendedor, int idCliente, int total)
        {
            pedidoDao.AgregarPedido(idVendedor, idCliente, total);
        }
        public int GetIdVenta()
        {
            return pedidoDao.GetIdVenta();
        }
    }
}
