using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Comun.Cache;
using Dominio;
using System.Linq;
using System.Runtime.InteropServices;

namespace Peak_Pass_Manager
{
    public partial class FormCatalogo : Form
    {
        int cantidad = 1;
        int idCliente = -1;
        Form formMenuPrincipal;
        ControladoraCarrito carrito = new ControladoraCarrito(CacheUsuario.IdCliente, 0);
        public FormCatalogo()
        {

            InitializeComponent();
            nombreCliente();
            ActualizarLista();
        }

        //metodo para mostrar el nombre del cliente en el label
        public void nombreCliente()
        {
            lblCliente.Text = CacheUsuario.Nombre + " " + CacheUsuario.Apellido;
            idCliente = CacheUsuario.IdCliente;
        }

        //metodo para actualizar la lista de productos
        public void ActualizarLista()
        {
            ControladoraProducto modeloProducto = new ControladoraProducto();
            dgvProductos.DataSource = modeloProducto.ActualizarLista();
        }

        private void btnCambioCliente_Click(object sender, EventArgs e)
        {
            FormClientes formClientes = new FormClientes();
            formClientes.ShowDialog();
            nombreCliente();
            carrito.CambiarCliente(CacheUsuario.IdCliente);

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (idCliente >= 0)
            {
                if (Convert.ToInt32(dgvProductos.CurrentRow.Cells[0].Value) >= 0)
                {
                    int precioProducto = Convert.ToInt32(dgvProductos.CurrentRow.Cells[2].Value);
                    int idProducto = Convert.ToInt32(dgvProductos.CurrentRow.Cells[0].Value);
                    string nombreProducto = dgvProductos.CurrentRow.Cells[1].Value.ToString();
                    bool existencia = carrito.ExisteProducto(idProducto);
                    if (existencia == true)
                    {
                        carrito.AgregarCantidad(idProducto, 1);
                    }
                    else
                    {
                        ControladoraCarritoDetalle controladoraCarritoDetalle = new ControladoraCarritoDetalle(idCliente, idProducto, nombreProducto, precioProducto, cantidad, cantidad * precioProducto);
                        carrito.AgregarProducto(controladoraCarritoDetalle.ObtenerModelo());
                    }

                }
                else
                {
                    MessageBox.Show("Debe seleccionar un producto");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un cliente");
            }

        }

        private void btnVerCarrito_Click(object sender, EventArgs e)
        {
            FormCarrito formCarrito = new FormCarrito(carrito);
            formCarrito.ShowDialog();
            carrito = formCarrito.modelo;

        }
    }
}
