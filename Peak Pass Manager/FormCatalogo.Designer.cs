namespace Peak_Pass_Manager
{
    partial class FormCatalogo
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
            dgvProductos = new DataGridView();
            btnCambioCliente = new FontAwesome.Sharp.IconButton();
            lblClienteActual = new Label();
            lblCliente = new Label();
            btnAgregar = new FontAwesome.Sharp.IconButton();
            btnVerCarrito = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(65, 119);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 62;
            dgvProductos.RowTemplate.Height = 33;
            dgvProductos.Size = new Size(622, 354);
            dgvProductos.TabIndex = 0;
            // 
            // btnCambioCliente
            // 
            btnCambioCliente.IconChar = FontAwesome.Sharp.IconChar.None;
            btnCambioCliente.IconColor = Color.Black;
            btnCambioCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCambioCliente.Location = new Point(890, 12);
            btnCambioCliente.Name = "btnCambioCliente";
            btnCambioCliente.Size = new Size(285, 34);
            btnCambioCliente.TabIndex = 1;
            btnCambioCliente.Text = "Cambiar Cliente";
            btnCambioCliente.UseVisualStyleBackColor = true;
            btnCambioCliente.Click += btnCambioCliente_Click;
            // 
            // lblClienteActual
            // 
            lblClienteActual.AutoSize = true;
            lblClienteActual.ForeColor = Color.Gainsboro;
            lblClienteActual.Location = new Point(826, 58);
            lblClienteActual.Name = "lblClienteActual";
            lblClienteActual.Size = new Size(123, 25);
            lblClienteActual.TabIndex = 2;
            lblClienteActual.Text = "Cliente Actual:";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.ForeColor = Color.Gainsboro;
            lblCliente.Location = new Point(955, 58);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(65, 25);
            lblCliente.TabIndex = 3;
            lblCliente.Text = "Cliente";
            // 
            // btnAgregar
            // 
            btnAgregar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnAgregar.IconColor = Color.Black;
            btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregar.Location = new Point(110, 538);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(168, 98);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar al Carrito";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnVerCarrito
            // 
            btnVerCarrito.IconChar = FontAwesome.Sharp.IconChar.None;
            btnVerCarrito.IconColor = Color.Black;
            btnVerCarrito.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnVerCarrito.Location = new Point(955, 520);
            btnVerCarrito.Name = "btnVerCarrito";
            btnVerCarrito.Size = new Size(168, 98);
            btnVerCarrito.TabIndex = 6;
            btnVerCarrito.Text = "Ver Carrito";
            btnVerCarrito.UseVisualStyleBackColor = true;
            btnVerCarrito.Click += btnVerCarrito_Click;
            // 
            // FormCatalogo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(1196, 702);
            Controls.Add(btnVerCarrito);
            Controls.Add(btnAgregar);
            Controls.Add(lblCliente);
            Controls.Add(lblClienteActual);
            Controls.Add(btnCambioCliente);
            Controls.Add(dgvProductos);
            Name = "FormCatalogo";
            Text = "Catalogo";
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProductos;
        private FontAwesome.Sharp.IconButton btnCambioCliente;
        private Label lblClienteActual;
        private Label lblCliente;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private FontAwesome.Sharp.IconButton btnVerCarrito;
    }
}