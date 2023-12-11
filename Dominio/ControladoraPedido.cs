using Acceso_a_Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class ControladoraPedido
    {
        Acceso_a_Datos.ModeloPedido pedidoDao = new Acceso_a_Datos.ModeloPedido();
        // actualiza la lista de pedidos con nombre de cliente y vendedor
        /*
        public DataTable ActualizarLista()
        {
            DataTable dt = new DataTable();
            dt = pedidoDao.ActualizarLista();
            dt.Columns.Add("Cliente", typeof(string));
            dt.Columns.Add("Vendedor", typeof(string));
            foreach (DataRow row in dt.Rows)
            {
                int idCliente = Convert.ToInt32(row["id_cliente"]);
                int idVendedor = Convert.ToInt32(row["id_vendedor"]);
                row["Cliente"] = pedidoDao.GetNombreCliente(idCliente);
                row["Vendedor"] = pedidoDao.GetNombreVendedor(idVendedor);
            }
            return dt;
        }*/

        // Crea la tabla de pedidos añadiendo nombre de cliente y vendedor
        public DataTable ActualizarLista()
        {
            DataTable dt = new DataTable();
            dt = pedidoDao.ActualizarLista();
            dt.Columns.Add("Cliente", typeof(string));
            dt.Columns.Add("Vendedor", typeof(string));
            foreach (DataRow row in dt.Rows)
            {
                int idCliente = Convert.ToInt32(row["id_cliente"]);
                int idVendedor = Convert.ToInt32(row["id_vendedor"]);
                row["Cliente"] = pedidoDao.GetNombreCliente(idCliente);
                row["Vendedor"] = pedidoDao.GetNombreVendedor(idVendedor);
            }
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
