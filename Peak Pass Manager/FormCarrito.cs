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
        public FormCarrito(ModeloCarrito modeloCarrito)
        {
            InitializeComponent();
            Iniciar();
            IniciarN(modeloCarrito);

        }
        public void Iniciar()
        {
        }
        public void IniciarN(ModeloCarrito modeloCarrito)
        {
            dgvCarrito.DataSource = modeloCarrito.ObtenerLista();
        }

        private void btnCantidad_Click(object sender, EventArgs e)
        {
            dgvCarrito.CurrentRow.Cells[2].Value = Convert.ToInt32(txtCantidad.Text);
        }
    }
}
