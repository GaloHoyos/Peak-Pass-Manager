using Acceso_a_Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class ModeloCarrito
    {

        private int idClienteTransaccion;
        private List<ModeloCarritoDetalle> listaCarritoDetalles = new List<ModeloCarritoDetalle>();
        private int total;

        public ModeloCarrito(int idClienteTransaccion, int total)
        {
            this.idClienteTransaccion = idClienteTransaccion;
            this.total = total;
        }
        public void AgregarProducto(ModeloCarritoDetalle producto)
        {
            this.listaCarritoDetalles.Add(producto);
        }
        public void CambiarCliente(int idCliente)
        {
            this.idClienteTransaccion = idCliente;
        }
        public bool ExisteProducto(int idProducto)
        {
            if (listaCarritoDetalles != null)
            {
                foreach (ModeloCarritoDetalle producto in listaCarritoDetalles)
                {
                    if (producto.ObtenerIdProducto() == idProducto)
                    {
                        return true;
                    }
                }
                return false;
            }
            else
            {
                return false;
            }
        }


        public void AgregarCantidad(int idProducto, int cantidad)
        {
            foreach (ModeloCarritoDetalle producto in listaCarritoDetalles)
            {
                if (producto.ObtenerIdProducto() == idProducto)
                {
                    producto.AgregarCantidad(cantidad);
                    
                }
            }
        }
        public void SetCantidad(int idProducto, int cantidad)
        {
            foreach (ModeloCarritoDetalle producto in listaCarritoDetalles)
            {
                if (producto.ObtenerIdProducto() == idProducto)
                {
                    producto.SetCantidad(cantidad);
                }
            }
        }
        public void QuitarCantidad(int idProducto, int cantidad)
        {
            foreach (ModeloCarritoDetalle producto in listaCarritoDetalles)
            {
                if (producto.ObtenerIdProducto() == idProducto)
                {
                    producto.AgregarCantidad(-cantidad);
                }
            }
        }
        public int GetCantidad(int idProducto)
        {
            foreach (ModeloCarritoDetalle producto in listaCarritoDetalles)
            {
                if (producto.ObtenerIdProducto() == idProducto)
                {
                    return producto.ObtenerCantidad();
                }
            }
            return 0;
        }
        public void EliminarProducto(int idProducto)
        {
            foreach (ModeloCarritoDetalle producto in listaCarritoDetalles)
            {
                if (producto.ObtenerIdProducto() == idProducto)
                {
                    listaCarritoDetalles.Remove(producto);
                    break;
                }
            }
        }
        public void ReducirCantidad(int idProducto, int cantidad)
        {
            foreach (ModeloCarritoDetalle producto in listaCarritoDetalles)
            {
                if (producto.ObtenerIdProducto() == idProducto)
                {
                    producto.AgregarCantidad(-cantidad);
                    break;
                }
            }
        }
        public string ObtenerTotal()
        {
            int total = 0;
            foreach (ModeloCarritoDetalle producto in listaCarritoDetalles)
            {
                total += producto.ObtenerSubtotal();
            }
            return total.ToString();
        }
        public DataTable ObtenerLista()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID Cliente");
            dt.Columns.Add("ID");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Precio");
            dt.Columns.Add("Cantidad");
            dt.Columns.Add("Subtotal");
            foreach (ModeloCarritoDetalle producto in listaCarritoDetalles)
            {
                dt.Rows.Add(producto.ObtenerIdCliente(),producto.ObtenerIdProducto(), producto.ObtenerNombreProducto(), producto.ObtenerPrecio(), producto.ObtenerCantidad(), producto.ObtenerSubtotal());
            }
            return dt;
        }
    }
}
