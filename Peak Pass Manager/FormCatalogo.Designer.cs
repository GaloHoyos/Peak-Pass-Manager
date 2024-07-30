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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dgvProductos = new DataGridView();
            lblClienteActual = new Label();
            lblCliente = new Label();
            lblDescripcion = new Label();
            btnCambioCliente = new CustomControls.RJControls.RJButton();
            btnPago = new CustomControls.RJControls.RJButton();
            dgvCarrito = new DataGridView();
            btnQuitar = new CustomControls.RJControls.RJButton();
            btnQuitarCantidad = new CustomControls.RJControls.RJButton();
            lblTotal = new Label();
            btnAgregar = new CustomControls.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).BeginInit();
            SuspendLayout();
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.AllowUserToResizeColumns = false;
            dgvProductos.AllowUserToResizeRows = false;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvProductos.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.MediumPurple;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.Menu;
            dataGridViewCellStyle1.SelectionBackColor = Color.MediumPurple;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.EnableHeadersVisualStyles = false;
            dgvProductos.Location = new Point(44, 28);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 62;
            dgvProductos.RowTemplate.Height = 33;
            dgvProductos.Size = new Size(523, 354);
            dgvProductos.TabIndex = 0;
            dgvProductos.CellClick += dgvProductos_CellClick;
            // 
            // lblClienteActual
            // 
            lblClienteActual.AutoSize = true;
            lblClienteActual.ForeColor = Color.Gainsboro;
            lblClienteActual.Location = new Point(869, 603);
            lblClienteActual.Name = "lblClienteActual";
            lblClienteActual.Size = new Size(123, 25);
            lblClienteActual.TabIndex = 2;
            lblClienteActual.Text = "Cliente Actual:";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.ForeColor = Color.Gainsboro;
            lblCliente.Location = new Point(998, 603);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(65, 25);
            lblCliente.TabIndex = 3;
            lblCliente.Text = "Cliente";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.ForeColor = SystemColors.ButtonFace;
            lblDescripcion.Location = new Point(44, 438);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(216, 25);
            lblDescripcion.TabIndex = 7;
            lblDescripcion.Text = "Descripcion del producto:";
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
            btnCambioCliente.Location = new Point(776, 636);
            btnCambioCliente.Name = "btnCambioCliente";
            btnCambioCliente.Size = new Size(408, 43);
            btnCambioCliente.TabIndex = 8;
            btnCambioCliente.Text = "Cambiar Cliente";
            btnCambioCliente.TextColor = Color.RoyalBlue;
            btnCambioCliente.UseVisualStyleBackColor = false;
            btnCambioCliente.Click += btnCambioCliente_Click;
            // 
            // btnPago
            // 
            btnPago.BackColor = Color.Lime;
            btnPago.BackgroundColor = Color.Lime;
            btnPago.BorderColor = Color.PaleVioletRed;
            btnPago.BorderRadius = 10;
            btnPago.BorderSize = 0;
            btnPago.FlatAppearance.BorderSize = 0;
            btnPago.FlatStyle = FlatStyle.Flat;
            btnPago.ForeColor = Color.Black;
            btnPago.Location = new Point(1016, 394);
            btnPago.Name = "btnPago";
            btnPago.Size = new Size(168, 112);
            btnPago.TabIndex = 9;
            btnPago.Text = "Ir al Pago";
            btnPago.TextColor = Color.Black;
            btnPago.UseVisualStyleBackColor = false;
            btnPago.Click += btnPago_Click;
            // 
            // dgvCarrito
            // 
            dgvCarrito.AllowUserToAddRows = false;
            dgvCarrito.AllowUserToDeleteRows = false;
            dgvCarrito.AllowUserToResizeColumns = false;
            dgvCarrito.AllowUserToResizeRows = false;
            dgvCarrito.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvCarrito.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.MediumPurple;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.Menu;
            dataGridViewCellStyle2.SelectionBackColor = Color.MediumPurple;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvCarrito.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvCarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarrito.EnableHeadersVisualStyles = false;
            dgvCarrito.Location = new Point(573, 28);
            dgvCarrito.Name = "dgvCarrito";
            dgvCarrito.RowHeadersWidth = 62;
            dgvCarrito.RowTemplate.Height = 33;
            dgvCarrito.Size = new Size(611, 354);
            dgvCarrito.TabIndex = 10;
            // 
            // btnQuitar
            // 
            btnQuitar.BackColor = Color.MediumSlateBlue;
            btnQuitar.BackgroundColor = Color.MediumSlateBlue;
            btnQuitar.BorderColor = Color.PaleVioletRed;
            btnQuitar.BorderRadius = 10;
            btnQuitar.BorderSize = 0;
            btnQuitar.FlatAppearance.BorderSize = 0;
            btnQuitar.FlatStyle = FlatStyle.Flat;
            btnQuitar.ForeColor = Color.White;
            btnQuitar.Location = new Point(762, 394);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(230, 39);
            btnQuitar.TabIndex = 11;
            btnQuitar.Text = "Quitar";
            btnQuitar.TextColor = Color.White;
            btnQuitar.UseVisualStyleBackColor = false;
            btnQuitar.Click += btnQuitar_Click;
            // 
            // btnQuitarCantidad
            // 
            btnQuitarCantidad.BackColor = Color.MediumSlateBlue;
            btnQuitarCantidad.BackgroundColor = Color.MediumSlateBlue;
            btnQuitarCantidad.BorderColor = Color.PaleVioletRed;
            btnQuitarCantidad.BorderRadius = 10;
            btnQuitarCantidad.BorderSize = 0;
            btnQuitarCantidad.FlatAppearance.BorderSize = 0;
            btnQuitarCantidad.FlatStyle = FlatStyle.Flat;
            btnQuitarCantidad.ForeColor = Color.White;
            btnQuitarCantidad.Location = new Point(762, 467);
            btnQuitarCantidad.Name = "btnQuitarCantidad";
            btnQuitarCantidad.Size = new Size(230, 39);
            btnQuitarCantidad.TabIndex = 12;
            btnQuitarCantidad.Text = "Quitar Cantidad";
            btnQuitarCantidad.TextColor = Color.White;
            btnQuitarCantidad.UseVisualStyleBackColor = false;
            btnQuitarCantidad.Click += btnQuitarCantidad_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.ForeColor = SystemColors.ButtonFace;
            lblTotal.Location = new Point(1016, 509);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 25);
            lblTotal.TabIndex = 13;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.LightSeaGreen;
            btnAgregar.BackgroundColor = Color.LightSeaGreen;
            btnAgregar.BorderColor = Color.PaleVioletRed;
            btnAgregar.BorderRadius = 10;
            btnAgregar.BorderSize = 0;
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(44, 394);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(230, 39);
            btnAgregar.TabIndex = 14;
            btnAgregar.Text = "Agregar al Carrito";
            btnAgregar.TextColor = Color.White;
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click_1;
            // 
            // FormCatalogo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(1196, 702);
            Controls.Add(btnAgregar);
            Controls.Add(lblTotal);
            Controls.Add(btnQuitarCantidad);
            Controls.Add(btnQuitar);
            Controls.Add(dgvCarrito);
            Controls.Add(btnPago);
            Controls.Add(btnCambioCliente);
            Controls.Add(lblDescripcion);
            Controls.Add(lblCliente);
            Controls.Add(lblClienteActual);
            Controls.Add(dgvProductos);
            Name = "FormCatalogo";
            Text = "Catalogo";
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProductos;
        private Label lblClienteActual;
        private Label lblCliente;
        private Label lblDescripcion;
        private CustomControls.RJControls.RJButton btnCambioCliente;
        private CustomControls.RJControls.RJButton btnPago;
        private DataGridView dgvCarrito;
        private CustomControls.RJControls.RJButton btnQuitar;
        private CustomControls.RJControls.RJButton btnQuitarCantidad;
        private Label lblTotal;
        private CustomControls.RJControls.RJButton btnAgregar;
    }
}