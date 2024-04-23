
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Comun.Cache;
using Comun;

namespace Peak_Pass_Manager
{
    public partial class FormClientes : Form
    {
        ControladoraUsuario cliente = new ControladoraUsuario();
        public FormClientes()
        {
            InitializeComponent();
            iniciar();

        }
        public void iniciar()
        {
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtDNI.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            lblCliente.Text = cliente.ObtenerNombre() + " " + cliente.ObtenerApellido();
            ActualizarClientes();
        }
        public void ActualizarClientes()
        {
            dgvClientes.DataSource = cliente.ActualizarClientes();
            dgvClientes.Columns.Clear();
            dgvClientes.Columns.Add("ID", "ID");
            dgvClientes.Columns[0].DataPropertyName = "id_usuario";
            dgvClientes.Columns.Add("Nombre", "Nombre");
            dgvClientes.Columns[1].DataPropertyName = "nombre";
            dgvClientes.Columns.Add("Apellido", "Apellido");
            dgvClientes.Columns[2].DataPropertyName = "apellido";
            dgvClientes.Columns.Add("DNI", "DNI");
            dgvClientes.Columns[3].DataPropertyName = "dni";
            dgvClientes.Columns.Add("Correo", "Correo");
            dgvClientes.Columns[4].DataPropertyName = "correo";
            dgvClientes.Columns.Add("Direccion", "Direccion");
            dgvClientes.Columns[5].DataPropertyName = "direccion";
            dgvClientes.Columns.Add("Telefono", "Telefono");
            dgvClientes.Columns[6].DataPropertyName = "telefono";
            dgvClientes.Columns.Add("Rol", "Rol");
            dgvClientes.Columns[7].DataPropertyName = "nombre_rol";
        }

