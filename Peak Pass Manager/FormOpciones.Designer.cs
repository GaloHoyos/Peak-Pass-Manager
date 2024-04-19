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
            lblOpciones = new Label();
            gboxPermisos = new GroupBox();
            btnEliminarRol = new Button();
            chkAgregarRol = new CheckBox();
            btnGuardar = new FontAwesome.Sharp.IconButton();
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
            btnAgregarRol = new Button();
            lblNombreRol = new Label();
            txtRol = new TextBox();
            gboxPermisos.SuspendLayout();
            gboxRoles.SuspendLayout();
            SuspendLayout();
            // 
            // lblOpciones
            // 
            lblOpciones.AutoSize = true;
            lblOpciones.ForeColor = Color.Gainsboro;
            lblOpciones.Location = new Point(126, 37);
            lblOpciones.Name = "lblOpciones";
            lblOpciones.Size = new Size(87, 25);
            lblOpciones.TabIndex = 3;
            lblOpciones.Text = "Opciones";
            // 
            // gboxPermisos
            // 
            gboxPermisos.Controls.Add(btnEliminarRol);
            gboxPermisos.Controls.Add(chkAgregarRol);
            gboxPermisos.Controls.Add(btnGuardar);
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
            gboxPermisos.Location = new Point(705, 111);
            gboxPermisos.Name = "gboxPermisos";
            gboxPermisos.Size = new Size(458, 530);
            gboxPermisos.TabIndex = 4;
            gboxPermisos.TabStop = false;
            gboxPermisos.Text = "Permisos";
            // 
            // btnEliminarRol
            // 
            btnEliminarRol.ForeColor = SystemColors.ActiveCaptionText;
            btnEliminarRol.Location = new Point(29, 437);
            btnEliminarRol.Name = "btnEliminarRol";
            btnEliminarRol.Size = new Size(128, 73);
            btnEliminarRol.TabIndex = 18;
            btnEliminarRol.Text = "Eliminar Rol";
            btnEliminarRol.UseVisualStyleBackColor = true;
            btnEliminarRol.Click += btnEliminarRol_Click;
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
            // btnGuardar
            // 
            btnGuardar.ForeColor = SystemColors.ActiveCaptionText;
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnGuardar.IconColor = Color.Black;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.Location = new Point(310, 437);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(133, 76);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar Cambios";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
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
            lblRol.Location = new Point(29, 55);
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
            gboxRoles.Location = new Point(253, 121);
            gboxRoles.Name = "gboxRoles";
            gboxRoles.Size = new Size(428, 178);
            gboxRoles.TabIndex = 6;
            gboxRoles.TabStop = false;
            gboxRoles.Text = "Roles";
            // 
            // btnAgregarRol
            // 
            btnAgregarRol.ForeColor = SystemColors.ActiveCaptionText;
            btnAgregarRol.Location = new Point(188, 118);
            btnAgregarRol.Name = "btnAgregarRol";
            btnAgregarRol.Size = new Size(122, 34);
            btnAgregarRol.TabIndex = 2;
            btnAgregarRol.Text = "Agregar Rol";
            btnAgregarRol.UseVisualStyleBackColor = true;
            btnAgregarRol.Click += btnAgregarRol_Click;
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
            // FormOpciones
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(1196, 702);
            Controls.Add(gboxRoles);
            Controls.Add(gboxPermisos);
            Controls.Add(lblOpciones);
            Name = "FormOpciones";
            Text = "FormOpciones";
            gboxPermisos.ResumeLayout(false);
            gboxPermisos.PerformLayout();
            gboxRoles.ResumeLayout(false);
            gboxRoles.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOpciones;
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
        private FontAwesome.Sharp.IconButton btnGuardar;
        private CheckBox chkAgregarRol;
        private GroupBox gboxRoles;
        private Button btnAgregarRol;
        private Label lblNombreRol;
        private TextBox txtRol;
        private Button btnEliminarRol;
    }
}