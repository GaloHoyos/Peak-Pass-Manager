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
            RelizarPedido();
        }

        //Realizar pedido
        public void RelizarPedido()
        {
            // if (verificaciones.VerificarTarjeta(txtTarjeta.Text) && verificaciones.VerificarCVV(txtCodigo.Text) && verificaciones.VerificarFecha(dtFecha.Value.ToString()))
            //{
            try
            {
                pedido.AgregarPedido(CacheUsuario.IdUsuario, CacheCliente.IdCliente, Convert.ToInt32(carrito.ObtenerTotal()));
                ControladoraPedidoDetalle controladoraPedidoDetalle = new ControladoraPedidoDetalle();
                foreach (DataRow row in carrito.ObtenerLista().Rows)
                {
                    //Llama AgregarDetallePedido de ControladoraPedidoDetalle para agregar un detalle de pedido con los datos de la fila incluyendo el id de la venta y el id del cliente
                    controladoraPedidoDetalle.AgregarDetallePedido(pedido.GetIdVenta(), Convert.ToInt32(row[2]), Convert.ToInt32(row[0]), Convert.ToInt32(row[4]), Convert.ToInt32(row[5]));
                }
                MessageBox.Show("Compra realizada con exito");
                carrito.LimpiarCarrito();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

          //  }
           // else
           // {
            //    MessageBox.Show("Error en los datos de la tarjeta");
           // }
        }
    }
}
