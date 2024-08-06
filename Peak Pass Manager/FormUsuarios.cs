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
            Iniciar();
            LlenarRoles();
        }
        public void Iniciar()
        {
            ControladoraUsuario usuario = new ControladoraUsuario();
            btnFiltrosRJ.Text = "Filtros";
            btnFiltrosRJ.BackColor = Color.RoyalBlue;
            btnFiltrosRJ.BackgroundColor = Color.RoyalBlue;
            btnFiltrosRJ.BorderColor = Color.RoyalBlue;
            btnFiltrosRJ.TextColor = Color.White;
            gboxFiltros.Hide();
            cboxUserActivo.Checked = true;
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
                            btnAgregarRJ.Enabled = false;
                        }
                        else
                        {
                            btnAgregarRJ.Enabled = true;
                        }
                        break;
                    case 2:
                        if (controladoraPermisos.ModificarUsuarios() == false)
                        {
                            btnModificarRJ.Enabled = false;
                        }
                        else
                        {
                            btnModificarRJ.Enabled = true;
                        }
                        break;
                    case 3:
                        if (controladoraPermisos.EliminarUsuarios() == false)
                        {
                            btnEliminarRJ.Enabled = false;
                        }
                        else
                        {
                            btnEliminarRJ.Enabled = true;
                        }
                        break;
                }
            }
        }
        public void LlenarRoles()
        {
            try
            {
                if (cboxInactivo.Checked)
                {
                    cmbRol.Items.Clear();
                    cmbRolFiltro.Items.Clear();
                    List<string> rolesActivos = controladoraPermisos.ObtenerRolesActivos();
                    List<string> rolesInactivos = controladoraPermisos.ObtenerRolesInactivos();
                    cmbRolFiltro.Items.Add("Todos");
                    foreach (string rol in rolesActivos)
                    {
                        cmbRol.Items.Add(rol);
                        cmbRolFiltro.Items.Add(rol);
                    }
                    foreach (string rol in rolesInactivos)
                    {
                        cmbRol.Items.Add(rol);
                        cmbRolFiltro.Items.Add(rol);
                    }
                    cmbRol.SelectedIndex = 0;
                    cmbRolFiltro.SelectedIndex = 0;

                }
                else
                {
                    cmbRol.Items.Clear();
                    cmbRolFiltro.Items.Clear();
                    List<string> roles = controladoraPermisos.ObtenerRolesActivos();
                    cmbRolFiltro.Items.Add("Todos");
                    foreach (string rol in roles)
                    {
                        cmbRol.Items.Add(rol);
                        cmbRolFiltro.Items.Add(rol);
                    }
                    cmbRol.SelectedIndex = 0;
                    cmbRolFiltro.SelectedIndex = 0;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void AgregarUsuario()
        {
            try
            {
                int idRol = controladoraPermisos.ObtenerIdRol(cmbRol.Text);
                IControladoraUsuario controladoraUsuario = new ControladoraUsuario();
                IControladoraUsuario controladoraUsuarioConAuditoria = new ControladoraUsuarioConAuditoria(controladoraUsuario);
                switch (controladoraUsuarioConAuditoria.AgregarUsuario(0, txtNombre.Text, txtApellido.Text, txtDNI.Text, txtCorreo.Text, txtDireccion.Text, txtTelefono.Text, txtUsuario.Text, txtPassword.Text, idRol, cboxUserActivo.Checked))
                {
                    case "Activo y Existente":
                        MessageBox.Show("El usuario ya existe");
                        break;
                    case "Inactivo y Existente":
                        var m = MessageBox.Show("El usuario ya existe y esta inactivo. Desea reactivarlo?", "Atencion", MessageBoxButtons.YesNo);
                        if (m == DialogResult.Yes)
                        {
                            controladoraUsuarioConAuditoria.ActivarUsuario(controladoraUsuario.ObtenerIdPorDNI(txtDNI.Text));
                            Iniciar();
                            LimpioUsuario();
                        }
                        break;
                    case "Usuario Existente":
                        MessageBox.Show("Ya existe una persona con ese nombre de usuario");
                        break;
                    case "DNI Existente":
                        MessageBox.Show("Ya existe una persona con ese DNI");
                        break;
                    case "No Existente":
                        Iniciar();
                        LimpioUsuario();
                        break;
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
                IControladoraUsuario controladoraUsuario = new ControladoraUsuario();
                IControladoraUsuario controladoraUsuarioConAuditoria = new ControladoraUsuarioConAuditoria(controladoraUsuario); ;
                if (dgvUsuarios.CurrentRow.Cells[0].Value.ToString() == CacheUsuario.IdUsuario.ToString())
                {
                    MessageBox.Show("No se puede modificar el usuario que esta en uso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtDNI.Text == controladoraUsuario.ObtenerDNI(Convert.ToInt32(dgvUsuarios.CurrentRow.Cells[0].Value)))
                {
                    int idRol = controladoraPermisos.ObtenerIdRol(cmbRol.Text);
                    if (controladoraUsuarioConAuditoria.ModifcarUsuario(Convert.ToInt32(dgvUsuarios.CurrentRow.Cells[0].Value), txtNombre.Text, txtApellido.Text, txtDNI.Text, txtCorreo.Text, txtDireccion.Text, txtTelefono.Text, txtUsuario.Text, txtPassword.Text, idRol, cboxUserActivo.Checked))
                    {
                        Iniciar();
                        LimpioUsuario();
                    }
                    else
                    {
                        MessageBox.Show("El nombre de Usuario ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (controladoraUsuario.ExisteDNI(txtDNI.Text))
                    {
                        MessageBox.Show("DNI Existente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        int idRol = controladoraPermisos.ObtenerIdRol(cmbRol.Text);
                        controladoraUsuarioConAuditoria.ModifcarUsuario(Convert.ToInt32(dgvUsuarios.CurrentRow.Cells[0].Value), txtNombre.Text, txtApellido.Text, txtDNI.Text, txtCorreo.Text, txtDireccion.Text, txtTelefono.Text, txtUsuario.Text, txtPassword.Text, idRol, cboxUserActivo.Checked);
                        Iniciar();
                        LimpioUsuario();
                    }
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
                if (dgvUsuarios.CurrentRow.Cells[0].Value.ToString() == CacheUsuario.IdUsuario.ToString())
                {
                    MessageBox.Show("No se puede eliminar el usuario que esta en uso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    IControladoraUsuario controladoraUsuario = new ControladoraUsuario();
                    IControladoraUsuario controladoraUsuarioConAuditoria = new ControladoraUsuarioConAuditoria(controladoraUsuario);
                    if (controladoraUsuarioConAuditoria.EliminarUsuario(Convert.ToInt32(dgvUsuarios.CurrentRow.Cells[0].Value)))
                    {
                        var resultado = MessageBox.Show("No se puede eliminar el usuario porque tiene pedidos asociados, desea desactivarlo en cambio?", "Atencion", MessageBoxButtons.YesNo);
                        if (resultado == DialogResult.Yes)
                        {
                            controladoraUsuarioConAuditoria.DesactivarUsuario(Convert.ToInt32(dgvUsuarios.CurrentRow.Cells[0].Value));
                            Iniciar();
                            LimpioUsuario();
                            MessageBox.Show("Usuario desactivado");
                        }
                    }
                    else
                    {
                        Iniciar();
                        LimpioUsuario();
                    }
                }
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

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ControladoraUsuario usuario = new ControladoraUsuario();
            txtNombre.Text = dgvUsuarios.CurrentRow.Cells[1].Value.ToString();
            txtApellido.Text = dgvUsuarios.CurrentRow.Cells[2].Value.ToString();
            txtDNI.Text = dgvUsuarios.CurrentRow.Cells[3].Value.ToString();
            txtCorreo.Text = dgvUsuarios.CurrentRow.Cells[4].Value.ToString();
            txtDireccion.Text = dgvUsuarios.CurrentRow.Cells[5].Value.ToString();
            txtTelefono.Text = dgvUsuarios.CurrentRow.Cells[6].Value.ToString();
            cmbRol.Text = dgvUsuarios.CurrentRow.Cells[9].Value.ToString();
            if (usuario.UsuarioActivo(dgvUsuarios.CurrentRow.Cells[3].Value.ToString()))
            {
                cboxUserActivo.Checked = true;
            }
            else
            {
                cboxUserActivo.Checked = false;
            }
        }
        private void btnFiltrosRJ_Click(object sender, EventArgs e)
        {
            LlenarRoles();
            if (gboxFiltros.Visible == false)
            {
                btnFiltrosRJ.Text = "Ocultar Filtros";
                btnFiltrosRJ.BackColor = Color.Transparent;
                btnFiltrosRJ.BackgroundColor = Color.Transparent;
                btnFiltrosRJ.BorderColor = Color.RoyalBlue;
                btnFiltrosRJ.TextColor = Color.RoyalBlue;
                gboxFiltros.Show();
            }
            else
            {
                btnFiltrosRJ.Text = "Filtros";
                btnFiltrosRJ.BackColor = Color.RoyalBlue;
                btnFiltrosRJ.BackgroundColor = Color.RoyalBlue;
                btnFiltrosRJ.BorderColor = Color.RoyalBlue;
                btnFiltrosRJ.TextColor = Color.White;
                gboxFiltros.Hide();
            }
        }

        private void btnBuscarRJ_Click(object sender, EventArgs e)
        {
            if (cboxActivo.Checked == true && cboxInactivo.Checked == true)
            {
                ControladoraUsuario usuario = new ControladoraUsuario();
                dgvUsuarios.DataSource = usuario.BuscarUsuario(txtBuscar.Text, cmbRolFiltro.Text);
            }
            else if (cboxActivo.Checked == true && cboxInactivo.Checked == false)
            {
                ControladoraUsuario usuario = new ControladoraUsuario();
                dgvUsuarios.DataSource = usuario.BuscarUsuarioActivoInactivo(txtBuscar.Text, cmbRolFiltro.Text, 1);
            }
            else if (cboxActivo.Checked == false && cboxInactivo.Checked == true)
            {
                ControladoraUsuario usuario = new ControladoraUsuario();
                dgvUsuarios.DataSource = usuario.BuscarUsuarioActivoInactivo(txtBuscar.Text, cmbRolFiltro.Text, 0);
            }
            else
            {
                ControladoraUsuario usuario = new ControladoraUsuario();
                dgvUsuarios.DataSource = usuario.BuscarUsuarioActivoInactivo(txtBuscar.Text, cmbRolFiltro.Text, 1);
            }
            LlenarRoles();
        }

        private void btnAgregarRJ_Click(object sender, EventArgs e)
        {
            Verificaciones verificaciones = new Verificaciones();
            bool verif = verificaciones.VerificacionCrearUsuario(txtNombre.Text, txtApellido.Text, txtDNI.Text, txtCorreo.Text, txtDireccion.Text, txtTelefono.Text, txtUsuario.Text, txtPassword.Text);
            bool verifCliente = verificaciones.VerificacionCrearCliente(txtNombre.Text, txtApellido.Text, txtDNI.Text, txtCorreo.Text, txtDireccion.Text, txtTelefono.Text);
            if(cmbRol.SelectedItem.ToString() == "Cliente")
            {
                if(verifCliente == true)
                {
                    AgregarUsuario();
                    lblMensajeError.Hide();
                    MessageBox.Show("Cliente agregado");
                }
                else
                {
                    lblMensajeError.Show();
                    lblMensajeError.Text = "Complete todos los campos";
                }
            }
            else
            {
                if (verif == true)
                {
                    AgregarUsuario();
                    lblMensajeError.Hide();
                }
                else if (verif == false)
                {
                    lblMensajeError.Show();
                    lblMensajeError.Text = "Complete todos los campos";
                }
            }
        }

        private void btnModificarRJ_Click(object sender, EventArgs e)
        {
            Verificaciones verificaciones = new Verificaciones();
            bool verif = verificaciones.VerificacionCrearUsuario(txtNombre.Text, txtApellido.Text, txtDNI.Text, txtCorreo.Text, txtDireccion.Text, txtTelefono.Text, "a", "a");
            if (verif == true)
            {
                ModificarUsuario();
                lblMensajeError.Hide();
                MessageBox.Show("Usuario modificado");
            }
            else
            {
                lblMensajeError.Show();
                lblMensajeError.Text = "Complete todos los campos";
            }
        }

        private void btnEliminarRJ_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow == null)
            {
                lblMensajeError.Show();
                lblMensajeError.Text = "Seleccione un usuario";
            }
            else
            {
                if (MessageBox.Show("¿Está seguro que desea eliminar el usuario?", "Atención", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    EliminarUsuario();
                    lblMensajeError.Hide();
                    MessageBox.Show("Usuario eliminado");
                }
            }
        }

        private void cmbRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbRol.SelectedItem.ToString() == "Cliente")
            {
                txtUsuario.Text = "";
                txtPassword.Text = "";
                txtUsuario.Enabled = false;
                txtPassword.Enabled = false;
            }
            else
            {
                txtUsuario.Enabled = true;
                txtPassword.Enabled = true;
            }
        }
    }
}
