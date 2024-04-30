using Acceso_a_Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class ControladoraCarrito
    {
        int idClienteTransaccion;
        ModeloCarrito modeloCarrito;
        int total;
        public ControladoraCarrito(int idClienteTransaccion, int total)
        {
            modeloCarrito = new ModeloCarrito(idClienteTransaccion, total);
            this.total = total;
            this.idClienteTransaccion = idClienteTransaccion;
        }
        public void CambiarCliente(int idCliente)
        {
            modeloCarrito.CambiarCliente(idCliente);
        }
        public void AgregarProducto(ModeloCarritoDetalle producto, int idCliente)
        {
            //Verifica si el producto ya existe en el carrito para ese id de cliente
            if (modeloCarrito.ExisteProducto(producto.ObtenerIdProducto(), idCliente))
            {
                modeloCarrito.AgregarCantidad(producto.ObtenerIdProducto(), producto.ObtenerCantidad());
            }
            else
            {
                modeloCarrito.AgregarProducto(producto);
            }
        }
        public void AgregarCantidad(int idProducto, int cantidad)
        {
            modeloCarrito.AgregarCantidad(idProducto, cantidad);
        }
        public void SetCantidad(int idProducto, int cantidad)
        {
            modeloCarrito.SetCantidad(idProducto, cantidad);
        }
        public void EliminarProducto(int idProducto)
        {
            modeloCarrito.EliminarProducto(idProducto);
        }
        public bool ExisteProducto(int idProducto, int idCliente)
        {
            return modeloCarrito.ExisteProducto(idProducto, idCliente);
        }
        public DataTable ObtenerLista()
        {
            return modeloCarrito.ObtenerLista();
        }
        public string ObtenerTotal()
        {
            return modeloCarrito.ObtenerTotal();
        }
        public void QuitarCantidad(int idProducto, int cantidad)
        {
            modeloCarrito.QuitarCantidad(idProducto, cantidad);
        }
        public int GetCantidad(int idProducto)
        {
            return modeloCarrito.GetCantidad(idProducto);
        }
        public void ReducirCantidad(int idProducto, int cantidad)
        {
            modeloCarrito.ReducirCantidad(idProducto, cantidad);
        }
    }
}
