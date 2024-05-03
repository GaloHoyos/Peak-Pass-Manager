using Acceso_a_Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class ModeloCarritoDetalle
    {
        ModeloUsuario modeloUsuario = new ModeloUsuario();
        private int idCliente;
        public int idProducto;
        private string nombre;
        private int precio;
        private int cantidad;
        private int subtotal;

        public ModeloCarritoDetalle(int idCliente, int idProducto,string nombre, int precio, int cantidad, int subtotal)
        {
            this.idCliente = idCliente;
            this.idProducto = idProducto;
            this.nombre = nombre;
            this.precio = precio;
            this.cantidad = cantidad;
            this.subtotal = subtotal;
        }
        public void AgregarCantidad(int cantidad)
        {
            this.cantidad += cantidad;
            if (this.cantidad <= 0)
            {
                this.subtotal = 0;
            }
            else
            {
                this.subtotal = this.cantidad * this.precio;
            }

        }
        public void CambiarCliente(int idCliente)
        {
            this.idCliente = idCliente;
        }
        public void SetCantidad(int cantidad)
        {
            this.cantidad = cantidad;
            if (this.cantidad <= 0)
            {
                this.subtotal = 0;
            }
            else
            {
                this.subtotal = this.cantidad * this.precio;
            }
        }
        public int ObtenerIdProducto()
        {
            return this.idProducto;
        }
        public int ObtenerCantidad()
        {
            return this.cantidad;
        }
        public int ObtenerSubtotal()
        {
            return this.subtotal;
        }
        public int ObtenerPrecio()
        {
            return this.precio;
        }
        public int ObtenerIdCliente()
        {
            return this.idCliente;
        }
        public string ObtenerNombreProducto()
        {
            return this.nombre;
        }
        public string ObtenerNombreCliente()
        {
            return modeloUsuario.ObtenerNombrePorID(this.idCliente);
        }

    }
}
