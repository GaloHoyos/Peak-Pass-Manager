using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            cmbRol.Items.Add("Administrador");
            cmbRol.Items.Add("Vendedor");
            cmbRol.SelectedIndex = 0;
            if (controladoraPermisos.EditarPermisos()== false)
            {
                gboxPermisos.Enabled = false;
            }
        }
        public void Inicializar()
        {
            switch (cmbRol.SelectedIndex)
            {
                case 0:
                    ControladoraPermisos controladoraPermisos = new ControladoraPermisos();
                    chkCatalogo.Checked = controladoraPermisos.VerPermisos(1, 1);
                    chkClientes.Checked = controladoraPermisos.VerPermisos(1, 2);
                    chkOpciones.Checked = controladoraPermisos.VerPermisos(1, 3);
                    chkPedidos.Checked = controladoraPermisos.VerPermisos(1, 4);
                    chkUsuarios.Checked = controladoraPermisos.VerPermisos(1, 5);
                    chkEdPermisos.Checked = controladoraPermisos.VerPermisos(1, 6);
                    chkEdCatalogos.Checked = controladoraPermisos.VerPermisos(1, 7);
                    chkEdProductos.Checked = controladoraPermisos.VerPermisos(1, 8);
                    chkReportes.Checked = controladoraPermisos.VerPermisos(1, 9);
                    chkAuditoria.Checked = controladoraPermisos.VerPermisos(1, 10);
                    chkAgClientes.Checked = controladoraPermisos.VerPermisos(1, 11);
                    chkModClientes.Checked = controladoraPermisos.VerPermisos(1, 12);
                    chkEliClientes.Checked = controladoraPermisos.VerPermisos(1, 13);
                    chkAgUsuarios.Checked = controladoraPermisos.VerPermisos(1, 14);
                    chkModUsuarios.Checked = controladoraPermisos.VerPermisos(1, 15);
                    chkEliUsuarios.Checked = controladoraPermisos.VerPermisos(1, 16);
                    break;
                case 1:
                    ControladoraPermisos controladoraPermisos2 = new ControladoraPermisos();
                    chkCatalogo.Checked = controladoraPermisos2.VerPermisos(2, 1);
                    chkClientes.Checked = controladoraPermisos2.VerPermisos(2, 2);
                    chkOpciones.Checked = controladoraPermisos2.VerPermisos(2, 3);
                    chkPedidos.Checked = controladoraPermisos2.VerPermisos(2, 4);
                    chkUsuarios.Checked = controladoraPermisos2.VerPermisos(2, 5);
                    chkEdPermisos.Checked = controladoraPermisos2.VerPermisos(2, 6);
                    chkEdCatalogos.Checked = controladoraPermisos2.VerPermisos(2, 7);
                    chkEdProductos.Checked = controladoraPermisos2.VerPermisos(2, 8);
                    chkReportes.Checked = controladoraPermisos2.VerPermisos(2, 9);
                    chkAuditoria.Checked = controladoraPermisos2.VerPermisos(2, 10);
                    chkAgClientes.Checked = controladoraPermisos2.VerPermisos(2, 11);
                    chkModClientes.Checked = controladoraPermisos2.VerPermisos(2, 12);
                    chkEliClientes.Checked = controladoraPermisos2.VerPermisos(2, 13);
                    chkAgUsuarios.Checked = controladoraPermisos2.VerPermisos(2, 14);
                    chkModUsuarios.Checked = controladoraPermisos2.VerPermisos(2, 15);
                    chkEliUsuarios.Checked = controladoraPermisos2.VerPermisos(2, 16);
                    break;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            switch (cmbRol.SelectedIndex)
            {
                case 0:
                    Selecciones(1);
                    break;
                case 1:
                    Selecciones(2);
                    break;
            }
            //Recarga el Menu Principal
        }
        public void Selecciones(int idRol)
        {
            ControladoraPermisos controladoraPermisos = new ControladoraPermisos();
            switch (chkCatalogo.Checked)
            {
                case true:
                    controladoraPermisos.AgregarPermisos(idRol, 1);
                    break;
                case false:
                    controladoraPermisos.EliminarPermisos(idRol, 1);
                    break;
            }
            switch (chkClientes.Checked)
            {
                case true:
                    controladoraPermisos.AgregarPermisos(idRol, 2);
                    break;
                case false:
                    controladoraPermisos.EliminarPermisos(idRol, 2);
                    break;
            }
            switch (chkOpciones.Checked)
            {
                case true:
                    controladoraPermisos.AgregarPermisos(idRol, 3);
                    break;
                case false:
                    controladoraPermisos.EliminarPermisos(idRol, 3);
                    break;
            }
            switch (chkPedidos.Checked)
            {
                case true:
                    controladoraPermisos.AgregarPermisos(idRol, 4);
                    break;
                case false:
                    controladoraPermisos.EliminarPermisos(idRol, 4);
                    break;
            }
            switch (chkUsuarios.Checked)
            {
                case true:
                    controladoraPermisos.AgregarPermisos(idRol, 5);
                    break;
                case false:
                    controladoraPermisos.EliminarPermisos(idRol, 5);
                    break;
            }
            switch (chkEdPermisos.Checked)
            {
                case true:
                    controladoraPermisos.AgregarPermisos(idRol, 6);
                    break;
                case false:
                    controladoraPermisos.EliminarPermisos(idRol, 6);
                    break;
            }
            switch (chkEdCatalogos.Checked)
            {
                case true:
                    controladoraPermisos.AgregarPermisos(idRol, 7);
                    break;
                case false:
                    controladoraPermisos.EliminarPermisos(idRol, 7);
                    break;
            }
            switch (chkEdProductos.Checked)
            {
                case true:
                    controladoraPermisos.AgregarPermisos(idRol, 8);
                    break;
                case false:
                    controladoraPermisos.EliminarPermisos(idRol, 8);
                    break;
            }
            switch (chkReportes.Checked)
            {
                case true:
                    controladoraPermisos.AgregarPermisos(idRol, 9);
                    break;
                case false:
                    controladoraPermisos.EliminarPermisos(idRol, 9);
                    break;
            }
            switch (chkAuditoria.Checked)
            {
                case true:
                    controladoraPermisos.AgregarPermisos(idRol, 10);
                    break;
                case false:
                    controladoraPermisos.EliminarPermisos(idRol, 10);
                    break;
            }
            switch (chkAgClientes.Checked)
            {
                case true:
                    controladoraPermisos.AgregarPermisos(idRol, 11);
                    break;
                case false:
                    controladoraPermisos.EliminarPermisos(idRol, 11);
                    break;
            }
            switch (chkModClientes.Checked)
            {
                case true:
                    controladoraPermisos.AgregarPermisos(idRol, 12);
                    break;
                case false:
                    controladoraPermisos.EliminarPermisos(idRol, 12);
                    break;
            }
            switch (chkEliClientes.Checked)
            {
                case true:
                    controladoraPermisos.AgregarPermisos(idRol, 13);
                    break;
                case false:
                    controladoraPermisos.EliminarPermisos(idRol, 13);
                    break;
            }
            switch (chkAgUsuarios.Checked)
            {
                case true:
                    controladoraPermisos.AgregarPermisos(idRol, 14);
                    break;
                case false:
                    controladoraPermisos.EliminarPermisos(idRol, 14);
                    break;
            }
            switch (chkModUsuarios.Checked)
            {
                case true:
                    controladoraPermisos.AgregarPermisos(idRol, 15);
                    break;
                case false:
                    controladoraPermisos.EliminarPermisos(idRol, 15);
                    break;
            }
            switch (chkEliUsuarios.Checked)
            {
                case true:
                    controladoraPermisos.AgregarPermisos(idRol, 16);
                    break;
                case false:
                    controladoraPermisos.EliminarPermisos(idRol, 16);
                    break;
            }
        }

        private void cmbRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            Inicializar();
        }
    }
}
