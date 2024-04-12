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
    public partial class FormUsuarios : Form
    {
        public FormUsuarios()
        {
            InitializeComponent();
            iniciar();
            cmbRol.Items.Add("Administrador");
            cmbRol.Items.Add("Vendedor");
        }
        public void iniciar()
        {
            ControladoraUsuario usuario = new ControladoraUsuario();
            //Agregar columnas vacias al dgv
            dgvUsuarios.Columns.Clear();
            dgvUsuarios.Columns.Add("ID", "ID");
            dgvUsuarios.Columns.Add("Nombre", "Nombre");
            dgvUsuarios.Columns.Add("Apellido", "Apellido");
            dgvUsuarios.Columns.Add("DNI", "DNI");
            dgvUsuarios.Columns.Add("Correo", "Correo");
            dgvUsuarios.Columns.Add("Direccion", "Direccion");
            dgvUsuarios.Columns.Add("Telefono", "Telefono");
            dgvUsuarios.Columns.Add("Rol", "Rol");
            //dgvUsuarios.DataSource = usuario.ActualizarListaRoles();
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtDNI.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtTelefono.Text = string.Empty;
        }
        public void AgregarUsuario()
        {
            if (cmbRol.SelectedItem.ToString() == "Administrador")
            {
                ControladoraUsuario usuario = new ControladoraUsuario();
                usuario.AgregarUsuario(txtNombre.Text, txtApellido.Text, txtDNI.Text, txtCorreo.Text, txtDireccion.Text, txtTelefono.Text, txtUsuario.Text, txtPassword.Text, 1);
                iniciar();
            }
            else if (cmbRol.SelectedItem.ToString() == "Vendedor")
            {
                ControladoraUsuario usuario = new ControladoraUsuario();
                usuario.AgregarUsuario(txtNombre.Text, txtApellido.Text, txtDNI.Text, txtCorreo.Text, txtDireccion.Text, txtTelefono.Text, txtUsuario.Text, txtPassword.Text, 2);
                iniciar();
            }
        }
        public void ModificarUsuario()
        {
            if (cmbRol.SelectedItem.ToString() == "Administrador")
            {
                ControladoraUsuario usuario = new ControladoraUsuario();
                usuario.ModifcarUsuario(Convert.ToInt32(dgvUsuarios.CurrentRow.Cells[0].Value), txtNombre.Text, txtApellido.Text, txtDNI.Text, txtCorreo.Text, txtDireccion.Text, txtTelefono.Text, txtUsuario.Text, txtPassword.Text, 1);
                iniciar();
                LimpioUsuario();
            }
            else if (cmbRol.SelectedItem.ToString() == "Vendedor")
            {
                ControladoraUsuario usuario = new ControladoraUsuario();
                usuario.ModifcarUsuario(Convert.ToInt32(dgvUsuarios.CurrentRow.Cells[0].Value), txtNombre.Text, txtApellido.Text, txtDNI.Text, txtCorreo.Text, txtDireccion.Text, txtTelefono.Text, txtUsuario.Text, txtPassword.Text, 2);
                iniciar();
                LimpioUsuario();
            }
        }
        public void EliminarUsuario()
        {
            ControladoraUsuario usuario = new ControladoraUsuario();
            usuario.EliminarUsuario(Convert.ToInt32(dgvUsuarios.CurrentRow.Cells[0].Value));
            iniciar();
            LimpioUsuario();
        }
        public void LimpioUsuario()
        {
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtDNI.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtUsuario.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Verificaciones verificaciones = new Verificaciones();
            bool verif = verificaciones.VerificacionCrearUsuario(txtNombre.Text, txtApellido.Text, txtDNI.Text, txtCorreo.Text, txtDireccion.Text, txtTelefono.Text, txtUsuario.Text, txtPassword.Text);
            if (verif == true)
            {
                AgregarUsuario();
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
            Verificaciones verificaciones = new Verificaciones();
            bool verif = verificaciones.VerificacionCrearUsuario(txtNombre.Text, txtApellido.Text, txtDNI.Text, txtCorreo.Text, txtDireccion.Text, txtTelefono.Text, txtUsuario.Text, txtPassword.Text);
            if (verif == true)
            {
                ModificarUsuario();
                lblMensajeError.Hide();
            }
            else
            {
                lblMensajeError.Show();
                lblMensajeError.Text = "Complete todos los campos";
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow == null)
            {
                lblMensajeError.Show();
                lblMensajeError.Text = "Seleccione un usuario";
            }
            else
            {
                EliminarUsuario();
                lblMensajeError.Hide();
            }
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombre.Text = dgvUsuarios.CurrentRow.Cells[1].Value.ToString();
            txtApellido.Text = dgvUsuarios.CurrentRow.Cells[2].Value.ToString();
            txtDNI.Text = dgvUsuarios.CurrentRow.Cells[3].Value.ToString();
            txtCorreo.Text = dgvUsuarios.CurrentRow.Cells[4].Value.ToString();
            txtDireccion.Text = dgvUsuarios.CurrentRow.Cells[5].Value.ToString();
            txtTelefono.Text = dgvUsuarios.CurrentRow.Cells[6].Value.ToString();
        }
    }
}
