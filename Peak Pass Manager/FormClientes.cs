
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
            ControladoraUsuario cliente = new ControladoraUsuario();
            dgvClientes.DataSource = cliente.ActualizarLista();
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtDNI.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            lblCliente.Text = cliente.ObtenerNombre() + " " + cliente.ObtenerApellido();
        }

        public void AgregarCliente()
        {
            ControladoraUsuario cliente = new ControladoraUsuario();
            cliente.AgregarUsuario(txtNombre.Text, txtApellido.Text, txtDNI.Text, txtCorreo.Text, txtDireccion.Text, txtTelefono.Text, "", "", 0);
            iniciar();
        }
        public void ModificarCliente()
        {
            ControladoraUsuario cliente = new ControladoraUsuario();
            cliente.ModifcarUsuario(Convert.ToInt32(dgvClientes.CurrentRow.Cells[0].Value), txtNombre.Text, txtApellido.Text, txtDNI.Text, txtCorreo.Text, txtDireccion.Text, txtTelefono.Text, "","",0);
            iniciar();
            LimpioCliente();
        }
        public void EliminarCliente()
        {
            ControladoraUsuario cliente = new ControladoraUsuario();
            cliente.EliminarUsuario(Convert.ToInt32(dgvClientes.CurrentRow.Cells[0].Value));
            iniciar();
            LimpioCliente();
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
            CacheUsuario.IdCliente = Convert.ToInt32(dgvClientes.CurrentRow.Cells[0].Value);
            CacheUsuario.Nombre = dgvClientes.CurrentRow.Cells[1].Value.ToString();
            CacheUsuario.Apellido = dgvClientes.CurrentRow.Cells[2].Value.ToString();
            CacheUsuario.DNI = dgvClientes.CurrentRow.Cells[3].Value.ToString();
            CacheUsuario.Correo = dgvClientes.CurrentRow.Cells[4].Value.ToString();
            CacheUsuario.Direccion = dgvClientes.CurrentRow.Cells[5].Value.ToString();
            CacheUsuario.Telefono = dgvClientes.CurrentRow.Cells[6].Value.ToString();
            lblCliente.Text = CacheUsuario.Nombre + " " + CacheUsuario.Apellido;
        }
        public void LimpioCliente()
        {
            CacheUsuario.IdCliente = -1;
            CacheUsuario.Nombre = string.Empty;
            CacheUsuario.Apellido = string.Empty;
            CacheUsuario.DNI = string.Empty;
            CacheUsuario.Correo = string.Empty;
            CacheUsuario.Direccion = string.Empty;
            CacheUsuario.Telefono = string.Empty;
            lblCliente.Text = string.Empty;
        }
    }
}
