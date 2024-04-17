namespace Peak_Pass_Manager
{
    partial class FormCarrito
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
            dgvCarrito = new DataGridView();
            btnPago = new FontAwesome.Sharp.IconButton();
            lblTotal = new Label();
            btnQuitar = new FontAwesome.Sharp.IconButton();
            btnQuitarCantidad = new FontAwesome.Sharp.IconButton();
            lblMensajeError = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).BeginInit();
            SuspendLayout();
            // 
            // dgvCarrito
            // 
            dgvCarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarrito.Location = new Point(34, 91);
            dgvCarrito.Name = "dgvCarrito";
            dgvCarrito.RowHeadersWidth = 62;
            dgvCarrito.RowTemplate.Height = 33;
            dgvCarrito.Size = new Size(1128, 303);
            dgvCarrito.TabIndex = 0;
            // 
            // btnPago
            // 
            btnPago.IconChar = FontAwesome.Sharp.IconChar.None;
            btnPago.IconColor = Color.Black;
            btnPago.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPago.Location = new Point(948, 511);
            btnPago.Name = "btnPago";
            btnPago.Size = new Size(236, 179);
            btnPago.TabIndex = 5;
            btnPago.Text = "Proceder al Pago";
            btnPago.UseVisualStyleBackColor = true;
            btnPago.Click += btnComprar_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.ForeColor = Color.Gainsboro;
            lblTotal.Location = new Point(948, 397);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(53, 25);
            lblTotal.TabIndex = 6;
            lblTotal.Text = "Total:";
            // 
            // btnQuitar
            // 
            btnQuitar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnQuitar.IconColor = Color.Black;
            btnQuitar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnQuitar.Location = new Point(34, 400);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(243, 38);
            btnQuitar.TabIndex = 7;
            btnQuitar.Text = "Quitar";
            btnQuitar.UseVisualStyleBackColor = true;
            btnQuitar.Click += btnQuitar_Click;
            // 
            // btnQuitarCantidad
            // 
            btnQuitarCantidad.IconChar = FontAwesome.Sharp.IconChar.None;
            btnQuitarCantidad.IconColor = Color.Black;
            btnQuitarCantidad.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnQuitarCantidad.Location = new Point(34, 458);
            btnQuitarCantidad.Name = "btnQuitarCantidad";
            btnQuitarCantidad.Size = new Size(243, 38);
            btnQuitarCantidad.TabIndex = 8;
            btnQuitarCantidad.Text = "Quitar Cantidad";
            btnQuitarCantidad.UseVisualStyleBackColor = true;
            btnQuitarCantidad.Click += btnQuitarCantidad_Click;
            // 
            // lblMensajeError
            // 
            lblMensajeError.AutoSize = true;
            lblMensajeError.ForeColor = Color.Red;
            lblMensajeError.Location = new Point(345, 436);
            lblMensajeError.Name = "lblMensajeError";
            lblMensajeError.Size = new Size(115, 25);
            lblMensajeError.TabIndex = 9;
            lblMensajeError.Text = "MensajeError";
            lblMensajeError.Visible = false;
            // 
            // FormCarrito
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(1196, 702);
            Controls.Add(lblMensajeError);
            Controls.Add(btnQuitarCantidad);
            Controls.Add(btnQuitar);
            Controls.Add(lblTotal);
            Controls.Add(btnPago);
            Controls.Add(dgvCarrito);
            ForeColor = SystemColors.ControlText;
            Name = "FormCarrito";
            Text = "FormCarrito";
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCarrito;
        private FontAwesome.Sharp.IconButton btnPago;
        private Label lblTotal;
        private FontAwesome.Sharp.IconButton btnQuitar;
        private FontAwesome.Sharp.IconButton btnQuitarCantidad;
        private Label lblMensajeError;
    }
}