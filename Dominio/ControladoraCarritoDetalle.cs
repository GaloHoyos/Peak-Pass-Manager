using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acceso_a_Datos;

namespace Dominio
{
    public class ControladoraCarritoDetalle
    {
        ModeloCarritoDetalle modeloCarritoDetalle;
        public ControladoraCarritoDetalle(int idCliente, int idProducto, string nombre, int precio, int cantidad, int subtotal)
        {
            modeloCarritoDetalle = new ModeloCarritoDetalle(idCliente, idProducto, nombre, precio, cantidad, subtotal);
        }
        public void AgregarCantidad(int cantidad)
        {
            modeloCarritoDetalle.AgregarCantidad(cantidad);
        }
        public void SetCantidad(int cantidad)
        {
            modeloCarritoDetalle.SetCantidad(cantidad);
        }
        public int ObtenerIdProducto()
        {
            return modeloCarritoDetalle.ObtenerIdProducto();
        }
        public int ObtenerCantidad()
        {
            return modeloCarritoDetalle.ObtenerCantidad();
        }
        public int ObtenerSubtotal()
        {
            return modeloCarritoDetalle.ObtenerSubtotal();
        }
        public int ObtenerPrecio()
        {
            return modeloCarritoDetalle.ObtenerPrecio();
        }
        public string ObtenerNombreProducto()
        {
            return modeloCarritoDetalle.ObtenerNombreProducto();
        }
        public int ObtenerIdCliente()
        {
            return modeloCarritoDetalle.ObtenerIdCliente();
        }
        public ModeloCarritoDetalle ObtenerModelo()
        {
            return modeloCarritoDetalle;
        }
    }
}
