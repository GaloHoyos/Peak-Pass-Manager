using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;

namespace Peak_Pass_Manager
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }

        private void txtContra_Enter(object sender, EventArgs e)
        {
            if (txtContra.Text == "CONTRASEÑA")
            {
                txtContra.Text = "";
                txtContra.ForeColor = Color.LightGray;
                txtContra.UseSystemPasswordChar = true;
            }
        }

        private void txtContra_Leave(object sender, EventArgs e)
        {
            if (txtContra.Text == "")
            {
                txtContra.Text = "CONTRASEÑA";
                txtContra.ForeColor = Color.DimGray;
                txtContra.UseSystemPasswordChar = false;
            }
        }

        private void iconCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconCerrar_MouseEnter(object sender, EventArgs e)
        {
            //cambiar color a claro
            iconCerrar.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void iconCerrar_MouseLeave(object sender, EventArgs e)
        {
            //cambiar color a oscuro nuevamente
            iconCerrar.ForeColor = Color.DimGray;
        }

        private void iconMinimizar_MouseEnter(object sender, EventArgs e)
        {
            //cambiar color a claro
            iconMinimizar.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void iconMinimizar_MouseLeave(object sender, EventArgs e)
        {
            //cambiar color a oscuro nuevamente
            iconMinimizar.ForeColor = Color.DimGray;
        }

        //arrastrar el formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg,
                       int wparam, int lparam);
        private void FormLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "USUARIO")
            {
                if(txtContra.Text != "CONTRASEÑA")
                {
                    ControladoraUsuario modeloUsuario = new ControladoraUsuario();
                    var loginValido = modeloUsuario.LoginUser(txtUsuario.Text, txtContra.Text);
                    if (loginValido == true)
                    {
                        FormMenuPrincipal formMenuPrincipal = new FormMenuPrincipal();
                        formMenuPrincipal.Show();
                        this.Hide();
                    }
                    else
                    {
                        msgError("Usuario o contraseña incorrectos.");
                        txtUsuario.Text = "USUARIO";
                        txtContra.Text = "CONTRASEÑA";
                    }
                }
                else
                {
                    msgError("Ingrese una contraseña");
                }
            }
            else
            {
                msgError("Ingrese un usuario");
            }
        }

        private void msgError(string msg)
        {
            lblMensajeError.Text = msg;
            lblMensajeError.Visible = true;
        }
    }
}
