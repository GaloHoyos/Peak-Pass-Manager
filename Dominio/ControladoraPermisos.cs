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
    }
}
