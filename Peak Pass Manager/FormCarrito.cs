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

namespace Peak_Pass_Manager
{
    public partial class FormCarrito : Form
    {
        public FormCarrito()
        {
            InitializeComponent();
            AgregarProductos();
        }
        public void AgregarProductos()
        {
            dgvCarrito.Rows.Add(CacheCarrito.IdCliente, CacheCarrito.IdProducto, CacheCarrito.Cantidad, CacheCarrito.Precio);
        }

        private void btnCantidad_Click(object sender, EventArgs e)
        {
            dgvCarrito.CurrentRow.Cells[2].Value = Convert.ToInt32(txtCantidad.Text);
            CacheCarrito.Cantidad = Convert.ToInt32(txtCantidad.Text);
        }
    }
}
