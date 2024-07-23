namespace Peak_Pass_Manager
{
    partial class FormAuditoria
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
            dgvAuditoria = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvAuditoria).BeginInit();
            SuspendLayout();
            // 
            // dgvAuditoria
            // 
            dgvAuditoria.AllowUserToAddRows = false;
            dgvAuditoria.AllowUserToDeleteRows = false;
            dgvAuditoria.AllowUserToResizeColumns = false;
            dgvAuditoria.AllowUserToResizeRows = false;
            dgvAuditoria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvAuditoria.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.MediumPurple;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.Menu;
            dataGridViewCellStyle1.SelectionBackColor = Color.MediumPurple;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvAuditoria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvAuditoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAuditoria.EnableHeadersVisualStyles = false;
            dgvAuditoria.Location = new Point(38, 28);
            dgvAuditoria.Name = "dgvAuditoria";
            dgvAuditoria.RowHeadersWidth = 62;
            dgvAuditoria.RowTemplate.Height = 33;
            dgvAuditoria.Size = new Size(1122, 643);
            dgvAuditoria.TabIndex = 0;
            // 
            // FormAuditoria
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(1196, 702);
            Controls.Add(dgvAuditoria);
            Name = "FormAuditoria";
            Text = "FormAuditoria";
            ((System.ComponentModel.ISupportInitialize)dgvAuditoria).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvAuditoria;
    }
}