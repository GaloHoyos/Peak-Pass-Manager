namespace Peak_Pass_Manager
{
    partial class FormOpciones
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
            gboxPermisos = new GroupBox();
            btnGuardarCambios = new CustomControls.RJControls.RJButton();
            btnEliminarRol = new CustomControls.RJControls.RJButton();
            chkAgregarRol = new CheckBox();
            chkEliUsuarios = new CheckBox();
            chkModUsuarios = new CheckBox();
            chkAgUsuarios = new CheckBox();
            chkEliClientes = new CheckBox();
            chkModClientes = new CheckBox();
            chkAgClientes = new CheckBox();
            chkAuditoria = new CheckBox();
            chkReportes = new CheckBox();
            chkEdProductos = new CheckBox();
            chkEdCatalogos = new CheckBox();
            chkEdPermisos = new CheckBox();
            chkUsuarios = new CheckBox();
            chkPedidos = new CheckBox();
            chkOpciones = new CheckBox();
            chkClientes = new CheckBox();
            chkCatalogo = new CheckBox();
            lblRol = new Label();
            cmbRol = new ComboBox();
            gboxRoles = new GroupBox();
            btnAgregarRol = new CustomControls.RJControls.RJButton();
            lblNombreRol = new Label();
            txtRol = new TextBox();
            groupBox1 = new GroupBox();
            btnHabilitarRol = new CustomControls.RJControls.RJButton();
            lblRolInactivo = new Label();
            cmbRolInactivo = new ComboBox();
            btnBackup = new CustomControls.RJControls.RJButton();
            btnRestore = new CustomControls.RJControls.RJButton();
            dgvBackups = new DataGridView();
            label1 = new Label();
            gboxPermisos.SuspendLayout();
            gboxRoles.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBackups).BeginInit();
            SuspendLayout();
            // 
            // gboxPermisos
            // 
            gboxPermisos.Controls.Add(btnGuardarCambios);
            gboxPermisos.Controls.Add(btnEliminarRol);
            gboxPermisos.Controls.Add(chkAgregarRol);
            gboxPermisos.Controls.Add(chkEliUsuarios);
            gboxPermisos.Controls.Add(chkModUsuarios);
            gboxPermisos.Controls.Add(chkAgUsuarios);
            gboxPermisos.Controls.Add(chkEliClientes);
            gboxPermisos.Controls.Add(chkModClientes);
            gboxPermisos.Controls.Add(chkAgClientes);
            gboxPermisos.Controls.Add(chkAuditoria);
            gboxPermisos.Controls.Add(chkReportes);
            gboxPermisos.Controls.Add(chkEdProductos);
            gboxPermisos.Controls.Add(chkEdCatalogos);
            gboxPermisos.Controls.Add(chkEdPermisos);
            gboxPermisos.Controls.Add(chkUsuarios);
            gboxPermisos.Controls.Add(chkPedidos);
            gboxPermisos.Controls.Add(chkOpciones);
            gboxPermisos.Controls.Add(chkClientes);
            gboxPermisos.Controls.Add(chkCatalogo);
            gboxPermisos.Controls.Add(lblRol);
            gboxPermisos.Controls.Add(cmbRol);
            gboxPermisos.ForeColor = SystemColors.ButtonFace;
            gboxPermisos.Location = new Point(608, 13);
            gboxPermisos.Name = "gboxPermisos";
            gboxPermisos.Size = new Size(458, 530);
            gboxPermisos.TabIndex = 4;
            gboxPermisos.TabStop = false;
            gboxPermisos.Text = "Permisos";
            // 
            // btnGuardarCambios
            // 
            btnGuardarCambios.BackColor = Color.LightSkyBlue;
            btnGuardarCambios.BackgroundColor = Color.LightSkyBlue;
            btnGuardarCambios.BorderColor = Color.PaleVioletRed;
            btnGuardarCambios.BorderRadius = 10;
            btnGuardarCambios.BorderSize = 0;
            btnGuardarCambios.FlatAppearance.BorderSize = 0;
            btnGuardarCambios.FlatStyle = FlatStyle.Flat;
            btnGuardarCambios.ForeColor = Color.Black;
            btnGuardarCambios.Location = new Point(287, 437);
            btnGuardarCambios.Name = "btnGuardarCambios";
            btnGuardarCambios.Size = new Size(149, 76);
            btnGuardarCambios.TabIndex = 19;
            btnGuardarCambios.Text = "Guardar Cambios";
            btnGuardarCambios.TextColor = Color.Black;
            btnGuardarCambios.UseVisualStyleBackColor = false;
            btnGuardarCambios.Click += btnGuardarCambios_Click;
            // 
            // btnEliminarRol
            // 
            btnEliminarRol.BackColor = Color.LightSkyBlue;
            btnEliminarRol.BackgroundColor = Color.LightSkyBlue;
            btnEliminarRol.BorderColor = Color.PaleVioletRed;
            btnEliminarRol.BorderRadius = 10;
            btnEliminarRol.BorderSize = 0;
            btnEliminarRol.FlatAppearance.BorderSize = 0;
            btnEliminarRol.FlatStyle = FlatStyle.Flat;
            btnEliminarRol.ForeColor = Color.Black;
            btnEliminarRol.Location = new Point(29, 437);
            btnEliminarRol.Name = "btnEliminarRol";
            btnEliminarRol.Size = new Size(149, 76);
            btnEliminarRol.TabIndex = 18;
            btnEliminarRol.Text = "Eliminar Rol";
            btnEliminarRol.TextColor = Color.Black;
            btnEliminarRol.UseVisualStyleBackColor = false;
            btnEliminarRol.Click += btnEliminarRol_Click_1;
            // 
            // chkAgregarRol
            // 
            chkAgregarRol.AutoSize = true;
            chkAgregarRol.Location = new Point(29, 396);
            chkAgregarRol.Name = "chkAgregarRol";
            chkAgregarRol.Size = new Size(149, 29);
            chkAgregarRol.TabIndex = 17;
            chkAgregarRol.Text = "Agregar Roles";
            chkAgregarRol.UseVisualStyleBackColor = true;
            // 
            // chkEliUsuarios
            // 
            chkEliUsuarios.AutoSize = true;
            chkEliUsuarios.Location = new Point(270, 361);
            chkEliUsuarios.Name = "chkEliUsuarios";
            chkEliUsuarios.Size = new Size(173, 29);
            chkEliUsuarios.TabIndex = 16;
            chkEliUsuarios.Text = "Eliminar Usuarios";
            chkEliUsuarios.UseVisualStyleBackColor = true;
            // 
            // chkModUsuarios
            // 
            chkModUsuarios.AutoSize = true;
            chkModUsuarios.Location = new Point(270, 326);
            chkModUsuarios.Name = "chkModUsuarios";
            chkModUsuarios.Size = new Size(186, 29);
            chkModUsuarios.TabIndex = 15;
            chkModUsuarios.Text = "Modificar Usuarios";
            chkModUsuarios.UseVisualStyleBackColor = true;
            // 
            // chkAgUsuarios
            // 
            chkAgUsuarios.AutoSize = true;
            chkAgUsuarios.Location = new Point(270, 291);
            chkAgUsuarios.Name = "chkAgUsuarios";
            chkAgUsuarios.Size = new Size(175, 29);
            chkAgUsuarios.TabIndex = 14;
            chkAgUsuarios.Text = "Agregar Usuarios";
            chkAgUsuarios.UseVisualStyleBackColor = true;
            // 
            // chkEliClientes
            // 
            chkEliClientes.AutoSize = true;
            chkEliClientes.Location = new Point(270, 256);
            chkEliClientes.Name = "chkEliClientes";
            chkEliClientes.Size = new Size(166, 29);
            chkEliClientes.TabIndex = 13;
            chkEliClientes.Text = "Eliminar Clientes";
            chkEliClientes.UseVisualStyleBackColor = true;
            // 
            // chkModClientes
            // 
            chkModClientes.AutoSize = true;
            chkModClientes.Location = new Point(270, 221);
            chkModClientes.Name = "chkModClientes";
            chkModClientes.Size = new Size(179, 29);
            chkModClientes.TabIndex = 12;
            chkModClientes.Text = "Modificar Clientes";
            chkModClientes.UseVisualStyleBackColor = true;
            // 
            // chkAgClientes
            // 
            chkAgClientes.AutoSize = true;
            chkAgClientes.Location = new Point(270, 186);
            chkAgClientes.Name = "chkAgClientes";
            chkAgClientes.Size = new Size(168, 29);
            chkAgClientes.TabIndex = 11;
            chkAgClientes.Text = "Agregar Clientes";
            chkAgClientes.UseVisualStyleBackColor = true;
            // 
            // chkAuditoria
            // 
            chkAuditoria.AutoSize = true;
            chkAuditoria.Location = new Point(270, 151);
            chkAuditoria.Name = "chkAuditoria";
            chkAuditoria.Size = new Size(141, 29);
            chkAuditoria.TabIndex = 10;
            chkAuditoria.Text = "Ver Auditoria";
            chkAuditoria.UseVisualStyleBackColor = true;
            // 
            // chkReportes
            // 
            chkReportes.AutoSize = true;
            chkReportes.Location = new Point(270, 116);
            chkReportes.Name = "chkReportes";
            chkReportes.Size = new Size(138, 29);
            chkReportes.TabIndex = 9;
            chkReportes.Text = "Ver Reportes";
            chkReportes.UseVisualStyleBackColor = true;
            // 
            // chkEdProductos
            // 
            chkEdProductos.AutoSize = true;
            chkEdProductos.Location = new Point(29, 361);
            chkEdProductos.Name = "chkEdProductos";
            chkEdProductos.Size = new Size(169, 29);
            chkEdProductos.TabIndex = 8;
            chkEdProductos.Text = "Editar Productos";
            chkEdProductos.UseVisualStyleBackColor = true;
            // 
            // chkEdCatalogos
            // 
            chkEdCatalogos.AutoSize = true;
            chkEdCatalogos.Location = new Point(29, 326);
            chkEdCatalogos.Name = "chkEdCatalogos";
            chkEdCatalogos.Size = new Size(168, 29);
            chkEdCatalogos.TabIndex = 7;
            chkEdCatalogos.Text = "Editar Catalogos";
            chkEdCatalogos.UseVisualStyleBackColor = true;
            // 
            // chkEdPermisos
            // 
            chkEdPermisos.AutoSize = true;
            chkEdPermisos.Location = new Point(29, 291);
            chkEdPermisos.Name = "chkEdPermisos";
            chkEdPermisos.Size = new Size(159, 29);
            chkEdPermisos.TabIndex = 6;
            chkEdPermisos.Text = "Editar Permisos";
            chkEdPermisos.UseVisualStyleBackColor = true;
            // 
            // chkUsuarios
            // 
            chkUsuarios.AutoSize = true;
            chkUsuarios.Location = new Point(29, 256);
            chkUsuarios.Name = "chkUsuarios";
            chkUsuarios.Size = new Size(136, 29);
            chkUsuarios.TabIndex = 5;
            chkUsuarios.Text = "Ver Usuarios";
            chkUsuarios.UseVisualStyleBackColor = true;
            // 
            // chkPedidos
            // 
            chkPedidos.AutoSize = true;
            chkPedidos.Location = new Point(29, 221);
            chkPedidos.Name = "chkPedidos";
            chkPedidos.Size = new Size(131, 29);
            chkPedidos.TabIndex = 5;
            chkPedidos.Text = "Ver Pedidos";
            chkPedidos.UseVisualStyleBackColor = true;
            // 
            // chkOpciones
            // 
            chkOpciones.AutoSize = true;
            chkOpciones.Location = new Point(29, 186);
            chkOpciones.Name = "chkOpciones";
            chkOpciones.Size = new Size(143, 29);
            chkOpciones.TabIndex = 4;
            chkOpciones.Text = "Ver Opciones";
            chkOpciones.UseVisualStyleBackColor = true;
            // 
            // chkClientes
            // 
            chkClientes.AutoSize = true;
            chkClientes.Location = new Point(29, 151);
            chkClientes.Name = "chkClientes";
            chkClientes.Size = new Size(129, 29);
            chkClientes.TabIndex = 3;
            chkClientes.Text = "Ver Clientes";
            chkClientes.UseVisualStyleBackColor = true;
            // 
            // chkCatalogo
            // 
            chkCatalogo.AutoSize = true;
            chkCatalogo.Location = new Point(29, 116);
            chkCatalogo.Name = "chkCatalogo";
            chkCatalogo.Size = new Size(140, 29);
            chkCatalogo.TabIndex = 2;
            chkCatalogo.Text = "Ver Catalogo";
            chkCatalogo.UseVisualStyleBackColor = true;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Location = new Point(60, 55);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(37, 25);
            lblRol.TabIndex = 1;
            lblRol.Text = "Rol";
            // 
            // cmbRol
            // 
            cmbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRol.FormattingEnabled = true;
            cmbRol.Location = new Point(103, 52);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(182, 33);
            cmbRol.TabIndex = 0;
            cmbRol.SelectedIndexChanged += cmbRol_SelectedIndexChanged;
            // 
            // gboxRoles
            // 
            gboxRoles.Controls.Add(btnAgregarRol);
            gboxRoles.Controls.Add(lblNombreRol);
            gboxRoles.Controls.Add(txtRol);
            gboxRoles.ForeColor = SystemColors.ButtonFace;
            gboxRoles.Location = new Point(164, 13);
            gboxRoles.Name = "gboxRoles";
            gboxRoles.Size = new Size(428, 178);
            gboxRoles.TabIndex = 6;
            gboxRoles.TabStop = false;
            gboxRoles.Text = "Roles";
            // 
            // btnAgregarRol
            // 
            btnAgregarRol.BackColor = Color.LightSkyBlue;
            btnAgregarRol.BackgroundColor = Color.LightSkyBlue;
            btnAgregarRol.BorderColor = Color.PaleVioletRed;
            btnAgregarRol.BorderRadius = 10;
            btnAgregarRol.BorderSize = 0;
            btnAgregarRol.FlatAppearance.BorderSize = 0;
            btnAgregarRol.FlatStyle = FlatStyle.Flat;
            btnAgregarRol.ForeColor = Color.Black;
            btnAgregarRol.Location = new Point(173, 116);
            btnAgregarRol.Name = "btnAgregarRol";
            btnAgregarRol.Size = new Size(149, 38);
            btnAgregarRol.TabIndex = 3;
            btnAgregarRol.Text = "Agregar Rol";
            btnAgregarRol.TextColor = Color.Black;
            btnAgregarRol.UseVisualStyleBackColor = false;
            btnAgregarRol.Click += btnAgregarRol_Click_1;
            // 
            // lblNombreRol
            // 
            lblNombreRol.AutoSize = true;
            lblNombreRol.Location = new Point(30, 71);
            lblNombreRol.Name = "lblNombreRol";
            lblNombreRol.Size = new Size(137, 25);
            lblNombreRol.TabIndex = 1;
            lblNombreRol.Text = "Nombre de Rol:";
            // 
            // txtRol
            // 
            txtRol.Location = new Point(173, 68);
            txtRol.Name = "txtRol";
            txtRol.Size = new Size(150, 31);
            txtRol.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnHabilitarRol);
            groupBox1.Controls.Add(lblRolInactivo);
            groupBox1.Controls.Add(cmbRolInactivo);
            groupBox1.ForeColor = SystemColors.ButtonFace;
            groupBox1.Location = new Point(164, 190);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(428, 178);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Roles Inactivos";
            // 
            // btnHabilitarRol
            // 
            btnHabilitarRol.BackColor = Color.LightSkyBlue;
            btnHabilitarRol.BackgroundColor = Color.LightSkyBlue;
            btnHabilitarRol.BorderColor = Color.PaleVioletRed;
            btnHabilitarRol.BorderRadius = 10;
            btnHabilitarRol.BorderSize = 0;
            btnHabilitarRol.FlatAppearance.BorderSize = 0;
            btnHabilitarRol.FlatStyle = FlatStyle.Flat;
            btnHabilitarRol.ForeColor = Color.Black;
            btnHabilitarRol.Location = new Point(173, 124);
            btnHabilitarRol.Name = "btnHabilitarRol";
            btnHabilitarRol.Size = new Size(149, 38);
            btnHabilitarRol.TabIndex = 21;
            btnHabilitarRol.Text = "Habilitar Rol";
            btnHabilitarRol.TextColor = Color.Black;
            btnHabilitarRol.UseVisualStyleBackColor = false;
            btnHabilitarRol.Click += btnHabilitarRol_Click_1;
            // 
            // lblRolInactivo
            // 
            lblRolInactivo.AutoSize = true;
            lblRolInactivo.Location = new Point(98, 70);
            lblRolInactivo.Name = "lblRolInactivo";
            lblRolInactivo.Size = new Size(37, 25);
            lblRolInactivo.TabIndex = 20;
            lblRolInactivo.Text = "Rol";
            // 
            // cmbRolInactivo
            // 
            cmbRolInactivo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRolInactivo.FormattingEnabled = true;
            cmbRolInactivo.Location = new Point(141, 66);
            cmbRolInactivo.Name = "cmbRolInactivo";
            cmbRolInactivo.Size = new Size(182, 33);
            cmbRolInactivo.TabIndex = 19;
            // 
            // btnBackup
            // 
            btnBackup.BackColor = Color.MediumSlateBlue;
            btnBackup.BackgroundColor = Color.MediumSlateBlue;
            btnBackup.BorderColor = Color.PaleVioletRed;
            btnBackup.BorderRadius = 10;
            btnBackup.BorderSize = 0;
            btnBackup.FlatAppearance.BorderSize = 0;
            btnBackup.FlatStyle = FlatStyle.Flat;
            btnBackup.ForeColor = Color.White;
            btnBackup.Location = new Point(841, 555);
            btnBackup.Name = "btnBackup";
            btnBackup.Size = new Size(225, 135);
            btnBackup.TabIndex = 10;
            btnBackup.Text = "Backup";
            btnBackup.TextColor = Color.White;
            btnBackup.UseVisualStyleBackColor = false;
            btnBackup.Click += btnBackup_Click;
            // 
            // btnRestore
            // 
            btnRestore.BackColor = Color.Magenta;
            btnRestore.BackgroundColor = Color.Magenta;
            btnRestore.BorderColor = Color.PaleVioletRed;
            btnRestore.BorderRadius = 10;
            btnRestore.BorderSize = 0;
            btnRestore.FlatAppearance.BorderSize = 0;
            btnRestore.FlatStyle = FlatStyle.Flat;
            btnRestore.ForeColor = Color.White;
            btnRestore.Location = new Point(608, 594);
            btnRestore.Name = "btnRestore";
            btnRestore.Size = new Size(145, 56);
            btnRestore.TabIndex = 9;
            btnRestore.Text = "Restaurar";
            btnRestore.TextColor = Color.White;
            btnRestore.UseVisualStyleBackColor = false;
            btnRestore.Click += btnRestore_Click;
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
            dgvBackups.Location = new Point(164, 409);
            dgvBackups.Name = "dgvBackups";
            dgvBackups.RowHeadersWidth = 62;
            dgvBackups.RowTemplate.Height = 33;
            dgvBackups.Size = new Size(428, 281);
            dgvBackups.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(164, 378);
            label1.Name = "label1";
            label1.Size = new Size(224, 25);
            label1.TabIndex = 11;
            label1.Text = "Backups de Base de Datos:";
            // 
            // FormOpciones
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(1196, 702);
            Controls.Add(label1);
            Controls.Add(btnBackup);
            Controls.Add(btnRestore);
            Controls.Add(dgvBackups);
            Controls.Add(groupBox1);
            Controls.Add(gboxRoles);
            Controls.Add(gboxPermisos);
            Name = "FormOpciones";
            Text = "FormOpciones";
            gboxPermisos.ResumeLayout(false);
            gboxPermisos.PerformLayout();
            gboxRoles.ResumeLayout(false);
            gboxRoles.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBackups).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox gboxPermisos;
        private Label lblRol;
        private ComboBox cmbRol;
        private CheckBox chkAuditoria;
        private CheckBox chkReportes;
        private CheckBox chkEdProductos;
        private CheckBox chkEdCatalogos;
        private CheckBox chkEdPermisos;
        private CheckBox chkUsuarios;
        private CheckBox chkPedidos;
        private CheckBox chkOpciones;
        private CheckBox chkClientes;
        private CheckBox chkCatalogo;
        private CheckBox chkAgClientes;
        private CheckBox chkEliUsuarios;
        private CheckBox chkModUsuarios;
        private CheckBox chkAgUsuarios;
        private CheckBox chkEliClientes;
        private CheckBox chkModClientes;
        private CheckBox chkAgregarRol;
        private GroupBox gboxRoles;
        private Label lblNombreRol;
        private TextBox txtRol;
        private GroupBox groupBox1;
        private Label lblRolInactivo;
        private ComboBox cmbRolInactivo;
        private CustomControls.RJControls.RJButton btnBackup;
        private CustomControls.RJControls.RJButton btnRestore;
        private DataGridView dgvBackups;
        private Label label1;
        private CustomControls.RJControls.RJButton btnAgregarRol;
        private CustomControls.RJControls.RJButton btnEliminarRol;
        private CustomControls.RJControls.RJButton btnHabilitarRol;
        private CustomControls.RJControls.RJButton btnGuardarCambios;
    }
}