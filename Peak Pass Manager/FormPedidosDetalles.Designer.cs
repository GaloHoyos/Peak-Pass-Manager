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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dgvCompraDetalles = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvCompraDetalles).BeginInit();
            SuspendLayout();
            // 
            // dgvCompraDetalles
            // 
            dgvCompraDetalles.AllowUserToAddRows = false;
            dgvCompraDetalles.AllowUserToDeleteRows = false;
            dgvCompraDetalles.AllowUserToResizeColumns = false;
            dgvCompraDetalles.AllowUserToResizeRows = false;
            dgvCompraDetalles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvCompraDetalles.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.MediumPurple;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.Menu;
            dataGridViewCellStyle1.SelectionBackColor = Color.MediumPurple;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCompraDetalles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCompraDetalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCompraDetalles.EnableHeadersVisualStyles = false;
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