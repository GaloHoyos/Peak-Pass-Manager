namespace Peak_Pass_Manager
{
    partial class FormLogin
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
            panel1 = new Panel();
            picLogo = new PictureBox();
            txtUsuario = new TextBox();
            txtContra = new TextBox();
            lblLogin = new Label();
            btnAcceder = new Button();
            linkLabel1 = new LinkLabel();
            iconCerrar = new FontAwesome.Sharp.IconPictureBox();
            iconMinimizar = new FontAwesome.Sharp.IconPictureBox();
            lblMensajeError = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconMinimizar).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(34, 33, 74);
            panel1.Controls.Add(picLogo);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 330);
            panel1.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.Image = Properties.Resources.Peak_Pass_Manager_Logo;
            picLogo.Location = new Point(3, 24);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(244, 294);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.FromArgb(15, 15, 15);
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.ForeColor = Color.DimGray;
            txtUsuario.Location = new Point(329, 96);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(355, 31);
            txtUsuario.TabIndex = 1;
            txtUsuario.Text = "USUARIO";
            txtUsuario.Enter += txtUsuario_Enter;
            txtUsuario.Leave += txtUsuario_Leave;
            // 
            // txtContra
            // 
            txtContra.BackColor = Color.FromArgb(15, 15, 15);
            txtContra.BorderStyle = BorderStyle.FixedSingle;
            txtContra.ForeColor = Color.DimGray;
            txtContra.Location = new Point(329, 148);
            txtContra.Name = "txtContra";
            txtContra.Size = new Size(355, 31);
            txtContra.TabIndex = 2;
            txtContra.Text = "CONTRASEÑA";
            txtContra.Enter += txtContra_Enter;
            txtContra.Leave += txtContra_Leave;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.ForeColor = SystemColors.ControlLight;
            lblLogin.Location = new Point(482, 24);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(63, 25);
            lblLogin.TabIndex = 3;
            lblLogin.Text = "LOGIN";
            // 
            // btnAcceder
            // 
            btnAcceder.BackColor = Color.FromArgb(40, 40, 40);
            btnAcceder.FlatAppearance.BorderSize = 0;
            btnAcceder.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnAcceder.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnAcceder.FlatStyle = FlatStyle.Flat;
            btnAcceder.ForeColor = SystemColors.ControlLight;
            btnAcceder.Location = new Point(301, 214);
            btnAcceder.Name = "btnAcceder";
            btnAcceder.Size = new Size(408, 40);
            btnAcceder.TabIndex = 3;
            btnAcceder.Text = "ACCEDER";
            btnAcceder.UseVisualStyleBackColor = false;
            btnAcceder.Click += btnAcceder_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.FromArgb(34, 33, 74);
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.DimGray;
            linkLabel1.Location = new Point(348, 285);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(301, 23);
            linkLabel1.TabIndex = 0;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "¿Ha olvidado su contraseña?";
            // 
            // iconCerrar
            // 
            iconCerrar.BackColor = Color.FromArgb(15, 15, 15);
            iconCerrar.ForeColor = Color.DimGray;
            iconCerrar.IconChar = FontAwesome.Sharp.IconChar.X;
            iconCerrar.IconColor = Color.DimGray;
            iconCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconCerrar.IconSize = 31;
            iconCerrar.Location = new Point(736, 12);
            iconCerrar.Name = "iconCerrar";
            iconCerrar.Size = new Size(32, 31);
            iconCerrar.TabIndex = 6;
            iconCerrar.TabStop = false;
            iconCerrar.Click += iconCerrar_Click;
            iconCerrar.MouseEnter += iconCerrar_MouseEnter;
            iconCerrar.MouseLeave += iconCerrar_MouseLeave;
            // 
            // iconMinimizar
            // 
            iconMinimizar.BackColor = Color.FromArgb(15, 15, 15);
            iconMinimizar.ForeColor = Color.DimGray;
            iconMinimizar.IconChar = FontAwesome.Sharp.IconChar.Minus;
            iconMinimizar.IconColor = Color.DimGray;
            iconMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMinimizar.IconSize = 37;
            iconMinimizar.Location = new Point(692, 12);
            iconMinimizar.Name = "iconMinimizar";
            iconMinimizar.Size = new Size(38, 37);
            iconMinimizar.TabIndex = 7;
            iconMinimizar.TabStop = false;
            iconMinimizar.Click += iconMinimizar_Click;
            iconMinimizar.MouseEnter += iconMinimizar_MouseEnter;
            iconMinimizar.MouseLeave += iconMinimizar_MouseLeave;
            // 
            // lblMensajeError
            // 
            lblMensajeError.AutoSize = true;
            lblMensajeError.ForeColor = Color.Red;
            lblMensajeError.Location = new Point(341, 184);
            lblMensajeError.Name = "lblMensajeError";
            lblMensajeError.Size = new Size(120, 25);
            lblMensajeError.TabIndex = 8;
            lblMensajeError.Text = "Mensaje Error";
            lblMensajeError.Visible = false;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(780, 330);
            Controls.Add(lblMensajeError);
            Controls.Add(iconMinimizar);
            Controls.Add(iconCerrar);
            Controls.Add(linkLabel1);
            Controls.Add(btnAcceder);
            Controls.Add(lblLogin);
            Controls.Add(txtContra);
            Controls.Add(txtUsuario);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLogin";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLogin";
            MouseDown += FormLogin_MouseDown;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconMinimizar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox txtUsuario;
        private TextBox txtContra;
        private Label lblLogin;
        private Button btnAcceder;
        private LinkLabel linkLabel1;
        private FontAwesome.Sharp.IconPictureBox iconCerrar;
        private FontAwesome.Sharp.IconPictureBox iconMinimizar;
        private PictureBox picLogo;
        private Label lblMensajeError;
    }
}