        public void AgregarCliente()
        {
            ControladoraUsuario cliente = new ControladoraUsuario();
            switch (cliente.AgregarUsuario(1,txtNombre.Text, txtApellido.Text, txtDNI.Text, txtCorreo.Text, txtDireccion.Text, txtTelefono.Text, "", "", 3))
            {
                case "No Existente":
                    MessageBox.Show("Cliente Agregado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Usuario Existente":
                    MessageBox.Show("Usuario Existente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case "Inactivo y Existente":
                    var m = MessageBox.Show("Usuario Existente pero inactivo. Desea reactivarlo?", "Error", MessageBoxButtons.YesNo);
                    if (m == DialogResult.Yes)
                    {
                        cliente.ActivarUsuario(cliente.ObtenerIdPorDNI(txtDNI.Text));
                    }
                    break;
            }
            iniciar();
        }
        public void ModificarCliente()
        {
            ControladoraUsuario cliente = new ControladoraUsuario();
            if (dgvClientes.CurrentRow.Cells[7].Value.ToString() == "Cliente")
            {
                if (txtDNI.Text == cliente.ObtenerDNI(Convert.ToInt32(dgvClientes.CurrentRow.Cells[0].Value)))
                {
                    cliente.ModifcarUsuario(Convert.ToInt32(dgvClientes.CurrentRow.Cells[0].Value), txtNombre.Text, txtApellido.Text, txtDNI.Text, txtCorreo.Text, txtDireccion.Text, txtTelefono.Text, "", "", 3);
                    iniciar();
                    LimpioCliente();
                }
                else
                {
                    if (cliente.ExisteDNI(txtDNI.Text))
                    {
                        MessageBox.Show("DNI Existente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        cliente.ModifcarUsuario(Convert.ToInt32(dgvClientes.CurrentRow.Cells[0].Value), txtNombre.Text, txtApellido.Text, txtDNI.Text, txtCorreo.Text, txtDireccion.Text, txtTelefono.Text, "", "", 3);
                        iniciar();
                        LimpioCliente();
                    }
                }
            }
            else
            {
                MessageBox.Show("No se puede modificar un usuario que no sea cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void EliminarCliente()
        {
            if (dgvClientes.CurrentRow == null)
            {
                lblMensajeError.Show();
                lblMensajeError.Text = "Seleccione un cliente";
            }
            else if (dgvClientes.CurrentRow.Cells[0].Value.ToString() == CacheUsuario.IdUsuario.ToString())
            {
                lblMensajeError.Show();
                lblMensajeError.Text = "No se puede eliminar el usuario logueado";
            }
            else if (dgvClientes.CurrentRow.Cells[7].Value.ToString() != "Cliente")
            {
                lblMensajeError.Show();
                lblMensajeError.Text = "No se puede eliminar un usuario que no sea cliente";
            }
            else
            {
                ControladoraUsuario cliente = new ControladoraUsuario();
                if (cliente.EliminarUsuario(Convert.ToInt32(dgvClientes.CurrentRow.Cells[0].Value)) == true)
                {
                    MessageBox.Show("No se puede eliminar el cliente porque tiene pedidos asociados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                iniciar();
                LimpioCliente();
                lblMensajeError.Hide();
                dgvClientes.ClearSelection();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Verificaciones verificaciones = new Verificaciones();
            bool verif = verificaciones.VerificacionCrearCliente(txtNombre.Text, txtApellido.Text, txtDNI.Text, txtCorreo.Text, txtDireccion.Text, txtTelefono.Text);
            if (verif == true)
            {
                AgregarCliente();
            }
            else
            {
                lblMensajeError.Show();
                lblMensajeError.Text = "Complete todos los campos";
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow == null)
            {
                lblMensajeError.Show();
                lblMensajeError.Text = "Seleccione un cliente";
            }   
            else
            {
                Verificaciones verificaciones = new Verificaciones();
                bool verif = verificaciones.VerificacionCrearCliente(txtNombre.Text, txtApellido.Text, txtDNI.Text, txtCorreo.Text, txtDireccion.Text, txtTelefono.Text);
                if (verif == true)
                {
                    ModificarCliente();
                    lblMensajeError.Hide();
                }
                else
                {
                    lblMensajeError.Show();
                    lblMensajeError.Text = "Complete todos los campos";
                }
            }
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombre.Text = dgvClientes.CurrentRow.Cells[1].Value.ToString();
            txtApellido.Text = dgvClientes.CurrentRow.Cells[2].Value.ToString();
            txtDNI.Text = dgvClientes.CurrentRow.Cells[3].Value.ToString();
            txtCorreo.Text = dgvClientes.CurrentRow.Cells[4].Value.ToString();
            txtDireccion.Text = dgvClientes.CurrentRow.Cells[5].Value.ToString();
            txtTelefono.Text = dgvClientes.CurrentRow.Cells[6].Value.ToString();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
                EliminarCliente();
        }

        private void btnCambioCliente_Click(object sender, EventArgs e)
        {
            if(dgvClientes.CurrentRow == null)
            {
                lblMensajeError.Show();
                lblMensajeError.Text = "Seleccione un cliente";
            }
            else
            {
                CambioCliente();
            }

        }
        public void CambioCliente()
        {
            lblMensajeError.Hide();
            CacheCliente.IdCliente = Convert.ToInt32(dgvClientes.CurrentRow.Cells[0].Value);
            CacheCliente.Nombre = dgvClientes.CurrentRow.Cells[1].Value.ToString();
            CacheCliente.Apellido = dgvClientes.CurrentRow.Cells[2].Value.ToString();
            CacheCliente.DNI = dgvClientes.CurrentRow.Cells[3].Value.ToString();
            CacheCliente.Correo = dgvClientes.CurrentRow.Cells[4].Value.ToString();
            CacheCliente.Direccion = dgvClientes.CurrentRow.Cells[5].Value.ToString();
            CacheCliente.Telefono = dgvClientes.CurrentRow.Cells[6].Value.ToString();
            lblCliente.Text = CacheCliente.Nombre + " " + CacheCliente.Apellido;
        }
        public void LimpioCliente()
        {
            CacheCliente.IdCliente = -1;
            CacheCliente.Nombre = string.Empty;
            CacheCliente.Apellido = string.Empty;
            CacheCliente.DNI = string.Empty;
            CacheCliente.Correo = string.Empty;
            CacheCliente.Direccion = string.Empty;
            CacheCliente.Telefono = string.Empty;
            lblCliente.Text = string.Empty;
        }
    }
}
