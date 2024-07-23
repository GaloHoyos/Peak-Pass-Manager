using Comun.Cache;
using Dominio;
using System;
using System.Data;
using System.Windows.Forms;

namespace Peak_Pass_Manager
{
    public partial class FormInicio : Form
    {
        private ControladoraBackup controladoraBackup;
        private ControladoraAuditoria auditoria;

        public FormInicio()
        {
            InitializeComponent();
            //Singleton
            controladoraBackup = ControladoraBackup.Instance;
            auditoria = new ControladoraAuditoria();
            LoadBackups();
        }

        private void LoadBackups()
        {
            try
            {
                DataTable backupsTable = controladoraBackup.GetAvailableBackups();
                dgvBackups.DataSource = backupsTable;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            try
            {
                controladoraBackup.PerformBackup();
                MessageBox.Show("Backup realizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadBackups();
                auditoria.InsertarAuditoria(CacheUsuario.IdUsuario, "Backup", "Se realizó un backup de la base de datos.");
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (dgvBackups.CurrentRow != null && dgvBackups.CurrentRow.Cells["BackupPath"].Value != null)
            {
                string backupFilePath = dgvBackups.CurrentRow.Cells["BackupPath"].Value.ToString();
                try
                {
                    controladoraBackup.PerformRestore(backupFilePath);
                    MessageBox.Show("Restore realizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadBackups();
                    auditoria.InsertarAuditoria(CacheUsuario.IdUsuario, "Restore", "Se realizó un restore de la base de datos.");
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
    }
}
