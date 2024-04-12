using FontAwesome.Sharp;
using System.Runtime.InteropServices;
using System.Text;
using Comun.Cache;
using Dominio;

namespace Peak_Pass_Manager
{
    public partial class FormMenuPrincipal : Form
    {
        //campos
        private IconButton btnActual;
        private Panel btnBordeIzquierdo;
        private Form formActual;

        //constructor
        public FormMenuPrincipal()
        {
            InitializeComponent();
            CacheUsuario.IdCliente = -1;
            btnBordeIzquierdo = new Panel();
            btnBordeIzquierdo.Size = new Size(7, 60);
            panelMenu.Controls.Add(btnBordeIzquierdo);
            //form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            LoadUserData();
        }
        private void LoadUserData()
        {
            ControladoraUsuario usuario = new ControladoraUsuario();
            lblNombre.Text = usuario.ObtenerNombre();
            lblApellido.Text = usuario.ObtenerApellido();
            lblRol.Text = usuario.ObtenerRol();
            ControladoraPermisos permisos = new ControladoraPermisos();
            if (!permisos.Catalogo())
            {
                btnCatalogo.Visible = false;
            }
            if (!permisos.Clientes())
            {
                btnClientes.Visible = false;
            }
            if (!permisos.Opciones())
            {
                btnOpciones.Visible = false;
            }
            if (!permisos.Pedidos())
            {
                btnPedidos.Visible = false;
            }
            if (!permisos.Usuarios())
            {
                btnUsuarios.Visible = false;
            }
        }

        //estructura colores RGB
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        //metodos
        private void ActivarBoton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DesactivarBoton();
                //boton
                btnActual = (IconButton)senderBtn;
                btnActual.BackColor = Color.FromArgb(37, 36, 81);
                btnActual.ForeColor = color;
                btnActual.TextAlign = ContentAlignment.MiddleCenter;
                btnActual.IconColor = color;
                btnActual.TextImageRelation = TextImageRelation.TextBeforeImage;
                btnActual.ImageAlign = ContentAlignment.MiddleRight;
                //borde izquierdo boton
                btnBordeIzquierdo.BackColor = color;
                btnBordeIzquierdo.Location = new Point(0, btnActual.Location.Y);
                btnBordeIzquierdo.Visible = true;
                btnBordeIzquierdo.BringToFront();
                //icono formulario
                iconFormulario.IconChar = btnActual.IconChar;
                iconFormulario.IconColor = color;
            }
        }
        private void DesactivarBoton()
        {
            if (btnActual != null)
            {
                btnActual.BackColor = Color.FromArgb(31, 30, 68);
                btnActual.ForeColor = Color.Gainsboro;
                btnActual.TextAlign = ContentAlignment.MiddleLeft;
                btnActual.IconColor = Color.Gainsboro;
                btnActual.TextImageRelation = TextImageRelation.ImageBeforeText;
                btnActual.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        //abrir formulario hijo
        public void AbrirFormularioHijo(Form formularioHijo)
        {
            if (this.panelEscritorio.Controls.Count > 0)
                this.panelEscritorio.Controls.RemoveAt(0);
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;
            this.panelEscritorio.Controls.Add(formularioHijo);
            this.panelEscritorio.Tag = formularioHijo;
            formularioHijo.Show();
        }
        public void ChangeTextBox1Text(string text)
        {
            this.lblNombre.Text = text;
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColors.color1);
            AbrirFormularioHijo(new FormInicio());
        }

        private void btnCatalogo_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColors.color2);
            AbrirFormularioHijo(new FormCatalogo());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColors.color3);
            AbrirFormularioHijo(new FormClientes());
        }

        private void btnReinicio_Click(object sender, EventArgs e)
        {
            Reset();
            AbrirFormularioHijo(new FormInicio());
        }

        private void btnOpciones_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColors.color4);
            AbrirFormularioHijo(new FormOpciones());
        }
        private void btnPedidos_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColors.color5);
            AbrirFormularioHijo(new FormPedidos());
        }
        private void Reset()
        {
            DesactivarBoton();
            btnBordeIzquierdo.Visible = false;
            iconFormulario.IconChar = IconChar.Home;
            iconFormulario.IconColor = Color.MediumPurple;
            lblTitleChildForm.Text = "Inicio";
        }

        //arrastrar formulario

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg,
                       int wparam, int lparam);
        private void panelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColors.color6);
            AbrirFormularioHijo(new FormUsuarios());
        }
    }
}