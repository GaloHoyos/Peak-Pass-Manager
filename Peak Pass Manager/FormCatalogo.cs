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
        ModeloCarrito modeloCarrito = new ModeloCarrito(0, 0);
        public FormCatalogo()
        {
            
            InitializeComponent();
            nombreCliente();
            ActualizarLista();
        }

        //metodo para mostrar el nombre del cliente en el label
        public void nombreCliente()
        {
            lblCliente.Text = CacheCliente.Nombre + " " + CacheCliente.Apellido;
            idCliente = CacheCliente.IdCliente;
        }

        //metodo para actualizar la lista de productos
        public void ActualizarLista()
        {
            ModeloProducto modeloProducto = new ModeloProducto();
            dgvProductos.DataSource = modeloProducto.ActualizarLista();
        }

        private void btnCambioCliente_Click(object sender, EventArgs e)
        {
            FormClientes formClientes = new FormClientes();
            formClientes.ShowDialog();
            nombreCliente();
            modeloCarrito.CambiarCliente(idCliente);

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
                    bool existencia = modeloCarrito.ExisteProducto(idProducto);
                    if(existencia == true)
                    {
                        modeloCarrito.AgregarCantidad(idProducto, 1);
                    }
                    else
                    {
                        ModeloCarritoDetalle modeloCarritoDetalle = new ModeloCarritoDetalle(idCliente, idProducto, nombreProducto, precioProducto, cantidad, cantidad * precioProducto);
                        modeloCarrito.AgregarProducto(modeloCarritoDetalle);
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
            FormCarrito formCarrito = new FormCarrito(modeloCarrito);
            formCarrito.ShowDialog();

        }
    }
}
