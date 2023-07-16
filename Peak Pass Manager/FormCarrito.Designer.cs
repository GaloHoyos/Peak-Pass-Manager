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
            txtCantidad = new TextBox();
            lblCantidad = new Label();
            btnCantidad = new FontAwesome.Sharp.IconButton();
            btnComprar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).BeginInit();
            SuspendLayout();
            // 
            // dgvCarrito
            // 
            dgvCarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarrito.Location = new Point(72, 75);
            dgvCarrito.Name = "dgvCarrito";
            dgvCarrito.RowHeadersWidth = 62;
            dgvCarrito.RowTemplate.Height = 33;
            dgvCarrito.Size = new Size(664, 310);
            dgvCarrito.TabIndex = 0;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(220, 490);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(107, 31);
            txtCantidad.TabIndex = 1;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.ForeColor = Color.Gainsboro;
            lblCantidad.Location = new Point(220, 462);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(83, 25);
            lblCantidad.TabIndex = 3;
            lblCantidad.Text = "Cantidad";
            // 
            // btnCantidad
            // 
            btnCantidad.IconChar = FontAwesome.Sharp.IconChar.None;
            btnCantidad.IconColor = Color.Black;
            btnCantidad.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCantidad.Location = new Point(333, 488);
            btnCantidad.Name = "btnCantidad";
            btnCantidad.Size = new Size(112, 34);
            btnCantidad.TabIndex = 4;
            btnCantidad.Text = "Aceptar";
            btnCantidad.UseVisualStyleBackColor = true;
            btnCantidad.Click += btnCantidad_Click;
            // 
            // btnComprar
            // 
            btnComprar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnComprar.IconColor = Color.Black;
            btnComprar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnComprar.Location = new Point(829, 490);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(112, 34);
            btnComprar.TabIndex = 5;
            btnComprar.Text = "Comprar";
            btnComprar.UseVisualStyleBackColor = true;
            // 
            // FormCarrito
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(1196, 702);
            Controls.Add(btnComprar);
            Controls.Add(btnCantidad);
            Controls.Add(lblCantidad);
            Controls.Add(txtCantidad);
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
        private TextBox txtCantidad;
        private Label lblCantidad;
        private FontAwesome.Sharp.IconButton btnCantidad;
        private FontAwesome.Sharp.IconButton btnComprar;
    }
}