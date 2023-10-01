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
    public partial class FormPedidosDetalles : Form
    {
        public FormPedidosDetalles(int idVenta)
        {
            InitializeComponent();
            Iniciar(idVenta);
        }
        public void Iniciar(int idVenta)
        {
            ControladoraPedidoDetalle modeloPedidoDetalle = new ControladoraPedidoDetalle();
            dgvCompraDetalles.DataSource = modeloPedidoDetalle.ActualizarLista(idVenta);
        }
    }
}
