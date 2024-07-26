using Acceso_a_Datos;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace Acceso_a_Datos
{
    public class ModeloBackup : ConexionSQL1
    {
        private readonly string backupFolder = "C:\\Users\\Public\\Documents\\";

        // Backup de la base de datos 'PeakPassManager' con la fecha y hora actual
        public void Backup()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string backupFileName = $"{backupFolder}PeakPassManager_{DateTime.Now:yyyy-MM-dd_HH-mm-ss}.bak";
                string query = $"BACKUP DATABASE PeakPassManager TO DISK = '{backupFileName}'";

                using (var command = new SqlCommand(query, connection))
                {
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }
            }
        }

        // Restore de la base de datos 'PeakPassManager' desde un archivo especificado
        public void Restore(string backupFilePath)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string useMasterQuery = "USE master";
                string alter1Query = "ALTER DATABASE PeakPassManager SET SINGLE_USER WITH ROLLBACK IMMEDIATE";
                string restoreQuery = $"RESTORE DATABASE PeakPassManager FROM DISK = '{backupFilePath}' WITH REPLACE";
                string alter2Query = "ALTER DATABASE PeakPassManager SET MULTI_USER";

                using (var command = new SqlCommand(useMasterQuery, connection))
                {
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }

                using (var command = new SqlCommand(alter1Query, connection))
                {
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }

                using (var command = new SqlCommand(restoreQuery, connection))
                {
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }

                using (var command = new SqlCommand(alter2Query, connection))
                {
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }
            }
        }

        // Obtener lista de backups disponibles en un DataTable
        public DataTable GetAvailableBackups()
        {
            DataTable backupsTable = new DataTable();
            backupsTable.Columns.Add("BackupName", typeof(string));
            backupsTable.Columns.Add("BackupPath", typeof(string));
            backupsTable.Columns.Add("CreationTime", typeof(DateTime));

            DirectoryInfo di = new DirectoryInfo(backupFolder);
            FileInfo[] files = di.GetFiles("PeakPassManager_*.bak");

            foreach (FileInfo file in files)
            {
                DataRow row = backupsTable.NewRow();
                row["BackupName"] = file.Name;
                row["BackupPath"] = file.FullName;
                row["CreationTime"] = file.CreationTime;
                backupsTable.Rows.Add(row);
            }

            return backupsTable;
        }
    }
}
