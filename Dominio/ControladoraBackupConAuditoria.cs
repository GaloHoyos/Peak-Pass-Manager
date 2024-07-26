using Comun.Cache;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
public class ControladoraBackupConAuditoria : IControladoraBackup
{
    private readonly IControladoraBackup _controladoraBackup;
    private readonly ControladoraAuditoria _auditoria;

    public ControladoraBackupConAuditoria(IControladoraBackup controladoraBackup)
    {
        _controladoraBackup = controladoraBackup;
        _auditoria = new ControladoraAuditoria();
    }

    public void PerformBackup()
    {
        _controladoraBackup.PerformBackup();
        _auditoria.InsertarAuditoria(CacheUsuario.IdUsuario, "Backup", "Se realizó un backup de la base de datos.");
    }

    public void PerformRestore(string backupFilePath)
    {
        _controladoraBackup.PerformRestore(backupFilePath);
        _auditoria.InsertarAuditoria(CacheUsuario.IdUsuario, "Restore", "Se realizó un restore de la base de datos.");
    }

    public DataTable GetAvailableBackups()
    {
        return _controladoraBackup.GetAvailableBackups();
    }
}

}
