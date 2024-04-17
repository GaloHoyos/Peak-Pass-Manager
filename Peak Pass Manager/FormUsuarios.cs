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
        ControladoraPermisos controladoraPermisos = new ControladoraPermisos();
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
            dgvUsuarios.Columns[0].DataPropertyName = "id_usuario";
            dgvUsuarios.Columns.Add("Nombre", "Nombre");
            dgvUsuarios.Columns[1].DataPropertyName = "nombre";
            dgvUsuarios.Columns.Add("Apellido", "Apellido");
            dgvUsuarios.Columns[2].DataPropertyName = "apellido";
            dgvUsuarios.Columns.Add("DNI", "DNI");
            dgvUsuarios.Columns[3].DataPropertyName = "dni";
            dgvUsuarios.Columns.Add("Correo", "Correo");
            dgvUsuarios.Columns[4].DataPropertyName = "correo";
            dgvUsuarios.Columns.Add("Direccion", "Direccion");
            dgvUsuarios.Columns[5].DataPropertyName = "direccion";
            dgvUsuarios.Columns.Add("Telefono", "Telefono");
            dgvUsuarios.Columns[6].DataPropertyName = "telefono";
            dgvUsuarios.Columns.Add("Usuario", "Usuario");
            dgvUsuarios.Columns[7].DataPropertyName = "usuario";
            dgvUsuarios.Columns.Add("Contraseña", "Contraseña");
            dgvUsuarios.Columns[8].DataPropertyName = "contrasena";
            dgvUsuarios.Columns.Add("Rol", "Rol");
            dgvUsuarios.Columns[9].DataPropertyName = "nombre_rol";
            dgvUsuarios.DataSource = usuario.ActualizarLista();
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtDNI.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            for (int i = 1; i < 4; i++)
            {
                switch (i)
                {
                    case 1:
                        if (controladoraPermisos.AgregarUsuarios() == false)
                        {
                            btnAgregar.Enabled = false;
                        }
                        else
                        {
                            btnAgregar.Enabled = true;
                        }
                        break;
                    case 2:
                        if (controladoraPermisos.ModificarUsuarios() == false)
                        {
                            btnModificar.Enabled = false;
                        }
                        else
                        {
                            btnModificar.Enabled = true;
                        }
                        break;
                    case 3:
                        if (controladoraPermisos.EliminarUsuarios() == false)
                        {
                            btnEliminar.Enabled = false;
                        }
                        else
                        {
                            btnEliminar.Enabled = true;
                        }
                        break;
                }
            }
        }
        public void AgregarUsuario()
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }
        public void ModificarUsuario()
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }

        }
        public void EliminarUsuario()
        {
            try
            {
                ControladoraUsuario usuario = new ControladoraUsuario();
                usuario.EliminarUsuario(Convert.ToInt32(dgvUsuarios.CurrentRow.Cells[0].Value));
                iniciar();
                LimpioUsuario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
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
