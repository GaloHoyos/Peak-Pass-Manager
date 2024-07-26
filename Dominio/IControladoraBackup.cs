using System.Data;


namespace Dominio
{
    public interface IControladoraBackup
    {
        void PerformBackup();
        void PerformRestore(string backupFilePath);
        DataTable GetAvailableBackups();
    }

}
