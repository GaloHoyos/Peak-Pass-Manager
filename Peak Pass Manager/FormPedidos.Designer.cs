namespace Peak_Pass_Manager
{
    partial class FormPedidos
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
            dgvCompra = new DataGridView();
            btnDetalles = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dgvCompra).BeginInit();
            SuspendLayout();
            // 
            // dgvCompra
            // 
            dgvCompra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCompra.Location = new Point(37, 116);
            dgvCompra.Name = "dgvCompra";
            dgvCompra.RowHeadersWidth = 62;
            dgvCompra.RowTemplate.Height = 33;
            dgvCompra.Size = new Size(1128, 303);
            dgvCompra.TabIndex = 1;
            // 
            // btnDetalles
            // 
            btnDetalles.IconChar = FontAwesome.Sharp.IconChar.None;
            btnDetalles.IconColor = Color.Black;
            btnDetalles.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDetalles.Location = new Point(992, 570);
            btnDetalles.Name = "btnDetalles";
            btnDetalles.Size = new Size(192, 120);
            btnDetalles.TabIndex = 2;
            btnDetalles.Text = "Ver Detalles";
            btnDetalles.UseVisualStyleBackColor = true;
            btnDetalles.Click += btnDetalles_Click;
            // 
            // FormPedidos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(1196, 702);
            Controls.Add(btnDetalles);
            Controls.Add(dgvCompra);
            Name = "FormPedidos";
            Text = "FormCompra";
            ((System.ComponentModel.ISupportInitialize)dgvCompra).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCompra;
        private FontAwesome.Sharp.IconButton btnDetalles;
    }
}