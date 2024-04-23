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
        ControladoraPermisos controladoraPermisos = new ControladoraPermisos();
        public FormOpciones()
        {
            InitializeComponent();
            LlenarRoles();
            LlenarCheckBoxes();
            //Agrega al combobox los nombrede los roles con la funcion ObtenerRoles de la controladoraPermisos
            if (controladoraPermisos.EditarPermisos() == false)
            {
                gboxPermisos.Enabled = false;
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
                List<string> roles = controladoraPermisos.ObtenerRoles();
                foreach (string rol in roles)
                {
                    cmbRol.Items.Add(rol);
                }
                cmbRol.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            controladoraPermisos.ModificarPermisos(controladoraPermisos.ObtenerIdRol(cmbRol.Text), ObtenerPermisos());
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
            btnGuardar.Enabled = permiso;
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

        private void btnEliminarRol_Click(object sender, EventArgs e)
        {
            if (cmbRol.Text == "Administrador")
            {
                MessageBox.Show("No se puede eliminar el rol de Administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (cmbRol.Text == "Cliente")
            {
                MessageBox.Show("No se puede eliminar el rol de Cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                int idRol = controladoraPermisos.ObtenerIdRol(cmbRol.Text);
                bool existenUsuarios = controladoraPermisos.EliminarRol(idRol);
                if (existenUsuarios == true)
                {
                    MessageBox.Show("El rol que desea eliminar tiene usuarios asociados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El rol fue eliminado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LlenarRoles();
                }
            }
        }
    }
}
