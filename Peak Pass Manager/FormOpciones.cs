using Comun.Cache;
using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Peak_Pass_Manager
{
    public partial class FormOpciones : Form
    {
        private IControladoraBackup controladoraConAuditoria;
        ControladoraPermisos controladoraPermisos = new ControladoraPermisos();
        public FormOpciones()
        {
            Inicio();
        }
        private void Inicio()
        {
            InitializeComponent();
            LlenarRoles();
            LlenarCheckBoxes();
            //Agrega al combobox los nombrede los roles con la funcion ObtenerRoles de la controladoraPermisos
            if (controladoraPermisos.EditarPermisos() == false)
            {
                gboxPermisos.Enabled = false;

            }
            //Singleton
            IControladoraBackup controladoraBackup = ControladoraBackup.Instance;
            controladoraConAuditoria = new ControladoraBackupConAuditoria(controladoraBackup);
            LoadBackups();
            VerificarPermisos();
        }

        private void VerificarPermisos()
        {
            if (controladoraPermisos.EditarPermisos() == false)
            {
                gboxPermisos.Enabled = false;
            }
            else
            {
                gboxPermisos.Enabled = true;
            }
            if (controladoraPermisos.AgregarRoles() == false)
            {
                gboxRolesInactivos.Enabled = false;
                gboxRoles.Enabled = false;
            }
            else
            {
                gboxRolesInactivos.Enabled = true;
                gboxRoles.Enabled = true;
            }
            if(controladoraPermisos.EliminarRoles() == false)
            {
                btnEliminarRol.Enabled = false;
            }
            else
            {
                btnEliminarRol.Enabled = true;
            }
        }

        private void LoadBackups()
        {
            try
            {
                DataTable backupsTable = controladoraConAuditoria.GetAvailableBackups();
                dgvBackups.DataSource = backupsTable;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void LlenarCheckBoxes()
        {
            try
            {
                controladoraPermisos.LlenarPermisos(controladoraPermisos.ObtenerIdRol(cmbRol.Text));
                chkAgClientes.Checked = ControladoraPermisos.AgregarClientesSeleccion;
                chkAgUsuarios.Checked = ControladoraPermisos.AgregarUsuariosSeleccion;
                chkAuditoria.Checked = ControladoraPermisos.AuditoriaSeleccion;
                chkCatalogo.Checked = ControladoraPermisos.CatalogoSeleccion;
                chkClientes.Checked = ControladoraPermisos.ClientesSeleccion;
                chkEdCatalogos.Checked = ControladoraPermisos.EditarCatalogosSeleccion;
                chkEdPermisos.Checked = ControladoraPermisos.EditarPermisosSeleccion;
                chkEdProductos.Checked = ControladoraPermisos.EditarProductosSeleccion;
                chkEliClientes.Checked = ControladoraPermisos.EliminarClientesSeleccion;
                chkEliUsuarios.Checked = ControladoraPermisos.EliminarUsuariosSeleccion;
                chkModClientes.Checked = ControladoraPermisos.ModificarClientesSeleccion;
                chkModUsuarios.Checked = ControladoraPermisos.ModificarUsuariosSeleccion;
                chkOpciones.Checked = ControladoraPermisos.OpcionesSeleccion;
                chkPedidos.Checked = ControladoraPermisos.PedidosSeleccion;
                chkReportes.Checked = ControladoraPermisos.ReportesSeleccion;
                chkUsuarios.Checked = ControladoraPermisos.UsuariosSeleccion;
                chkAgregarRol.Checked = ControladoraPermisos.AgregarRolesSeleccion;
                chkEliminarRol.Checked = ControladoraPermisos.EliminarRolesSeleccion;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void LlenarRoles()
        {
            try
            {
                cmbRol.Items.Clear();
                List<string> roles = controladoraPermisos.ObtenerRolesActivos();
                foreach (string rol in roles)
                {
                    cmbRol.Items.Add(rol);
                }
                cmbRol.SelectedIndex = 0;
                cmbRolInactivo.Items.Clear();
                List<string> rolesInactivos = controladoraPermisos.ObtenerRolesInactivos();
                foreach (string rol in rolesInactivos)
                {
                    cmbRolInactivo.Items.Add(rol);
                }
                if (cmbRolInactivo.Items.Count == 0)
                {
                    cmbRolInactivo.Enabled = false;
                    btnHabilitarRol.Enabled = false;
                }
                else
                {
                    cmbRolInactivo.Enabled = true;
                    btnHabilitarRol.Enabled = true;
                    cmbRolInactivo.SelectedIndex = 0;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Metodo para pasar una lista de permisos a la controladoraPermisos
        public List<int> ObtenerPermisos()
        {
            List<int> permisos = new List<int>();
            if (chkCatalogo.Checked == true)
            {
                permisos.Add(1);
            }
            if (chkClientes.Checked == true)
            {
                permisos.Add(2);
            }
            if (chkOpciones.Checked == true)
            {
                permisos.Add(3);
            }
            if (chkPedidos.Checked == true)
            {
                permisos.Add(4);
            }
            if (chkUsuarios.Checked == true)
            {
                permisos.Add(5);
            }
            if (chkEdPermisos.Checked == true)
            {
                permisos.Add(6);
            }
            if (chkEdCatalogos.Checked == true)
            {
                permisos.Add(7);
            }
            if (chkEdProductos.Checked == true)
            {
                permisos.Add(8);
            }
            if (chkReportes.Checked == true)
            {
                permisos.Add(9);
            }
            if (chkAuditoria.Checked == true)
            {
                permisos.Add(10);
            }
            if (chkAgClientes.Checked == true)
            {
                permisos.Add(11);
            }
            if (chkModClientes.Checked == true)
            {
                permisos.Add(12);
            }
            if (chkEliClientes.Checked == true)
            {
                permisos.Add(13);
            }
            if (chkAgUsuarios.Checked == true)
            {
                permisos.Add(14);
            }
            if (chkModUsuarios.Checked == true)
            {
                permisos.Add(15);
            }
            if (chkEliUsuarios.Checked == true)
            {
                permisos.Add(16);
            }
            if (chkAgregarRol.Checked == true)
            {
                permisos.Add(17);
            }
            if (chkEliminarRol.Checked == true)
            {
                permisos.Add(18);
            }
            return permisos;
        }

        private void cmbRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRol.Text == "Administrador" || cmbRol.Text == "Cliente")
            {
                CambiarPermisosClickeables(false);
            }
            else
            {
                CambiarPermisosClickeables(true);
            }
            LlenarCheckBoxes();
        }

        public void CambiarPermisosClickeables(bool permiso)
        {
            chkCatalogo.Enabled = permiso;
            chkClientes.Enabled = permiso;
            chkOpciones.Enabled = permiso;
            chkPedidos.Enabled = permiso;
            chkUsuarios.Enabled = permiso;
            chkEdPermisos.Enabled = permiso;
            chkEdCatalogos.Enabled = permiso;
            chkEdProductos.Enabled = permiso;
            chkReportes.Enabled = permiso;
            chkAuditoria.Enabled = permiso;
            chkAgClientes.Enabled = permiso;
            chkModClientes.Enabled = permiso;
            chkEliClientes.Enabled = permiso;
            chkAgUsuarios.Enabled = permiso;
            chkModUsuarios.Enabled = permiso;
            chkEliUsuarios.Enabled = permiso;
            chkAgregarRol.Enabled = permiso;
            chkEliminarRol.Enabled = permiso;
            btnGuardarCambios.Enabled = permiso;
            btnEliminarRol.Enabled = permiso;
        }

        private void btnAgregarRol_Click(object sender, EventArgs e)
        {
            bool existe = controladoraPermisos.AgregarRol(txtRol.Text);
            if (existe == true)
            {
                MessageBox.Show("El rol ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Rol agregado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LlenarRoles();
                txtRol.Text = "";
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (dgvBackups.CurrentRow != null && dgvBackups.CurrentRow.Cells["BackupPath"].Value != null)
            {
                string backupFilePath = dgvBackups.CurrentRow.Cells["BackupPath"].Value.ToString();
                try
                {
                    controladoraConAuditoria.PerformRestore(backupFilePath);
                    MessageBox.Show("Restore realizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadBackups();
                    VerificarPermisos();
                    Inicio();
                }
                catch (ApplicationException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un backup para restaurar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            try
            {
                controladoraConAuditoria.PerformBackup();
                MessageBox.Show("Backup realizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadBackups();
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregarRol_Click_1(object sender, EventArgs e)
        {
            bool existe = controladoraPermisos.AgregarRol(txtRol.Text);
            if (existe == true)
            {
                MessageBox.Show("El rol ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Rol agregado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LlenarRoles();
                txtRol.Text = "";
            }
        }

        private void btnHabilitarRol_Click_1(object sender, EventArgs e)
        {
            controladoraPermisos.HabilitarRol(controladoraPermisos.ObtenerIdRol(cmbRolInactivo.Text));
            LlenarRoles();
            MessageBox.Show("Rol habilitado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEliminarRol_Click_1(object sender, EventArgs e)
        {
            if (cmbRol.Text == "Administrador")
            {
                MessageBox.Show("No se puede eliminar el rol de Administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (cmbRol.Text == "Cliente")
            {
                MessageBox.Show("No se puede eliminar el rol de Cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (cmbRol.Text == "Vendedor")
            {
                MessageBox.Show("No se puede eliminar el rol de Vendedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                int idRol = controladoraPermisos.ObtenerIdRol(cmbRol.Text);
                bool existenUsuarios = controladoraPermisos.EliminarRol(idRol);
                if (existenUsuarios == true)
                {
                    var m = MessageBox.Show("El rol que desea eliminar tiene usuarios asociados. Desea deshabilitar el Rol junto a los usuarios asociados?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (m == DialogResult.Yes && CacheUsuario.idRol != idRol)
                    {
                        controladoraPermisos.DeshabilitarRol(idRol);
                        MessageBox.Show("El rol fue deshabilitado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LlenarRoles();
                    }
                    else if (m == DialogResult.Yes && CacheUsuario.idRol == idRol)
                    {
                        MessageBox.Show("No se puede deshabilitar el rol con el que se encuentra logueado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("El rol no fue eliminado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("El rol fue eliminado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LlenarRoles();
                }
            }
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            controladoraPermisos.ModificarPermisos(controladoraPermisos.ObtenerIdRol(cmbRol.Text), ObtenerPermisos());
            VerificarPermisos();
            MessageBox.Show("Permisos modificados con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
