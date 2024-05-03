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
        }
    }
}
