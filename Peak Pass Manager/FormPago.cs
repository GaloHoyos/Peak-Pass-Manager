using Comun;
using Comun.Cache;
using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Peak_Pass_Manager
{
    public partial class FormPago : Form
    {
        Verificaciones verificaciones = new Verificaciones();
        ControladoraPedido pedido = new ControladoraPedido();
        ControladoraCarrito carrito = new ControladoraCarrito(CacheCliente.IdCliente, 0);

        public FormPago(ControladoraCarrito carrito)
        {
            this.carrito = carrito;
            InitializeComponent();
        }

        private void txtTarjeta_TextChanged(object sender, EventArgs e)
        {
            switch (verificaciones.TipoTarjeta(txtTarjeta.Text))
            {
                case ("Visa"):
                    picLogo.Image = Imagenes.Visa;
                    break;
                case ("MasterCard"):
                    picLogo.Image = Imagenes.MasterCard;
                    break;
                case ("American Express"):
                    picLogo.Image = Imagenes.American_Express;
                    break;
            }
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            RealizarPedido();
        }

        //Realizar pedido
        private void RealizarPedido()
        {
            if (pedido != null)
            {
                pedido.AgregarPedido(CacheUsuario.IdUsuario, CacheCliente.IdCliente, Convert.ToInt32(carrito.ObtenerTotal()));
                ControladoraPedidoDetalle modeloPedidoDetalle = new ControladoraPedidoDetalle();
                foreach (DataRow row in carrito.ObtenerLista().Rows)
                {
                    modeloPedidoDetalle.AgregarDetallePedido(pedido.GetIdVenta(), Convert.ToInt32(row[1]), Convert.ToInt32(row[3]), Convert.ToInt32(row[4]));
                }
                MessageBox.Show("Compra realizada con exito");
            }
        }
    }
}
