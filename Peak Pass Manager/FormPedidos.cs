using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;

namespace Peak_Pass_Manager
{
    public partial class FormPedidos : Form
    {
        public FormPedidos()
        {
            InitializeComponent();
            ActualizarLista();
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

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            if (dgvCompra.SelectedCells.Count == 0)
            {
                MessageBox.Show("Seleccione un pedido para ver los detalles", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                int idVenta = Convert.ToInt32(dgvCompra.CurrentRow.Cells[0].Value);
                FormPedidosDetalles formPedidosDetalles = new FormPedidosDetalles(idVenta);
                formPedidosDetalles.ShowDialog();
            }
        }
    }
}
