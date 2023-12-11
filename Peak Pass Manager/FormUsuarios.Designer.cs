namespace Peak_Pass_Manager
{
    partial class FormUsuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblMensajeError = new Label();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnModificar = new FontAwesome.Sharp.IconButton();
            btnAgregar = new FontAwesome.Sharp.IconButton();
            lblTelefono = new Label();
            lblDireccion = new Label();
            lblCorreo = new Label();
            lblDNI = new Label();
            lblApellido = new Label();
            lblNombre = new Label();
            txtTelefono = new TextBox();
            txtDireccion = new TextBox();
            txtCorreo = new TextBox();
            txtDNI = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            dgvUsuarios = new DataGridView();
            lblPassword = new Label();
            lblNUsuario = new Label();
            txtPassword = new TextBox();
            txtUsuario = new TextBox();
            cmbRol = new ComboBox();
            lblRol = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // lblMensajeError
            // 
            lblMensajeError.AutoSize = true;
            lblMensajeError.ForeColor = Color.Red;
            lblMensajeError.Location = new Point(620, 630);
            lblMensajeError.Name = "lblMensajeError";
            lblMensajeError.Size = new Size(120, 25);
            lblMensajeError.TabIndex = 36;
            lblMensajeError.Text = "Mensaje Error";
            lblMensajeError.Visible = false;
            // 
            // btnEliminar
            // 
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnEliminar.IconColor = Color.Black;
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminar.Location = new Point(1021, 517);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 34);
            btnEliminar.TabIndex = 35;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnModificar.IconColor = Color.Black;
            btnModificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnModificar.Location = new Point(1021, 477);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(112, 34);
            btnModificar.TabIndex = 34;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnAgregar.IconColor = Color.Black;
            btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregar.Location = new Point(1021, 437);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(112, 34);
            btnAgregar.TabIndex = 33;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.ForeColor = Color.Gainsboro;
            lblTelefono.Location = new Point(120, 622);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(83, 25);
            lblTelefono.TabIndex = 32;
            lblTelefono.Text = "Telefono:";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.ForeColor = Color.Gainsboro;
            lblDireccion.Location = new Point(114, 588);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(89, 25);
            lblDireccion.TabIndex = 31;
            lblDireccion.Text = "Direccion:";
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.ForeColor = Color.Gainsboro;
            lblCorreo.Location = new Point(129, 548);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(70, 25);
            lblCorreo.TabIndex = 30;
            lblCorreo.Text = "Correo:";
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.ForeColor = Color.Gainsboro;
            lblDNI.Location = new Point(152, 514);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(47, 25);
            lblDNI.TabIndex = 29;
            lblDNI.Text = "DNI:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.ForeColor = Color.Gainsboro;
            lblApellido.Location = new Point(117, 480);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(82, 25);
            lblApellido.TabIndex = 28;
            lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.ForeColor = Color.Gainsboro;
            lblNombre.Location = new Point(117, 440);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(82, 25);
            lblNombre.TabIndex = 27;
            lblNombre.Text = "Nombre:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(205, 622);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(150, 31);
            txtTelefono.TabIndex = 26;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(205, 585);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(150, 31);
            txtDireccion.TabIndex = 25;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(205, 548);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(150, 31);
            txtCorreo.TabIndex = 24;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(205, 511);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(150, 31);
            txtDNI.TabIndex = 23;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(205, 474);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(150, 31);
            txtApellido.TabIndex = 22;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(205, 437);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 31);
            txtNombre.TabIndex = 21;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(42, 12);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowHeadersWidth = 62;
            dgvUsuarios.RowTemplate.Height = 33;
            dgvUsuarios.Size = new Size(1115, 392);
            dgvUsuarios.TabIndex = 20;
            dgvUsuarios.CellClick += dgvUsuarios_CellClick;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.ForeColor = Color.Gainsboro;
            lblPassword.Location = new Point(374, 477);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(105, 25);
            lblPassword.TabIndex = 43;
            lblPassword.Text = "Contraseña:";
            // 
            // lblNUsuario
            // 
            lblNUsuario.AutoSize = true;
            lblNUsuario.ForeColor = Color.Gainsboro;
            lblNUsuario.Location = new Point(397, 437);
            lblNUsuario.Name = "lblNUsuario";
            lblNUsuario.Size = new Size(76, 25);
            lblNUsuario.TabIndex = 42;
            lblNUsuario.Text = "Usuario:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(485, 471);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(150, 31);
            txtPassword.TabIndex = 41;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(485, 434);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(150, 31);
            txtUsuario.TabIndex = 40;
            // 
            // cmbRol
            // 
            cmbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRol.FormattingEnabled = true;
            cmbRol.Location = new Point(485, 508);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(150, 33);
            cmbRol.TabIndex = 44;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.ForeColor = Color.Gainsboro;
            lblRol.Location = new Point(438, 511);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(41, 25);
            lblRol.TabIndex = 45;
            lblRol.Text = "Rol:";
            // 
            // FormUsuarios
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(1196, 702);
            Controls.Add(lblRol);
            Controls.Add(cmbRol);
            Controls.Add(lblPassword);
            Controls.Add(lblNUsuario);
            Controls.Add(txtPassword);
            Controls.Add(txtUsuario);
            Controls.Add(lblMensajeError);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(lblTelefono);
            Controls.Add(lblDireccion);
            Controls.Add(lblCorreo);
            Controls.Add(lblDNI);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(txtTelefono);
            Controls.Add(txtDireccion);
            Controls.Add(txtCorreo);
            Controls.Add(txtDNI);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(dgvUsuarios);
            Name = "FormUsuarios";
            Text = "FormUsuarios";
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblMensajeError;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnModificar;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private Label lblTelefono;
        private Label lblDireccion;
        private Label lblCorreo;
        private Label lblDNI;
        private Label lblApellido;
        private Label lblNombre;
        private TextBox txtTelefono;
        private TextBox txtDireccion;
        private TextBox txtCorreo;
        private TextBox txtDNI;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private DataGridView dgvUsuarios;
        private Label lblPassword;
        private Label lblNUsuario;
        private TextBox txtPassword;
        private TextBox txtUsuario;
        private ComboBox cmbRol;
        private Label lblRol;
    }
}