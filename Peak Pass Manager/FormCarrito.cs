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

namespace Peak_Pass_Manager
{
    public partial class FormCarrito : Form
    {
        public ControladoraCarrito carrito { get; set; }
        public FormCarrito(ControladoraCarrito carrito)
        {
            InitializeComponent();
            this.carrito = carrito;
            IniciarN(this.carrito);
        }
        public void IniciarN(ControladoraCarrito carrito)
        {
            dgvCarrito.DataSource = carrito.ObtenerLista();
            lblTotal.Text = "Total: " + carrito.ObtenerTotal();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            if (carrito != null)
            {
                FormPago formPago = new FormPago(carrito);
                formPago.Show();
            }
            else
            {
                lblMensajeError.Show();
                lblMensajeError.Text = "No hay productos en carrito.";
            }


            /*
            if(modelo != null)
            {
                lblMensajeError.Hide();
                ControladoraPedido pedido = new ControladoraPedido();
                ControladoraUsuario usuario = new ControladoraUsuario();
                pedido.AgregarPedido(usuario.ObtenerIDUsuario(), CacheUsuario.IdCliente, Convert.ToInt32(modelo.ObtenerTotal()));
                ControladoraPedidoDetalle modeloPedidoDetalle = new ControladoraPedidoDetalle();
                foreach (DataRow row in modelo.ObtenerLista().Rows)
                {
                    modeloPedidoDetalle.AgregarDetallePedido(pedido.GetIdVenta(), Convert.ToInt32(row[1]), Convert.ToInt32(row[3]), Convert.ToInt32(row[4]));
                }
                MessageBox.Show("Compra realizada con exito");
            }
            else
            {
                lblMensajeError.Show();
                lblMensajeError.Text = "No hay productos en carrito.";
            }*/
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (dgvCarrito.CurrentRow != null)
            {
                carrito.EliminarProducto(Convert.ToInt32(dgvCarrito.CurrentRow.Cells[1].Value));
                IniciarN(carrito);
                lblMensajeError.Hide();
            }
            else
            {
                lblMensajeError.Show();
                lblMensajeError.Text = "No hay productos seleccionados";
            }
        }

        private void btnQuitarCantidad_Click(object sender, EventArgs e)
        {
            if (dgvCarrito.CurrentRow != null)
            {
                if (Convert.ToInt32(dgvCarrito.CurrentRow.Cells[4].Value) == 1)
                {
                    carrito.EliminarProducto(Convert.ToInt32(dgvCarrito.CurrentRow.Cells[1].Value));
                    IniciarN(carrito);
                    lblMensajeError.Hide();
                }
                else
                {
                    carrito.QuitarCantidad(Convert.ToInt32(dgvCarrito.CurrentRow.Cells[1].Value), 1);
                    IniciarN(carrito);
                    lblMensajeError.Hide();
                }
            }
            else
            {
                lblMensajeError.Show();
                lblMensajeError.Text = "No hay productos seleccionados";
            }
        }
    }
}
