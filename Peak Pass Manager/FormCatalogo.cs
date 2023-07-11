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


namespace Peak_Pass_Manager
{
    public partial class FormCatalogo : Form
    {
        public FormCatalogo()
        {
            InitializeComponent();
            nombreCliente();
            ActualizarLista();
        }

        public void nombreCliente()
        {
            lblCliente.Text = CacheCliente.Nombre + " " + CacheCliente.Apellido;
        }

        public void ActualizarLista()
        {
            ModeloProducto modeloProducto = new ModeloProducto();
            dgvProductos.DataSource = modeloProducto.ActualizarLista();
        }

        private void btnCambioCliente_Click(object sender, EventArgs e)
        {
            //Cambiar form al FormClientes
            FormClientes formClientes = new FormClientes();
            formClientes.Show();
            this.Hide();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(CacheCliente.IdCliente >= 0)
            {
                CacheCarrito.IdCliente = CacheCliente.IdCliente;
                CacheCarrito.IdProducto = Convert.ToInt32(dgvProductos.CurrentRow.Cells[0].Value.ToString());
                CacheCarrito.Cantidad = 1;
                CacheCarrito.Precio = Convert.ToInt32(dgvProductos.CurrentRow.Cells[2].Value.ToString());
                CacheCarrito.Total = CacheCarrito.Cantidad * CacheCarrito.Precio;
                FormCarrito formCarrito = new FormCarrito();
                formCarrito.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un cliente");
            }

        }
    }
}
