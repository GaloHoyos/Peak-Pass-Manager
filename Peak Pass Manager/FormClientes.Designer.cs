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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
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
            lblMensajeError = new Label();
            lblCliente = new Label();
            lblClienteActual = new Label();
            btnEliminarRJ = new CustomControls.RJControls.RJButton();
            btnModificarRJ = new CustomControls.RJControls.RJButton();
            btnAgregarRJ = new CustomControls.RJControls.RJButton();
            btnFiltrosRJ = new CustomControls.RJControls.RJButton();
            gboxFiltros = new GroupBox();
            btnBuscarRJ = new CustomControls.RJControls.RJButton();
            lblBuscar = new Label();
            txtBuscar = new TextBox();
            btnCambioCliente = new CustomControls.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            gboxFiltros.SuspendLayout();
            SuspendLayout();
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.AllowUserToResizeColumns = false;
            dgvClientes.AllowUserToResizeRows = false;
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvClientes.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.MediumPurple;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.Menu;
            dataGridViewCellStyle1.SelectionBackColor = Color.MediumPurple;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.EnableHeadersVisualStyles = false;
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
            txtNombre.Location = new Point(197, 436);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 31);
            txtNombre.TabIndex = 1;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(197, 473);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(150, 31);
            txtApellido.TabIndex = 2;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(197, 510);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(150, 31);
            txtDNI.TabIndex = 3;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(197, 547);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(150, 31);
            txtCorreo.TabIndex = 4;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(197, 584);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(150, 31);
            txtDireccion.TabIndex = 5;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(197, 621);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(150, 31);
            txtTelefono.TabIndex = 6;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.ForeColor = Color.Gainsboro;
            lblNombre.Location = new Point(109, 439);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(82, 25);
            lblNombre.TabIndex = 7;
            lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.ForeColor = Color.Gainsboro;
            lblApellido.Location = new Point(109, 479);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(82, 25);
            lblApellido.TabIndex = 8;
            lblApellido.Text = "Apellido:";
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.ForeColor = Color.Gainsboro;
            lblDNI.Location = new Point(144, 513);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(47, 25);
            lblDNI.TabIndex = 9;
            lblDNI.Text = "DNI:";
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.ForeColor = Color.Gainsboro;
            lblCorreo.Location = new Point(121, 547);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(70, 25);
            lblCorreo.TabIndex = 10;
            lblCorreo.Text = "Correo:";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.ForeColor = Color.Gainsboro;
            lblDireccion.Location = new Point(106, 587);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(89, 25);
            lblDireccion.TabIndex = 11;
            lblDireccion.Text = "Direccion:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.ForeColor = Color.Gainsboro;
            lblTelefono.Location = new Point(112, 621);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(83, 25);
            lblTelefono.TabIndex = 12;
            lblTelefono.Text = "Telefono:";
            // 
            // lblMensajeError
            // 
            lblMensajeError.AutoSize = true;
            lblMensajeError.ForeColor = Color.Red;
            lblMensajeError.Location = new Point(210, 668);
            lblMensajeError.Name = "lblMensajeError";
            lblMensajeError.Size = new Size(120, 25);
            lblMensajeError.TabIndex = 16;
            lblMensajeError.Text = "Mensaje Error";
            lblMensajeError.Visible = false;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.ForeColor = Color.Gainsboro;
            lblCliente.Location = new Point(1044, 645);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(65, 25);
            lblCliente.TabIndex = 19;
            lblCliente.Text = "Cliente";
            // 
            // lblClienteActual
            // 
            lblClienteActual.AutoSize = true;
            lblClienteActual.ForeColor = Color.Gainsboro;
            lblClienteActual.Location = new Point(915, 645);
            lblClienteActual.Name = "lblClienteActual";
            lblClienteActual.Size = new Size(123, 25);
            lblClienteActual.TabIndex = 18;
            lblClienteActual.Text = "Cliente Actual:";
            // 
            // btnEliminarRJ
            // 
            btnEliminarRJ.BackColor = Color.DarkMagenta;
            btnEliminarRJ.BackgroundColor = Color.DarkMagenta;
            btnEliminarRJ.BorderColor = Color.PaleVioletRed;
            btnEliminarRJ.BorderRadius = 10;
            btnEliminarRJ.BorderSize = 0;
            btnEliminarRJ.FlatAppearance.BorderSize = 0;
            btnEliminarRJ.FlatStyle = FlatStyle.Flat;
            btnEliminarRJ.ForeColor = Color.White;
            btnEliminarRJ.Location = new Point(384, 607);
            btnEliminarRJ.Name = "btnEliminarRJ";
            btnEliminarRJ.Size = new Size(138, 60);
            btnEliminarRJ.TabIndex = 55;
            btnEliminarRJ.Text = "Eliminar";
            btnEliminarRJ.TextColor = Color.White;
            btnEliminarRJ.UseVisualStyleBackColor = false;
            btnEliminarRJ.Click += btnEliminarRJ_Click;
            // 
            // btnModificarRJ
            // 
            btnModificarRJ.BackColor = Color.MediumSlateBlue;
            btnModificarRJ.BackgroundColor = Color.MediumSlateBlue;
            btnModificarRJ.BorderColor = Color.PaleVioletRed;
            btnModificarRJ.BorderRadius = 10;
            btnModificarRJ.BorderSize = 0;
            btnModificarRJ.FlatAppearance.BorderSize = 0;
            btnModificarRJ.FlatStyle = FlatStyle.Flat;
            btnModificarRJ.ForeColor = Color.White;
            btnModificarRJ.Location = new Point(384, 521);
            btnModificarRJ.Name = "btnModificarRJ";
            btnModificarRJ.Size = new Size(138, 60);
            btnModificarRJ.TabIndex = 54;
            btnModificarRJ.Text = "Modificar";
            btnModificarRJ.TextColor = Color.White;
            btnModificarRJ.UseVisualStyleBackColor = false;
            btnModificarRJ.Click += btnModificarRJ_Click;
            // 
            // btnAgregarRJ
            // 
            btnAgregarRJ.BackColor = Color.MediumSlateBlue;
            btnAgregarRJ.BackgroundColor = Color.MediumSlateBlue;
            btnAgregarRJ.BorderColor = Color.PaleVioletRed;
            btnAgregarRJ.BorderRadius = 10;
            btnAgregarRJ.BorderSize = 0;
            btnAgregarRJ.FlatAppearance.BorderSize = 0;
            btnAgregarRJ.FlatStyle = FlatStyle.Flat;
            btnAgregarRJ.ForeColor = Color.White;
            btnAgregarRJ.Location = new Point(384, 436);
            btnAgregarRJ.Name = "btnAgregarRJ";
            btnAgregarRJ.Size = new Size(138, 60);
            btnAgregarRJ.TabIndex = 53;
            btnAgregarRJ.Text = "Agregar";
            btnAgregarRJ.TextColor = Color.White;
            btnAgregarRJ.UseVisualStyleBackColor = false;
            btnAgregarRJ.Click += btnAgregarRJ_Click;
            // 
            // btnFiltrosRJ
            // 
            btnFiltrosRJ.BackColor = Color.RoyalBlue;
            btnFiltrosRJ.BackgroundColor = Color.RoyalBlue;
            btnFiltrosRJ.BorderColor = Color.RoyalBlue;
            btnFiltrosRJ.BorderRadius = 10;
            btnFiltrosRJ.BorderSize = 1;
            btnFiltrosRJ.FlatAppearance.BorderSize = 0;
            btnFiltrosRJ.FlatStyle = FlatStyle.Flat;
            btnFiltrosRJ.ForeColor = Color.White;
            btnFiltrosRJ.Location = new Point(543, 439);
            btnFiltrosRJ.Name = "btnFiltrosRJ";
            btnFiltrosRJ.Size = new Size(366, 41);
            btnFiltrosRJ.TabIndex = 57;
            btnFiltrosRJ.Text = "Filtros";
            btnFiltrosRJ.TextColor = Color.White;
            btnFiltrosRJ.UseVisualStyleBackColor = false;
            btnFiltrosRJ.Click += btnFiltrosRJ_Click;
            // 
            // gboxFiltros
            // 
            gboxFiltros.Controls.Add(btnBuscarRJ);
            gboxFiltros.Controls.Add(lblBuscar);
            gboxFiltros.Controls.Add(txtBuscar);
            gboxFiltros.ForeColor = SystemColors.ButtonFace;
            gboxFiltros.Location = new Point(543, 486);
            gboxFiltros.Name = "gboxFiltros";
            gboxFiltros.Size = new Size(366, 137);
            gboxFiltros.TabIndex = 56;
            gboxFiltros.TabStop = false;
            gboxFiltros.Text = "Filtros";
            gboxFiltros.Enter += gboxFiltros_Enter;
            // 
            // btnBuscarRJ
            // 
            btnBuscarRJ.BackColor = Color.MediumSlateBlue;
            btnBuscarRJ.BackgroundColor = Color.MediumSlateBlue;
            btnBuscarRJ.BorderColor = Color.PaleVioletRed;
            btnBuscarRJ.BorderRadius = 10;
            btnBuscarRJ.BorderSize = 0;
            btnBuscarRJ.FlatAppearance.BorderSize = 0;
            btnBuscarRJ.FlatStyle = FlatStyle.Flat;
            btnBuscarRJ.ForeColor = Color.White;
            btnBuscarRJ.Location = new Point(121, 76);
            btnBuscarRJ.Name = "btnBuscarRJ";
            btnBuscarRJ.Size = new Size(139, 42);
            btnBuscarRJ.TabIndex = 50;
            btnBuscarRJ.Text = "Buscar";
            btnBuscarRJ.TextColor = Color.White;
            btnBuscarRJ.UseVisualStyleBackColor = false;
            btnBuscarRJ.Click += btnBuscarRJ_Click;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(30, 32);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(63, 25);
            lblBuscar.TabIndex = 1;
            lblBuscar.Text = "Buscar";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(99, 29);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(205, 31);
            txtBuscar.TabIndex = 0;
            // 
            // btnCambioCliente
            // 
            btnCambioCliente.BackColor = Color.Transparent;
            btnCambioCliente.BackgroundColor = Color.Transparent;
            btnCambioCliente.BackgroundImageLayout = ImageLayout.None;
            btnCambioCliente.BorderColor = Color.RoyalBlue;
            btnCambioCliente.BorderRadius = 10;
            btnCambioCliente.BorderSize = 1;
            btnCambioCliente.FlatAppearance.BorderSize = 0;
            btnCambioCliente.FlatStyle = FlatStyle.Flat;
            btnCambioCliente.ForeColor = Color.RoyalBlue;
            btnCambioCliente.Location = new Point(543, 636);
            btnCambioCliente.Name = "btnCambioCliente";
            btnCambioCliente.Size = new Size(366, 43);
            btnCambioCliente.TabIndex = 58;
            btnCambioCliente.Text = "Cambiar Cliente";
            btnCambioCliente.TextColor = Color.RoyalBlue;
            btnCambioCliente.UseVisualStyleBackColor = false;
            btnCambioCliente.Click += btnCambioCliente_Click_1;
            // 
            // FormClientes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(1196, 702);
            Controls.Add(btnCambioCliente);
            Controls.Add(btnFiltrosRJ);
            Controls.Add(gboxFiltros);
            Controls.Add(btnEliminarRJ);
            Controls.Add(btnModificarRJ);
            Controls.Add(btnAgregarRJ);
            Controls.Add(lblCliente);
            Controls.Add(lblClienteActual);
            Controls.Add(lblMensajeError);
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
            gboxFiltros.ResumeLayout(false);
            gboxFiltros.PerformLayout();
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
        private Label lblMensajeError;
        private Label lblCliente;
        private Label lblClienteActual;
        private CustomControls.RJControls.RJButton btnEliminarRJ;
        private CustomControls.RJControls.RJButton btnModificarRJ;
        private CustomControls.RJControls.RJButton btnAgregarRJ;
        private CustomControls.RJControls.RJButton btnFiltrosRJ;
        private GroupBox gboxFiltros;
        private CustomControls.RJControls.RJButton btnBuscarRJ;
        private Label lblBuscar;
        private TextBox txtBuscar;
        private CustomControls.RJControls.RJButton btnCambioCliente;
    }
}