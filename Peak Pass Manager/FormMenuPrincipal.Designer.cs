namespace Peak_Pass_Manager
{
    partial class FormMenuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelMenu = new Panel();
            btnReportes = new FontAwesome.Sharp.IconButton();
            btnUsuarios = new FontAwesome.Sharp.IconButton();
            btnPedidos = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            lblRol = new Label();
            lblApellido = new Label();
            lblNombre = new Label();
            btnOpciones = new FontAwesome.Sharp.IconButton();
            btnClientes = new FontAwesome.Sharp.IconButton();
            btnCatalogo = new FontAwesome.Sharp.IconButton();
            btnInicio = new FontAwesome.Sharp.IconButton();
            panelLogo = new Panel();
            btnReinicio = new PictureBox();
            panelBarraTitulo = new Panel();
            iconMinimizar = new FontAwesome.Sharp.IconPictureBox();
            iconCerrar = new FontAwesome.Sharp.IconPictureBox();
            lblTitleChildForm = new Label();
            iconFormulario = new FontAwesome.Sharp.IconPictureBox();
            panelSombra = new Panel();
            panelEscritorio = new Panel();
            btnAuditoria = new FontAwesome.Sharp.IconButton();
            panelMenu.SuspendLayout();
            panel1.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnReinicio).BeginInit();
            panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconFormulario).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(31, 30, 68);
            panelMenu.Controls.Add(btnAuditoria);
            panelMenu.Controls.Add(btnReportes);
            panelMenu.Controls.Add(btnUsuarios);
            panelMenu.Controls.Add(btnPedidos);
            panelMenu.Controls.Add(panel1);
            panelMenu.Controls.Add(btnOpciones);
            panelMenu.Controls.Add(btnClientes);
            panelMenu.Controls.Add(btnCatalogo);
            panelMenu.Controls.Add(btnInicio);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 842);
            panelMenu.TabIndex = 0;
            // 
            // btnReportes
            // 
            btnReportes.Dock = DockStyle.Top;
            btnReportes.FlatAppearance.BorderSize = 0;
            btnReportes.FlatStyle = FlatStyle.Flat;
            btnReportes.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnReportes.ForeColor = SystemColors.ButtonHighlight;
            btnReportes.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            btnReportes.IconColor = Color.WhiteSmoke;
            btnReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnReportes.ImageAlign = ContentAlignment.MiddleLeft;
            btnReportes.Location = new Point(0, 500);
            btnReportes.Name = "btnReportes";
            btnReportes.Padding = new Padding(10, 0, 20, 0);
            btnReportes.Size = new Size(220, 60);
            btnReportes.TabIndex = 8;
            btnReportes.Text = "Reportes";
            btnReportes.TextAlign = ContentAlignment.MiddleLeft;
            btnReportes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReportes.UseVisualStyleBackColor = true;
            // 
            // btnUsuarios
            // 
            btnUsuarios.Dock = DockStyle.Top;
            btnUsuarios.FlatAppearance.BorderSize = 0;
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnUsuarios.ForeColor = SystemColors.ButtonHighlight;
            btnUsuarios.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            btnUsuarios.IconColor = Color.WhiteSmoke;
            btnUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnUsuarios.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsuarios.Location = new Point(0, 440);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Padding = new Padding(10, 0, 20, 0);
            btnUsuarios.Size = new Size(220, 60);
            btnUsuarios.TabIndex = 7;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.TextAlign = ContentAlignment.MiddleLeft;
            btnUsuarios.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnPedidos
            // 
            btnPedidos.Dock = DockStyle.Top;
            btnPedidos.FlatAppearance.BorderSize = 0;
            btnPedidos.FlatStyle = FlatStyle.Flat;
            btnPedidos.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnPedidos.ForeColor = SystemColors.ButtonHighlight;
            btnPedidos.IconChar = FontAwesome.Sharp.IconChar.Gears;
            btnPedidos.IconColor = Color.WhiteSmoke;
            btnPedidos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPedidos.ImageAlign = ContentAlignment.MiddleLeft;
            btnPedidos.Location = new Point(0, 380);
            btnPedidos.Name = "btnPedidos";
            btnPedidos.Padding = new Padding(10, 0, 20, 0);
            btnPedidos.Size = new Size(220, 60);
            btnPedidos.TabIndex = 6;
            btnPedidos.Text = "Pedidos";
            btnPedidos.TextAlign = ContentAlignment.MiddleLeft;
            btnPedidos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPedidos.UseVisualStyleBackColor = true;
            btnPedidos.Click += btnPedidos_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblRol);
            panel1.Controls.Add(lblApellido);
            panel1.Controls.Add(lblNombre);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 692);
            panel1.Name = "panel1";
            panel1.Size = new Size(220, 150);
            panel1.TabIndex = 5;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.ForeColor = Color.Gainsboro;
            lblRol.Location = new Point(12, 116);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(37, 25);
            lblRol.TabIndex = 2;
            lblRol.Text = "Rol";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.ForeColor = Color.Gainsboro;
            lblApellido.Location = new Point(12, 80);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(78, 25);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.ForeColor = Color.Gainsboro;
            lblNombre.Location = new Point(12, 55);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(78, 25);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // btnOpciones
            // 
            btnOpciones.Dock = DockStyle.Top;
            btnOpciones.FlatAppearance.BorderSize = 0;
            btnOpciones.FlatStyle = FlatStyle.Flat;
            btnOpciones.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnOpciones.ForeColor = SystemColors.ButtonHighlight;
            btnOpciones.IconChar = FontAwesome.Sharp.IconChar.Gears;
            btnOpciones.IconColor = Color.WhiteSmoke;
            btnOpciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnOpciones.ImageAlign = ContentAlignment.MiddleLeft;
            btnOpciones.Location = new Point(0, 320);
            btnOpciones.Name = "btnOpciones";
            btnOpciones.Padding = new Padding(10, 0, 20, 0);
            btnOpciones.Size = new Size(220, 60);
            btnOpciones.TabIndex = 4;
            btnOpciones.Text = "Opciones";
            btnOpciones.TextAlign = ContentAlignment.MiddleLeft;
            btnOpciones.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnOpciones.UseVisualStyleBackColor = true;
            btnOpciones.Click += btnOpciones_Click;
            // 
            // btnClientes
            // 
            btnClientes.Dock = DockStyle.Top;
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnClientes.ForeColor = SystemColors.ButtonHighlight;
            btnClientes.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            btnClientes.IconColor = Color.WhiteSmoke;
            btnClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnClientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnClientes.Location = new Point(0, 260);
            btnClientes.Name = "btnClientes";
            btnClientes.Padding = new Padding(10, 0, 20, 0);
            btnClientes.Size = new Size(220, 60);
            btnClientes.TabIndex = 3;
            btnClientes.Text = "Clientes";
            btnClientes.TextAlign = ContentAlignment.MiddleLeft;
            btnClientes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnCatalogo
            // 
            btnCatalogo.Dock = DockStyle.Top;
            btnCatalogo.FlatAppearance.BorderSize = 0;
            btnCatalogo.FlatStyle = FlatStyle.Flat;
            btnCatalogo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCatalogo.ForeColor = SystemColors.ButtonHighlight;
            btnCatalogo.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            btnCatalogo.IconColor = Color.WhiteSmoke;
            btnCatalogo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCatalogo.ImageAlign = ContentAlignment.MiddleLeft;
            btnCatalogo.Location = new Point(0, 200);
            btnCatalogo.Name = "btnCatalogo";
            btnCatalogo.Padding = new Padding(10, 0, 20, 0);
            btnCatalogo.Size = new Size(220, 60);
            btnCatalogo.TabIndex = 2;
            btnCatalogo.Text = "Catalogo";
            btnCatalogo.TextAlign = ContentAlignment.MiddleLeft;
            btnCatalogo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCatalogo.UseVisualStyleBackColor = true;
            btnCatalogo.Click += btnCatalogo_Click;
            // 
            // btnInicio
            // 
            btnInicio.Dock = DockStyle.Top;
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnInicio.ForeColor = SystemColors.ButtonHighlight;
            btnInicio.IconChar = FontAwesome.Sharp.IconChar.House;
            btnInicio.IconColor = Color.WhiteSmoke;
            btnInicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnInicio.ImageAlign = ContentAlignment.MiddleLeft;
            btnInicio.Location = new Point(0, 140);
            btnInicio.Name = "btnInicio";
            btnInicio.Padding = new Padding(10, 0, 20, 0);
            btnInicio.Size = new Size(220, 60);
            btnInicio.TabIndex = 1;
            btnInicio.Text = "Inicio";
            btnInicio.TextAlign = ContentAlignment.MiddleLeft;
            btnInicio.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += btnInicio_Click;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(btnReinicio);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(220, 140);
            panelLogo.TabIndex = 0;
            // 
            // btnReinicio
            // 
            btnReinicio.Image = Properties.Resources.Peak_Pass_Manager_Logo;
            btnReinicio.Location = new Point(-43, -22);
            btnReinicio.Name = "btnReinicio";
            btnReinicio.Size = new Size(289, 194);
            btnReinicio.SizeMode = PictureBoxSizeMode.Zoom;
            btnReinicio.TabIndex = 0;
            btnReinicio.TabStop = false;
            btnReinicio.Click += btnReinicio_Click;
            // 
            // panelBarraTitulo
            // 
            panelBarraTitulo.BackColor = Color.FromArgb(26, 25, 62);
            panelBarraTitulo.Controls.Add(iconMinimizar);
            panelBarraTitulo.Controls.Add(iconCerrar);
            panelBarraTitulo.Controls.Add(lblTitleChildForm);
            panelBarraTitulo.Controls.Add(iconFormulario);
            panelBarraTitulo.Dock = DockStyle.Top;
            panelBarraTitulo.Location = new Point(220, 0);
            panelBarraTitulo.Name = "panelBarraTitulo";
            panelBarraTitulo.Size = new Size(1218, 75);
            panelBarraTitulo.TabIndex = 1;
            panelBarraTitulo.MouseDown += panelBarraTitulo_MouseDown;
            // 
            // iconMinimizar
            // 
            iconMinimizar.BackColor = Color.FromArgb(26, 25, 62);
            iconMinimizar.ForeColor = Color.DimGray;
            iconMinimizar.IconChar = FontAwesome.Sharp.IconChar.Minus;
            iconMinimizar.IconColor = Color.DimGray;
            iconMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMinimizar.IconSize = 37;
            iconMinimizar.Location = new Point(1132, 12);
            iconMinimizar.Name = "iconMinimizar";
            iconMinimizar.Size = new Size(38, 37);
            iconMinimizar.TabIndex = 9;
            iconMinimizar.TabStop = false;
            // 
            // iconCerrar
            // 
            iconCerrar.BackColor = Color.FromArgb(26, 25, 62);
            iconCerrar.ForeColor = Color.DimGray;
            iconCerrar.IconChar = FontAwesome.Sharp.IconChar.X;
            iconCerrar.IconColor = Color.DimGray;
            iconCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconCerrar.IconSize = 31;
            iconCerrar.Location = new Point(1176, 12);
            iconCerrar.Name = "iconCerrar";
            iconCerrar.Size = new Size(32, 31);
            iconCerrar.TabIndex = 8;
            iconCerrar.TabStop = false;
            iconCerrar.Click += iconCerrar_Click;
            iconCerrar.MouseEnter += iconCerrar_MouseEnter;
            iconCerrar.MouseLeave += iconCerrar_MouseLeave;
            // 
            // lblTitleChildForm
            // 
            lblTitleChildForm.AutoSize = true;
            lblTitleChildForm.ForeColor = Color.WhiteSmoke;
            lblTitleChildForm.Location = new Point(86, 35);
            lblTitleChildForm.Name = "lblTitleChildForm";
            lblTitleChildForm.Size = new Size(54, 25);
            lblTitleChildForm.TabIndex = 1;
            lblTitleChildForm.Text = "Inicio";
            // 
            // iconFormulario
            // 
            iconFormulario.BackColor = Color.FromArgb(26, 25, 62);
            iconFormulario.ForeColor = Color.MediumPurple;
            iconFormulario.IconChar = FontAwesome.Sharp.IconChar.House;
            iconFormulario.IconColor = Color.MediumPurple;
            iconFormulario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconFormulario.IconSize = 48;
            iconFormulario.Location = new Point(32, 12);
            iconFormulario.Name = "iconFormulario";
            iconFormulario.Size = new Size(48, 48);
            iconFormulario.TabIndex = 0;
            iconFormulario.TabStop = false;
            // 
            // panelSombra
            // 
            panelSombra.BackColor = Color.FromArgb(26, 24, 58);
            panelSombra.Dock = DockStyle.Top;
            panelSombra.Location = new Point(220, 75);
            panelSombra.Name = "panelSombra";
            panelSombra.Size = new Size(1218, 9);
            panelSombra.TabIndex = 2;
            // 
            // panelEscritorio
            // 
            panelEscritorio.BackColor = Color.FromArgb(34, 33, 74);
            panelEscritorio.Dock = DockStyle.Fill;
            panelEscritorio.Location = new Point(220, 84);
            panelEscritorio.Name = "panelEscritorio";
            panelEscritorio.Size = new Size(1218, 758);
            panelEscritorio.TabIndex = 3;
            // 
            // btnAuditoria
            // 
            btnAuditoria.Dock = DockStyle.Top;
            btnAuditoria.FlatAppearance.BorderSize = 0;
            btnAuditoria.FlatStyle = FlatStyle.Flat;
            btnAuditoria.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAuditoria.ForeColor = SystemColors.ButtonHighlight;
            btnAuditoria.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            btnAuditoria.IconColor = Color.WhiteSmoke;
            btnAuditoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAuditoria.ImageAlign = ContentAlignment.MiddleLeft;
            btnAuditoria.Location = new Point(0, 560);
            btnAuditoria.Name = "btnAuditoria";
            btnAuditoria.Padding = new Padding(10, 0, 20, 0);
            btnAuditoria.Size = new Size(220, 60);
            btnAuditoria.TabIndex = 9;
            btnAuditoria.Text = "Auditoria";
            btnAuditoria.TextAlign = ContentAlignment.MiddleLeft;
            btnAuditoria.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAuditoria.UseVisualStyleBackColor = true;
            btnAuditoria.Click += btnAuditoria_Click;
            // 
            // FormMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1438, 842);
            Controls.Add(panelEscritorio);
            Controls.Add(panelSombra);
            Controls.Add(panelBarraTitulo);
            Controls.Add(panelMenu);
            Name = "FormMenuPrincipal";
            Text = "Peak Pass Manager";
            panelMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnReinicio).EndInit();
            panelBarraTitulo.ResumeLayout(false);
            panelBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconFormulario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnInicio;
        private Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnClientes;
        private FontAwesome.Sharp.IconButton btnCatalogo;
        private PictureBox btnReinicio;
        private Panel panelBarraTitulo;
        private Label lblTitleChildForm;
        private FontAwesome.Sharp.IconPictureBox iconFormulario;
        private Panel panelSombra;
        private Panel panelEscritorio;
        private FontAwesome.Sharp.IconPictureBox iconMinimizar;
        private FontAwesome.Sharp.IconPictureBox iconCerrar;
        private FontAwesome.Sharp.IconButton btnOpciones;
        private Panel panel1;
        private Label lblApellido;
        private Label lblNombre;
        private FontAwesome.Sharp.IconButton btnPedidos;
        private FontAwesome.Sharp.IconButton btnUsuarios;
        private Label lblRol;
        private FontAwesome.Sharp.IconButton btnReportes;
        private FontAwesome.Sharp.IconButton btnAuditoria;
    }
}