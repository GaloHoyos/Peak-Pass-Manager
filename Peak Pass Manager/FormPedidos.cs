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
            ControladoraPedido modeloPedido = new ControladoraPedido();
            dgvCompra.DataSource = modeloPedido.ActualizarLista();
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            int idVenta = Convert.ToInt32(dgvCompra.CurrentRow.Cells[0].Value);
            FormPedidosDetalles formPedidosDetalles = new FormPedidosDetalles(idVenta);
            formPedidosDetalles.ShowDialog();
        }
    }
}
