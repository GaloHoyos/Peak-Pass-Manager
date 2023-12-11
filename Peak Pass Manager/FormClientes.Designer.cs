namespace Peak_Pass_Manager
{
    partial class FormClientes
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
            dgvClientes = new DataGridView();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDNI = new TextBox();
            txtCorreo = new TextBox();
            txtDireccion = new TextBox();
            txtTelefono = new TextBox();
            lblNombre = new Label();
            lblApellido = new Label();
            lblDNI = new Label();
            lblCorreo = new Label();
            lblDireccion = new Label();
            lblTelefono = new Label();
            btnAgregar = new FontAwesome.Sharp.IconButton();
            btnModificar = new FontAwesome.Sharp.IconButton();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            lblMensajeError = new Label();
            btnCambioCliente = new FontAwesome.Sharp.IconButton();
            lblCliente = new Label();
            lblClienteActual = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(38, 26);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersWidth = 62;
            dgvClientes.RowTemplate.Height = 33;
            dgvClientes.Size = new Size(1115, 392);
            dgvClientes.TabIndex = 0;
            dgvClientes.CellClick += dgvClientes_CellClick;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(201, 451);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 31);
            txtNombre.TabIndex = 1;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(201, 488);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(150, 31);
            txtApellido.TabIndex = 2;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(201, 525);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(150, 31);
            txtDNI.TabIndex = 3;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(201, 562);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(150, 31);
            txtCorreo.TabIndex = 4;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(201, 599);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(150, 31);
            txtDireccion.TabIndex = 5;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(201, 636);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(150, 31);
            txtTelefono.TabIndex = 6;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.ForeColor = Color.Gainsboro;
            lblNombre.Location = new Point(113, 454);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(82, 25);
            lblNombre.TabIndex = 7;
            lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.ForeColor = Color.Gainsboro;
            lblApellido.Location = new Point(113, 494);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(82, 25);
            lblApellido.TabIndex = 8;
            lblApellido.Text = "Apellido:";
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.ForeColor = Color.Gainsboro;
            lblDNI.Location = new Point(148, 528);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(47, 25);
            lblDNI.TabIndex = 9;
            lblDNI.Text = "DNI:";
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.ForeColor = Color.Gainsboro;
            lblCorreo.Location = new Point(125, 562);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(70, 25);
            lblCorreo.TabIndex = 10;
            lblCorreo.Text = "Correo:";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.ForeColor = Color.Gainsboro;
            lblDireccion.Location = new Point(110, 602);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(89, 25);
            lblDireccion.TabIndex = 11;
            lblDireccion.Text = "Direccion:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.ForeColor = Color.Gainsboro;
            lblTelefono.Location = new Point(116, 636);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(83, 25);
            lblTelefono.TabIndex = 12;
            lblTelefono.Text = "Telefono:";
            // 
            // btnAgregar
            // 
            btnAgregar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnAgregar.IconColor = Color.Black;
            btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregar.Location = new Point(537, 480);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(112, 34);
            btnAgregar.TabIndex = 13;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnModificar.IconColor = Color.Black;
            btnModificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnModificar.Location = new Point(537, 525);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(112, 34);
            btnModificar.TabIndex = 14;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnEliminar.IconColor = Color.Black;
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminar.Location = new Point(537, 576);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 34);
            btnEliminar.TabIndex = 15;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // lblMensajeError
            // 
            lblMensajeError.AutoSize = true;
            lblMensajeError.ForeColor = Color.Red;
            lblMensajeError.Location = new Point(529, 639);
            lblMensajeError.Name = "lblMensajeError";
            lblMensajeError.Size = new Size(120, 25);
            lblMensajeError.TabIndex = 16;
            lblMensajeError.Text = "Mensaje Error";
            lblMensajeError.Visible = false;
            // 
            // btnCambioCliente
            // 
            btnCambioCliente.IconChar = FontAwesome.Sharp.IconChar.None;
            btnCambioCliente.IconColor = Color.Black;
            btnCambioCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCambioCliente.Location = new Point(942, 562);
            btnCambioCliente.Name = "btnCambioCliente";
            btnCambioCliente.Size = new Size(197, 68);
            btnCambioCliente.TabIndex = 17;
            btnCambioCliente.Text = "Cambiar Cliente de Venta";
            btnCambioCliente.UseVisualStyleBackColor = true;
            btnCambioCliente.Click += btnCambioCliente_Click;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.ForeColor = Color.Gainsboro;
            lblCliente.Location = new Point(1052, 642);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(65, 25);
            lblCliente.TabIndex = 19;
            lblCliente.Text = "Cliente";
            // 
            // lblClienteActual
            // 
            lblClienteActual.AutoSize = true;
            lblClienteActual.ForeColor = Color.Gainsboro;
            lblClienteActual.Location = new Point(923, 642);
            lblClienteActual.Name = "lblClienteActual";
            lblClienteActual.Size = new Size(123, 25);
            lblClienteActual.TabIndex = 18;
            lblClienteActual.Text = "Cliente Actual:";
            // 
            // FormClientes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(1196, 702);
            Controls.Add(lblCliente);
            Controls.Add(lblClienteActual);
            Controls.Add(btnCambioCliente);
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
            Controls.Add(dgvClientes);
            Name = "FormClientes";
            Text = "FormClientes";
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvClientes;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDNI;
        private TextBox txtCorreo;
        private TextBox txtDireccion;
        private TextBox txtTelefono;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblDNI;
        private Label lblCorreo;
        private Label lblDireccion;
        private Label lblTelefono;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private FontAwesome.Sharp.IconButton btnModificar;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private Label lblMensajeError;
        private FontAwesome.Sharp.IconButton btnCambioCliente;
        private Label lblCliente;
        private Label lblClienteActual;
    }
}