
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
using Comun;

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
            ControladoraCliente modeloCliente = new ControladoraCliente();
            dgvClientes.DataSource = modeloCliente.ActualizarLista();
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtDNI.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            lblCliente.Text = CacheCliente.Nombre + " " + CacheCliente.Apellido;
        }

        public void AgregarCliente()
        {
            ControladoraCliente modeloCliente = new ControladoraCliente();
            modeloCliente.AgregarCliente(txtNombre.Text, txtApellido.Text, txtDNI.Text, txtCorreo.Text, txtDireccion.Text, txtTelefono.Text);
            iniciar();
        }
        public void ModificarCliente()
        {
            ControladoraCliente modeloCliente = new ControladoraCliente();
            modeloCliente.ModificarClienteSeleccionado(Convert.ToInt32(dgvClientes.CurrentRow.Cells[0].Value), txtNombre.Text, txtApellido.Text, txtDNI.Text, txtCorreo.Text, txtDireccion.Text, txtTelefono.Text);
            iniciar();
            LimpioCliente();
        }
        public void EliminarCliente()
        {
            ControladoraCliente modeloCliente = new ControladoraCliente();
            modeloCliente.EliminarCliente(Convert.ToInt32(dgvClientes.CurrentRow.Cells[0].Value));
            iniciar();
            LimpioCliente();
        }
        private void FormClientes_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Verificaciones verificaciones = new Verificaciones();
            bool verif = verificaciones.VerificacionCrearCliente(txtNombre.Text, txtApellido.Text, txtDNI.Text, txtCorreo.Text, txtDireccion.Text, txtTelefono.Text);
            if (verif == true)
            {
                AgregarCliente();
                lblMensajeError.Hide();
            }
            else
            {
                lblMensajeError.Show();
                lblMensajeError.Text = "Complete todos los campos";
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow == null)
            {
                lblMensajeError.Show();
                lblMensajeError.Text = "Seleccione un cliente";
            }
            else
            {
                Verificaciones verificaciones = new Verificaciones();
                bool verif = verificaciones.VerificacionCrearCliente(txtNombre.Text, txtApellido.Text, txtDNI.Text, txtCorreo.Text, txtDireccion.Text, txtTelefono.Text);
                if (verif == true)
                {
                    ModificarCliente();
                    lblMensajeError.Hide();
                }
                else
                {
                    lblMensajeError.Show();
                    lblMensajeError.Text = "Complete todos los campos";
                }
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
            if (dgvClientes.CurrentRow == null)
            {
                lblMensajeError.Show();
                lblMensajeError.Text = "Seleccione un cliente";
            }
            else
            {
                EliminarCliente();
                lblMensajeError.Hide();
                dgvClientes.ClearSelection();
            }
        }

        private void btnCambioCliente_Click(object sender, EventArgs e)
        {
            if(dgvClientes.CurrentRow == null)
            {
                lblMensajeError.Show();
                lblMensajeError.Text = "Seleccione un cliente";
            }
            else
            {
                CambioCliente();
            }

        }
        public void CambioCliente()
        {
            lblMensajeError.Hide();
            CacheCliente.IdCliente = Convert.ToInt32(dgvClientes.CurrentRow.Cells[0].Value);
            CacheCliente.Nombre = dgvClientes.CurrentRow.Cells[1].Value.ToString();
            CacheCliente.Apellido = dgvClientes.CurrentRow.Cells[2].Value.ToString();
            CacheCliente.DNI = dgvClientes.CurrentRow.Cells[3].Value.ToString();
            CacheCliente.Correo = dgvClientes.CurrentRow.Cells[4].Value.ToString();
            CacheCliente.Direccion = dgvClientes.CurrentRow.Cells[5].Value.ToString();
            CacheCliente.Telefono = dgvClientes.CurrentRow.Cells[6].Value.ToString();
            lblCliente.Text = CacheCliente.Nombre + " " + CacheCliente.Apellido;
        }
        public void LimpioCliente()
        {
            CacheCliente.IdCliente = -1;
            CacheCliente.Nombre = string.Empty;
            CacheCliente.Apellido = string.Empty;
            CacheCliente.DNI = string.Empty;
            CacheCliente.Correo = string.Empty;
            CacheCliente.Direccion = string.Empty;
            CacheCliente.Telefono = string.Empty;
            lblCliente.Text = string.Empty;
        }
    }
}
