namespace Peak_Pass_Manager
{
    partial class FormInicio
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
            dgvBackups = new DataGridView();
            btnBackup = new Button();
            btnRestore = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBackups).BeginInit();
            SuspendLayout();
            // 
            // dgvBackups
            // 
            dgvBackups.AllowUserToAddRows = false;
            dgvBackups.AllowUserToDeleteRows = false;
            dgvBackups.AllowUserToResizeColumns = false;
            dgvBackups.AllowUserToResizeRows = false;
            dgvBackups.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvBackups.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.MediumPurple;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.Menu;
            dataGridViewCellStyle1.SelectionBackColor = Color.MediumPurple;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvBackups.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvBackups.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBackups.EnableHeadersVisualStyles = false;
            dgvBackups.Location = new Point(12, 448);
            dgvBackups.Name = "dgvBackups";
            dgvBackups.RowHeadersWidth = 62;
            dgvBackups.RowTemplate.Height = 33;
            dgvBackups.Size = new Size(630, 242);
            dgvBackups.TabIndex = 2;
            // 
            // btnBackup
            // 
            btnBackup.Location = new Point(1057, 615);
            btnBackup.Name = "btnBackup";
            btnBackup.Size = new Size(127, 75);
            btnBackup.TabIndex = 3;
            btnBackup.Text = "Backup";
            btnBackup.UseVisualStyleBackColor = true;
            btnBackup.Click += btnBackup_Click;
            // 
            // btnRestore
            // 
            btnRestore.Location = new Point(648, 530);
            btnRestore.Name = "btnRestore";
            btnRestore.Size = new Size(134, 61);
            btnRestore.TabIndex = 4;
            btnRestore.Text = "Reestablecer";
            btnRestore.UseVisualStyleBackColor = true;
            btnRestore.Click += btnRestore_Click;
            // 
            // FormInicio
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(1196, 702);
            Controls.Add(btnRestore);
            Controls.Add(btnBackup);
            Controls.Add(dgvBackups);
            Name = "FormInicio";
            Text = "FormInicio";
            ((System.ComponentModel.ISupportInitialize)dgvBackups).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvBackups;
        private Button btnBackup;
        private Button btnRestore;
    }
}