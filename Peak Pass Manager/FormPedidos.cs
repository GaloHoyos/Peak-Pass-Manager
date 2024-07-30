using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Acceso_a_Datos;
using Dominio;

namespace Peak_Pass_Manager
{
    public partial class FormPedidos : Form
    {
        public FormPedidos()
        {
            InitializeComponent();
            ActualizarLista();
            dgvCompraDetalles.Visible = false;
            btnCerrar.Visible = false;
            btnFiltrosRJ.Text = "Filtros";
            btnFiltrosRJ.BackColor = Color.RoyalBlue;
            btnFiltrosRJ.BackgroundColor = Color.RoyalBlue;
            btnFiltrosRJ.BorderColor = Color.RoyalBlue;
            btnFiltrosRJ.TextColor = Color.White;
            gboxFiltros.Hide();
        }
        public void MostrarDetalles(int idVenta)
        {
            ControladoraPedidoDetalle controladoraPedidoDetalle = new ControladoraPedidoDetalle();
            dgvCompraDetalles.Columns.Clear();
            dgvCompraDetalles.Columns.Add("ID Cliente", "ID Cliente");
            dgvCompraDetalles.Columns[0].DataPropertyName = "id_usuario";
            dgvCompraDetalles.Columns.Add("Nombre Cliente", "Nombre Cliente");
            dgvCompraDetalles.Columns[1].DataPropertyName = "nombre";
            dgvCompraDetalles.Columns.Add("Apellido Cliente", "Apellido Cliente");
            dgvCompraDetalles.Columns[2].DataPropertyName = "apellido";
            dgvCompraDetalles.Columns.Add("ID Producto", "ID Producto");
            dgvCompraDetalles.Columns[3].DataPropertyName = "id_producto";
            dgvCompraDetalles.Columns.Add("Nombre Producto", "Nombre Producto");
            dgvCompraDetalles.Columns[4].DataPropertyName = "nombre_producto";
            dgvCompraDetalles.Columns.Add("Precio Producto", "Precio Producto");
            dgvCompraDetalles.Columns[5].DataPropertyName = "precio_producto";
            dgvCompraDetalles.Columns.Add("Cantidad", "Cantidad");
            dgvCompraDetalles.Columns[6].DataPropertyName = "cantidad";
            dgvCompraDetalles.DataSource = controladoraPedidoDetalle.ActualizarLista(idVenta);
            dgvCompraDetalles.Visible = true;
            btnCerrar.Visible = true;
        }
        public void ActualizarLista()
        {
            ControladoraPedido pedido = new ControladoraPedido();
            dgvCompra.Columns.Clear();
            dgvCompra.Columns.Add("ID Venta", "ID Venta");
            dgvCompra.Columns[0].DataPropertyName = "id_venta";
            dgvCompra.Columns.Add("ID Vendedor", "ID Vendedor");
            dgvCompra.Columns[1].DataPropertyName = "id_vendedor";
            dgvCompra.Columns.Add("Nombre Vendedor", "Nombre Vendedor");
            dgvCompra.Columns[2].DataPropertyName = "nombre_vendedor";
            dgvCompra.Columns.Add("ID Cliente", "ID Cliente");
            dgvCompra.Columns[3].DataPropertyName = "id_cliente";
            dgvCompra.Columns.Add("Nombre Cliente", "Nombre Cliente");
            dgvCompra.Columns[4].DataPropertyName = "nombre_cliente";
            dgvCompra.Columns.Add("Apellido Cliente", "Apellido Cliente");
            dgvCompra.Columns[5].DataPropertyName = "apellido_cliente";
            dgvCompra.Columns.Add("Costo Total", "Costo Total");
            dgvCompra.Columns[6].DataPropertyName = "costo_total";
            dgvCompra.Columns.Add("Fecha", "Fecha");
            dgvCompra.Columns[7].DataPropertyName = "fecha";
            dgvCompra.DataSource = pedido.ActualizarLista();
        }

        private void btnVerDetalles_Click(object sender, EventArgs e)
        {
            if (dgvCompra.SelectedCells.Count == 0)
            {
                MessageBox.Show("Seleccione un pedido para ver los detalles", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                int idVenta = Convert.ToInt32(dgvCompra.CurrentRow.Cells[0].Value);
                MostrarDetalles(idVenta);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            dgvCompraDetalles.Visible = false;
            btnCerrar.Visible = false;
        }

        private void btnBuscarRJ_Click(object sender, EventArgs e)
        {
            ControladoraPedido controladoraPedido = new ControladoraPedido();
            string searchString = txtBuscar.Text.Trim();
            DataTable dt = controladoraPedido.BuscarPedidos(searchString);

            if (dt.Rows.Count > 0)
            {
                dgvCompra.Columns.Clear();
                dgvCompra.Columns.Add("ID Venta", "ID Venta");
                dgvCompra.Columns[0].DataPropertyName = "id_venta";
                dgvCompra.Columns.Add("ID Vendedor", "ID Vendedor");
                dgvCompra.Columns[1].DataPropertyName = "id_vendedor";
                dgvCompra.Columns.Add("Nombre Vendedor", "Nombre Vendedor");
                dgvCompra.Columns[2].DataPropertyName = "nombre_vendedor";
                dgvCompra.Columns.Add("ID Cliente", "ID Cliente");
                dgvCompra.Columns[3].DataPropertyName = "id_cliente";
                dgvCompra.Columns.Add("Nombre Cliente", "Nombre Cliente");
                dgvCompra.Columns[4].DataPropertyName = "nombre_cliente";
                dgvCompra.Columns.Add("Apellido Cliente", "Apellido Cliente");
                dgvCompra.Columns[5].DataPropertyName = "apellido_cliente";
                dgvCompra.Columns.Add("Costo Total", "Costo Total");
                dgvCompra.Columns[6].DataPropertyName = "costo_total";
                dgvCompra.Columns.Add("Fecha", "Fecha");
                dgvCompra.Columns[7].DataPropertyName = "fecha";
                dgvCompra.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No se encontraron resultados.", "Búsqueda");
                dgvCompra.DataSource = null;
            }
        }

        private void btnFiltrosRJ_Click(object sender, EventArgs e)
        {
            if (gboxFiltros.Visible == false)
            {
                btnFiltrosRJ.Text = "Ocultar Filtros";
                btnFiltrosRJ.BackColor = Color.Transparent;
                btnFiltrosRJ.BackgroundColor = Color.Transparent;
                btnFiltrosRJ.BorderColor = Color.RoyalBlue;
                btnFiltrosRJ.TextColor = Color.RoyalBlue;
                gboxFiltros.Show();
            }
            else
            {
                btnFiltrosRJ.Text = "Filtros";
                btnFiltrosRJ.BackColor = Color.RoyalBlue;
                btnFiltrosRJ.BackgroundColor = Color.RoyalBlue;
                btnFiltrosRJ.BorderColor = Color.RoyalBlue;
                btnFiltrosRJ.TextColor = Color.White;
                gboxFiltros.Hide();
            }
        }
    }
}
