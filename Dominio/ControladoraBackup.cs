using System;
using System.Data;

namespace Dominio
{
    public class ControladoraBackup
    {
        private static ControladoraBackup _instance;
        private static readonly object _lock = new object();
        private ModeloBackup modeloBackup;

        private ControladoraBackup()
        {
            modeloBackup = new ModeloBackup();
        }

        // Singleton
        public static ControladoraBackup Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new ControladoraBackup();
                    }
                }
                return _instance;
            }
        }

        // Método para realizar un backup
        public void PerformBackup()
        {
            try
            {
                modeloBackup.Backup();
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Error al realizar el backup: {ex.Message}", ex);
            }
        }

        // Método para realizar un restore
        public void PerformRestore(string backupFilePath)
        {
            try
            {
                modeloBackup.Restore(backupFilePath);
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Error al realizar el restore: {ex.Message}", ex);
            }
        }

        // Método para obtener los backups disponibles
        public DataTable GetAvailableBackups()
        {
            try
            {
                return modeloBackup.GetAvailableBackups();
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Error al obtener la lista de backups: {ex.Message}", ex);
            }
        }
    }
}
