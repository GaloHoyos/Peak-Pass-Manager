using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acceso_a_Datos;
using System.Data;

namespace Dominio 
{
    public class ControladoraAuditoria
    {
        ModeloAuditoria modeloAuditoria = new ModeloAuditoria();
        public void InsertarAuditoria(int idUsuario, string accion, string descripcion)
        {
            modeloAuditoria.InsertarAuditoria(idUsuario, accion, descripcion);
        }
        public DataTable ObtenerAuditoria()
        {
            return modeloAuditoria.ObtenerAuditoria();
        }
    }
}