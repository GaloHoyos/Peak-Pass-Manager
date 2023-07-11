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
using Comun.Cache;

namespace Peak_Pass_Manager
{
    public partial class FormClientes : Form
    {
        Form formActual;
        public FormClientes()
        {
            InitializeComponent();
            iniciar();

        }
        public void iniciar()
        {
            ModeloCliente modeloCliente = new ModeloCliente();
            dgvClientes.DataSource = modeloCliente.ActualizarLista();
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtDNI.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtTelefono.Text = string.Empty;
        }

        public void AgregarCliente()
        {
            ModeloCliente modeloCliente = new ModeloCliente();
            modeloCliente.AgregarCliente(txtNombre.Text, txtApellido.Text, Convert.ToInt32(txtDNI.Text), txtCorreo.Text, txtDireccion.Text, Convert.ToInt32(txtTelefono.Text));
            iniciar();
        }
        public void ModificarCliente()
        {
            ModeloCliente modeloCliente = new ModeloCliente();
            modeloCliente.ModificarCliente(Convert.ToInt32(dgvClientes.CurrentRow.Cells[0].Value), txtNombre.Text, txtApellido.Text, Convert.ToInt32(txtDNI.Text), txtCorreo.Text, txtDireccion.Text, Convert.ToInt32(txtTelefono.Text));
            iniciar();
        }
        public void EliminarCliente()
        {
            ModeloCliente modeloCliente = new ModeloCliente();
            modeloCliente.EliminarCliente(Convert.ToInt32(dgvClientes.CurrentRow.Cells[0].Value));
            iniciar();
        }
        private void FormClientes_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarCliente();
            lblMensajeError.Hide();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow.Cells[0].Value != null)
            {
                ModificarCliente();
                lblMensajeError.Hide();
            }
            else
            {
                lblMensajeError.Show();
                lblMensajeError.Text = "Seleccione un cliente";
            }
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombre.Text = dgvClientes.CurrentRow.Cells[1].Value.ToString();
            txtApellido.Text = dgvClientes.CurrentRow.Cells[2].Value.ToString();
            txtDNI.Text = dgvClientes.CurrentRow.Cells[3].Value.ToString();
            txtCorreo.Text = dgvClientes.CurrentRow.Cells[4].Value.ToString();
            txtDireccion.Text = dgvClientes.CurrentRow.Cells[5].Value.ToString();
            txtTelefono.Text = dgvClientes.CurrentRow.Cells[6].Value.ToString();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow.Cells[0].Value != null)
            {
                EliminarCliente();
                lblMensajeError.Hide();
            }
            else
            {
                lblMensajeError.Show();
                lblMensajeError.Text = "Seleccione un cliente";
            }
        }

        private void btnCambioCliente_Click(object sender, EventArgs e)
        {
            CacheCliente.IdCliente = Convert.ToInt32(dgvClientes.CurrentRow.Cells[0].Value);
            CacheCliente.Nombre = dgvClientes.CurrentRow.Cells[1].Value.ToString();
            CacheCliente.Apellido = dgvClientes.CurrentRow.Cells[2].Value.ToString();
            CacheCliente.DNI = Convert.ToInt32(dgvClientes.CurrentRow.Cells[3].Value);
            CacheCliente.Correo = dgvClientes.CurrentRow.Cells[4].Value.ToString();
            CacheCliente.Direccion = dgvClientes.CurrentRow.Cells[5].Value.ToString();
            CacheCliente.Telefono = Convert.ToInt32(dgvClientes.CurrentRow.Cells[6].Value);
            lblCliente.Text = CacheCliente.Nombre + " " + CacheCliente.Apellido;
        }
    }
}
