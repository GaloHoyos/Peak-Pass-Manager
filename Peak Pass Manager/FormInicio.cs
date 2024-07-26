using Comun.Cache;
using Dominio;
using System;
using System.Data;
using System.Windows.Forms;

namespace Peak_Pass_Manager
{
    public partial class FormInicio : Form
    {
        private IControladoraBackup controladoraConAuditoria;

        public FormInicio()
        {
            InitializeComponent();
            //Singleton
            IControladoraBackup controladoraBackup = ControladoraBackup.Instance;
            controladoraConAuditoria = new ControladoraBackupConAuditoria(controladoraBackup);
            LoadBackups();
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
