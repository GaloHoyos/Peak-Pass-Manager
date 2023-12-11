using Acceso_a_Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Dominio
{
    public class ControladoraCliente
    {
        Acceso_a_Datos.ModeloCliente clienteDao = new Acceso_a_Datos.ModeloCliente();
    
        public DataTable ActualizarLista()
        {
            DataTable dt = new DataTable();
            dt = clienteDao.ActualizarLista();
            return dt;
        }
        public void AgregarCliente(string nombre, string apellido, string dni, string correo, string direccion, string telefono)
        {
            clienteDao.AgregarCliente(nombre, apellido, dni, correo, direccion, telefono);
        }
        public void ModificarClienteSeleccionado(int id, string nombre, string apellido, string dni, string correo, string direccion, string telefono)
        {
            clienteDao.ModificarClienteSeleccionado(id, nombre, apellido, dni, correo, direccion, telefono);
        }
        public void EliminarCliente(int id)
        {
            clienteDao.EliminarCliente(id);
        }


    }
}
