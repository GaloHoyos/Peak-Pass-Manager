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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dgvCompra = new DataGridView();
            dgvCompraDetalles = new DataGridView();
            btnVerDetalles = new CustomControls.RJControls.RJButton();
            btnCerrar = new CustomControls.RJControls.RJButton();
            btnFiltrosRJ = new CustomControls.RJControls.RJButton();
            gboxFiltros = new GroupBox();
            btnBuscarRJ = new CustomControls.RJControls.RJButton();
            lblBuscar = new Label();
            txtBuscar = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvCompra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCompraDetalles).BeginInit();
            gboxFiltros.SuspendLayout();
            SuspendLayout();
            // 
            // dgvCompra
            // 
            dgvCompra.AllowUserToAddRows = false;
            dgvCompra.AllowUserToDeleteRows = false;
            dgvCompra.AllowUserToResizeColumns = false;
            dgvCompra.AllowUserToResizeRows = false;
            dgvCompra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvCompra.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.MediumPurple;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.Menu;
            dataGridViewCellStyle3.SelectionBackColor = Color.MediumPurple;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvCompra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvCompra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCompra.EnableHeadersVisualStyles = false;
            dgvCompra.Location = new Point(37, 24);
            dgvCompra.Name = "dgvCompra";
            dgvCompra.RowHeadersWidth = 62;
            dgvCompra.RowTemplate.Height = 33;
            dgvCompra.Size = new Size(1128, 303);
            dgvCompra.TabIndex = 1;
            // 
            // dgvCompraDetalles
            // 
            dgvCompraDetalles.AllowUserToAddRows = false;
            dgvCompraDetalles.AllowUserToDeleteRows = false;
            dgvCompraDetalles.AllowUserToResizeColumns = false;
            dgvCompraDetalles.AllowUserToResizeRows = false;
            dgvCompraDetalles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgvCompraDetalles.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.MediumPurple;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.Menu;
            dataGridViewCellStyle4.SelectionBackColor = Color.MediumPurple;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvCompraDetalles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvCompraDetalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCompraDetalles.EnableHeadersVisualStyles = false;
            dgvCompraDetalles.Location = new Point(37, 362);
            dgvCompraDetalles.Name = "dgvCompraDetalles";
            dgvCompraDetalles.RowHeadersWidth = 62;
            dgvCompraDetalles.RowTemplate.Height = 33;
            dgvCompraDetalles.Size = new Size(846, 303);
            dgvCompraDetalles.TabIndex = 3;
            // 
            // btnVerDetalles
            // 
            btnVerDetalles.BackColor = Color.MediumSlateBlue;
            btnVerDetalles.BackgroundColor = Color.MediumSlateBlue;
            btnVerDetalles.BorderColor = Color.PaleVioletRed;
            btnVerDetalles.BorderRadius = 10;
            btnVerDetalles.BorderSize = 0;
            btnVerDetalles.FlatAppearance.BorderSize = 0;
            btnVerDetalles.FlatStyle = FlatStyle.Flat;
            btnVerDetalles.ForeColor = Color.White;
            btnVerDetalles.Location = new Point(940, 333);
            btnVerDetalles.Name = "btnVerDetalles";
            btnVerDetalles.Size = new Size(225, 60);
            btnVerDetalles.TabIndex = 4;
            btnVerDetalles.Text = "Ver Detalles";
            btnVerDetalles.TextColor = Color.White;
            btnVerDetalles.UseVisualStyleBackColor = false;
            btnVerDetalles.Click += btnVerDetalles_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.MediumSlateBlue;
            btnCerrar.BackgroundColor = Color.MediumSlateBlue;
            btnCerrar.BorderColor = Color.PaleVioletRed;
            btnCerrar.BorderRadius = 10;
            btnCerrar.BorderSize = 0;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.ForeColor = Color.White;
            btnCerrar.Location = new Point(940, 605);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(225, 60);
            btnCerrar.TabIndex = 5;
            btnCerrar.Text = "Cerrar Detalles";
            btnCerrar.TextColor = Color.White;
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnFiltrosRJ
            // 
            btnFiltrosRJ.BackColor = Color.RoyalBlue;
            btnFiltrosRJ.BackgroundColor = Color.RoyalBlue;
            btnFiltrosRJ.BorderColor = Color.RoyalBlue;
            btnFiltrosRJ.BorderRadius = 10;
            btnFiltrosRJ.BorderSize = 1;
            btnFiltrosRJ.FlatAppearance.BorderSize = 0;
            btnFiltrosRJ.FlatStyle = FlatStyle.Flat;
            btnFiltrosRJ.ForeColor = Color.White;
            btnFiltrosRJ.Location = new Point(976, 415);
            btnFiltrosRJ.Name = "btnFiltrosRJ";
            btnFiltrosRJ.Size = new Size(161, 41);
            btnFiltrosRJ.TabIndex = 59;
            btnFiltrosRJ.Text = "Filtros";
            btnFiltrosRJ.TextColor = Color.White;
            btnFiltrosRJ.UseVisualStyleBackColor = false;
            btnFiltrosRJ.Click += btnFiltrosRJ_Click;
            // 
            // gboxFiltros
            // 
            gboxFiltros.Controls.Add(btnBuscarRJ);
            gboxFiltros.Controls.Add(lblBuscar);
            gboxFiltros.Controls.Add(txtBuscar);
            gboxFiltros.ForeColor = SystemColors.ButtonFace;
            gboxFiltros.Location = new Point(928, 462);
            gboxFiltros.Name = "gboxFiltros";
            gboxFiltros.Size = new Size(256, 137);
            gboxFiltros.TabIndex = 58;
            gboxFiltros.TabStop = false;
            gboxFiltros.Text = "Filtros";
            // 
            // btnBuscarRJ
            // 
            btnBuscarRJ.BackColor = Color.MediumSlateBlue;
            btnBuscarRJ.BackgroundColor = Color.MediumSlateBlue;
            btnBuscarRJ.BorderColor = Color.PaleVioletRed;
            btnBuscarRJ.BorderRadius = 10;
            btnBuscarRJ.BorderSize = 0;
            btnBuscarRJ.FlatAppearance.BorderSize = 0;
            btnBuscarRJ.FlatStyle = FlatStyle.Flat;
            btnBuscarRJ.ForeColor = Color.White;
            btnBuscarRJ.Location = new Point(99, 75);
            btnBuscarRJ.Name = "btnBuscarRJ";
            btnBuscarRJ.Size = new Size(139, 42);
            btnBuscarRJ.TabIndex = 50;
            btnBuscarRJ.Text = "Buscar";
            btnBuscarRJ.TextColor = Color.White;
            btnBuscarRJ.UseVisualStyleBackColor = false;
            btnBuscarRJ.Click += btnBuscarRJ_Click;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(30, 32);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(63, 25);
            lblBuscar.TabIndex = 1;
            lblBuscar.Text = "Buscar";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(99, 29);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(138, 31);
            txtBuscar.TabIndex = 0;
            // 
            // FormPedidos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(1196, 702);
            Controls.Add(btnFiltrosRJ);
            Controls.Add(gboxFiltros);
            Controls.Add(btnCerrar);
            Controls.Add(btnVerDetalles);
            Controls.Add(dgvCompraDetalles);
            Controls.Add(dgvCompra);
            Name = "FormPedidos";
            Text = "FormCompra";
            ((System.ComponentModel.ISupportInitialize)dgvCompra).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCompraDetalles).EndInit();
            gboxFiltros.ResumeLayout(false);
            gboxFiltros.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCompra;
        private DataGridView dgvCompraDetalles;
        private CustomControls.RJControls.RJButton btnVerDetalles;
        private CustomControls.RJControls.RJButton btnCerrar;
        private CustomControls.RJControls.RJButton btnFiltrosRJ;
        private GroupBox gboxFiltros;
        private CustomControls.RJControls.RJButton btnBuscarRJ;
        private Label lblBuscar;
        private TextBox txtBuscar;
    }
}