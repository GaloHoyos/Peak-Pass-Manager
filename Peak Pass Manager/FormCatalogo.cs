using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Comun.Cache;
using Dominio;
using System.Linq;
using System.Runtime.InteropServices;
using Peak_Pass_Manager;

namespace Peak_Pass_Manager
{
    public partial class FormCatalogo : Form
    {
        public static Form formActual;
        int cantidad = 1;
        int idCliente = -1;
        ControladoraCarrito carrito = new ControladoraCarrito(CacheCliente.IdCliente, 0);
        public FormCatalogo()
        {
            InitializeComponent();
            NombreCliente();
            ActualizarLista();
            lblDescripcion.MaximumSize = new Size(450, 0);
            lblDescripcion.AutoSize = true;
            dgvCarrito.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvCarrito.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

        }

        //metodo para mostrar el nombre del cliente en el label
        public void NombreCliente()
        {
            lblCliente.Text = CacheCliente.Nombre + " " + CacheCliente.Apellido;
            idCliente = CacheCliente.IdCliente;
        }

        //metodo para actualizar la lista de productos
        public void ActualizarLista()
        {
            //Agregar columnas vacias al dgv
            dgvProductos.Columns.Clear();
            dgvProductos.Columns.Add("ID", "ID");
            dgvProductos.Columns[0].DataPropertyName = "id_producto";
            dgvProductos.Columns.Add("Nombre", "Nombre");
            dgvProductos.Columns[1].DataPropertyName = "nombre_producto";
            dgvProductos.Columns.Add("Precio", "Precio");
            dgvProductos.Columns[2].DataPropertyName = "precio_producto";
            dgvProductos.Columns.Add("Catalogo", "Catalogo");
            dgvProductos.Columns[3].DataPropertyName = "nombre_catalogo";
            ControladoraProducto modeloProducto = new ControladoraProducto();
            dgvProductos.DataSource = modeloProducto.ActualizarLista();
        }
        public string ObtenerDescripcion(int id)
        {
            ControladoraProducto controladoraProducto = new ControladoraProducto();
            return controladoraProducto.VerDescripcion(id);
        }

        public void IniciarCarrito(ControladoraCarrito carrito)
        {
            dgvCarrito.DataSource = carrito.ObtenerLista();
            lblTotal.Text = "Total: $" + carrito.ObtenerTotal();
        }

        private void btnCambioCliente_Click(object sender, EventArgs e)
        {
            FormClientes formClientes = new FormClientes();
            formClientes.ShowDialog();
            NombreCliente();
        }

        private void btnPago_Click(object sender, EventArgs e)
        {
            //verificacion para saber si hay cliente seleccionado
            if (idCliente > 0)
            {
                //verificacion para saber si hay productos en el carrito
                if (carrito.ObtenerLista().Rows.Count > 0)
                {
                    FormPago formPago = new FormPago(carrito);
                    formPago.Show();
                }
                else
                {
                    MessageBox.Show("No hay productos en el carrito");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un cliente");
            }
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblDescripcion.Text = "Descripcion del producto: " + ObtenerDescripcion(Convert.ToInt32(dgvProductos.CurrentRow.Cells[0].Value));
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            //verificacion para saber si hay productos seleccionados en el carrito
            if (dgvCarrito.CurrentRow != null)
            {
                carrito.EliminarProducto(Convert.ToInt32(dgvCarrito.CurrentRow.Cells[2].Value));
                IniciarCarrito(carrito);
            }
            else
            {
                MessageBox.Show("No hay productos seleccionados en el carrito");
            }
        }

        private void btnQuitarCantidad_Click(object sender, EventArgs e)
        {
            if (dgvCarrito.CurrentRow != null)
            {
                if (Convert.ToInt32(dgvCarrito.CurrentRow.Cells[5].Value) == 1)
                {
                    carrito.EliminarProducto(Convert.ToInt32(dgvCarrito.CurrentRow.Cells[2].Value));
                    IniciarCarrito(carrito);
                }
                else
                {
                    carrito.QuitarCantidad(Convert.ToInt32(dgvCarrito.CurrentRow.Cells[2].Value), 1);
                    IniciarCarrito(carrito);
                }
            }
            else
            {
                MessageBox.Show("No hay productos seleccionados en el carrito");
            }
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            if (idCliente > 0)
            {
                if (Convert.ToInt32(dgvProductos.CurrentRow.Cells[0].Value) > 0)
                {
                    int precioProducto = Convert.ToInt32(dgvProductos.CurrentRow.Cells[2].Value);
                    int idProducto = Convert.ToInt32(dgvProductos.CurrentRow.Cells[0].Value);
                    string nombreProducto = dgvProductos.CurrentRow.Cells[1].Value.ToString();
                    bool existencia = carrito.ExisteProducto(idProducto, idCliente);
                    if (existencia == true)
                    {
                        carrito.AgregarCantidad(idProducto, 1);
                        IniciarCarrito(carrito);
                    }
                    else
                    {
                        ControladoraCarritoDetalle controladoraCarritoDetalle = new ControladoraCarritoDetalle(idCliente, idProducto, nombreProducto, precioProducto, cantidad, cantidad * precioProducto);
                        carrito.AgregarProducto(controladoraCarritoDetalle.ObtenerModelo(), idCliente);
                        dgvCarrito.DataSource = carrito.ObtenerLista();
                    }

                }
                else
                {
                    MessageBox.Show("Debe seleccionar un producto");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un cliente");
            }
        }
    }
}
