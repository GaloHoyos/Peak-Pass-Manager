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

namespace Peak_Pass_Manager
{
    public partial class FormAuditoria : Form
    {
        public FormAuditoria()
        {
            InitializeComponent();
            ControladoraAuditoria controladoraAuditoria = new ControladoraAuditoria();
            dgvAuditoria.Columns.Clear();
            dgvAuditoria.Columns.Add("ID", "ID");
            dgvAuditoria.Columns[0].DataPropertyName = "id_auditoria";
            dgvAuditoria.Columns.Add("Usuario", "Usuario");
            dgvAuditoria.Columns[1].DataPropertyName = "id_usuario";
            dgvAuditoria.Columns.Add("Nombre", "Nombre");
            dgvAuditoria.Columns[2].DataPropertyName = "nombre";
            dgvAuditoria.Columns.Add("Accion", "Accion");
            dgvAuditoria.Columns[3].DataPropertyName = "accion";
            dgvAuditoria.Columns.Add("Descripcion", "Descripcion");
            dgvAuditoria.Columns[4].DataPropertyName = "descripcion";
            dgvAuditoria.Columns.Add("Fecha", "Fecha");
            dgvAuditoria.Columns[5].DataPropertyName = "fecha";
            dgvAuditoria.DataSource = controladoraAuditoria.ObtenerAuditoria();
        }
    }
}
