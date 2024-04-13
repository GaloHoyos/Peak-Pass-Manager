using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acceso_a_Datos;

namespace Dominio
{
    public class ControladoraPermisos
    {
        ModeloPermisos modeloPermisos = new ModeloPermisos();
        //obtener los permisos del usuario
        public bool Catalogo()
        {
            return ModeloPermisos.Catalogo;
        }
        public bool Clientes()
        {
            return ModeloPermisos.Clientes;
        }
        public bool Opciones()
        {
            return ModeloPermisos.Opciones;
        }
        public bool Pedidos()
        {
            return ModeloPermisos.Pedidos;
        }
        public bool Usuarios()
        {
            return ModeloPermisos.Usuarios;
        }
        public bool EditarPermisos()
        {
            return ModeloPermisos.EditarPermisos;
        }
        public bool EditarCatalogos()
        {
            return ModeloPermisos.EditarCatalogos;
        }
        public bool EditarProductos()
        {
            return ModeloPermisos.EditarProductos;
        }
        public bool Reportes()
        {
            return ModeloPermisos.Reportes;
        }
        public bool Auditoria()
        {
            return ModeloPermisos.Auditoria;
        }
        public bool AgregarClientes()
        {
            return ModeloPermisos.AgregarClientes;
        }
        public bool ModificarClientes()
        {
            return ModeloPermisos.ModificarClientes;
        }
        public bool EliminarClientes()
        {
            return ModeloPermisos.EliminarClientes;
        }
        public bool AgregarUsuarios()
        {
            return ModeloPermisos.AgregarUsuarios;
        }
        public bool ModificarUsuarios()
        {
            return ModeloPermisos.ModificarUsuarios;
        }
        public bool EliminarUsuarios()
        {
            return ModeloPermisos.EliminarUsuarios;
        }
        //Agregar permisos
        public void AgregarPermisos(int idRol, int idPermiso)
        {
            modeloPermisos.AgregarPermisos(idRol, idPermiso);
        }
        //Eliminar permisos
        public void EliminarPermisos(int idRol, int idPermiso)
        {
            modeloPermisos.EliminarPermisos(idRol, idPermiso);
        }
        //Ver permisos de un rol
        public bool VerPermisos(int idRol, int idPermiso)
        {
            return modeloPermisos.VerPermisos(idRol, idPermiso);
        }
    }
}
