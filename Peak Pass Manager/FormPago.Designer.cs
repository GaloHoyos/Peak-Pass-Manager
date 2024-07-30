namespace Peak_Pass_Manager
{
    partial class FormPago
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
            txtCodigo = new TextBox();
            txtTarjeta = new TextBox();
            txtNombre = new TextBox();
            dtFecha = new DateTimePicker();
            lblNombre = new Label();
            lblTarjeta = new Label();
            lblCodigo = new Label();
            lblFecha = new Label();
            picLogo = new PictureBox();
            panel1 = new Panel();
            btnComprar = new CustomControls.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(356, 150);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(129, 31);
            txtCodigo.TabIndex = 0;
            // 
            // txtTarjeta
            // 
            txtTarjeta.Location = new Point(12, 150);
            txtTarjeta.Name = "txtTarjeta";
            txtTarjeta.Size = new Size(306, 31);
            txtTarjeta.TabIndex = 1;
            txtTarjeta.TextChanged += txtTarjeta_TextChanged;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 72);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(306, 31);
            txtNombre.TabIndex = 2;
            // 
            // dtFecha
            // 
            dtFecha.Format = DateTimePickerFormat.Short;
            dtFecha.Location = new Point(356, 72);
            dtFecha.MinDate = new DateTime(2024, 4, 16, 20, 27, 39, 0);
            dtFecha.Name = "dtFecha";
            dtFecha.Size = new Size(129, 31);
            dtFecha.TabIndex = 3;
            dtFecha.Value = new DateTime(2024, 4, 16, 20, 27, 39, 0);
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.ForeColor = SystemColors.Control;
            lblNombre.Location = new Point(12, 44);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(260, 25);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Nombre del dueño de la tarjeta";
            // 
            // lblTarjeta
            // 
            lblTarjeta.AutoSize = true;
            lblTarjeta.ForeColor = SystemColors.Control;
            lblTarjeta.Location = new Point(12, 122);
            lblTarjeta.Name = "lblTarjeta";
            lblTarjeta.Size = new Size(156, 25);
            lblTarjeta.TabIndex = 5;
            lblTarjeta.Text = "Numero de tarjeta";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.ForeColor = SystemColors.Control;
            lblCodigo.Location = new Point(356, 122);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(45, 25);
            lblCodigo.TabIndex = 6;
            lblCodigo.Text = "CVV";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.ForeColor = SystemColors.Control;
            lblFecha.Location = new Point(339, 44);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(167, 25);
            lblFecha.TabIndex = 7;
            lblFecha.Text = "Fecha de Expiracion";
            // 
            // picLogo
            // 
            picLogo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picLogo.Location = new Point(30, 32);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(232, 149);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 8;
            picLogo.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(picLogo);
            panel1.Location = new Point(512, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(283, 211);
            panel1.TabIndex = 9;
            // 
            // btnComprar
            // 
            btnComprar.BackColor = Color.Lime;
            btnComprar.BackgroundColor = Color.Lime;
            btnComprar.BorderColor = Color.DarkGreen;
            btnComprar.BorderRadius = 10;
            btnComprar.BorderSize = 5;
            btnComprar.FlatAppearance.BorderSize = 0;
            btnComprar.FlatStyle = FlatStyle.Flat;
            btnComprar.ForeColor = Color.Black;
            btnComprar.Location = new Point(37, 223);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(413, 126);
            btnComprar.TabIndex = 10;
            btnComprar.Text = "Realizar Compra";
            btnComprar.TextColor = Color.Black;
            btnComprar.UseVisualStyleBackColor = false;
            btnComprar.Click += btnComprar_Click_1;
            // 
            // FormPago
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(808, 390);
            Controls.Add(btnComprar);
            Controls.Add(panel1);
            Controls.Add(lblFecha);
            Controls.Add(lblCodigo);
            Controls.Add(lblTarjeta);
            Controls.Add(lblNombre);
            Controls.Add(dtFecha);
            Controls.Add(txtNombre);
            Controls.Add(txtTarjeta);
            Controls.Add(txtCodigo);
            Name = "FormPago";
            Text = "FormPago";
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCodigo;
        private TextBox txtTarjeta;
        private TextBox txtNombre;
        private DateTimePicker dtFecha;
        private Label lblNombre;
        private Label lblTarjeta;
        private Label lblCodigo;
        private Label lblFecha;
        private PictureBox picLogo;
        private Panel panel1;
        private CustomControls.RJControls.RJButton btnComprar;
    }
}