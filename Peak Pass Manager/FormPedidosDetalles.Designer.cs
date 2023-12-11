namespace Peak_Pass_Manager
{
    partial class FormPedidosDetalles
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
            dgvCompraDetalles = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvCompraDetalles).BeginInit();
            SuspendLayout();
            // 
            // dgvCompraDetalles
            // 
            dgvCompraDetalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCompraDetalles.Location = new Point(37, 47);
            dgvCompraDetalles.Name = "dgvCompraDetalles";
            dgvCompraDetalles.RowHeadersWidth = 62;
            dgvCompraDetalles.RowTemplate.Height = 33;
            dgvCompraDetalles.Size = new Size(1128, 303);
            dgvCompraDetalles.TabIndex = 2;
            // 
            // FormPedidosDetalles
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(1196, 702);
            Controls.Add(dgvCompraDetalles);
            Name = "FormPedidosDetalles";
            Text = "FormPedidosDetalles";
            ((System.ComponentModel.ISupportInitialize)dgvCompraDetalles).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCompraDetalles;
    }
}