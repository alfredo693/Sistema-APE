namespace Sistema_APE
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btnAcceder = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BarraInicio = new System.Windows.Forms.Panel();
            this.picMinimizarCerrar = new System.Windows.Forms.PictureBox();
            this.picCerrar = new System.Windows.Forms.PictureBox();
            this.picPerfil = new System.Windows.Forms.PictureBox();
            this.BarraInicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizarCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAcceder
            // 
            this.btnAcceder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAcceder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(63)))), ((int)(((byte)(92)))));
            this.btnAcceder.FlatAppearance.BorderSize = 0;
            this.btnAcceder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(92)))), ((int)(((byte)(249)))));
            this.btnAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcceder.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcceder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(63)))), ((int)(((byte)(92)))));
            this.btnAcceder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAcceder.Location = new System.Drawing.Point(106, 332);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(146, 35);
            this.btnAcceder.TabIndex = 26;
            this.btnAcceder.Text = "Acceder";
            this.btnAcceder.UseVisualStyleBackColor = false;
            this.btnAcceder.Click += new System.EventHandler(this.btnAcceder_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Thistle;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(106, 276);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(142, 28);
            this.txtPassword.TabIndex = 25;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.Thistle;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(106, 241);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUsuario.Multiline = true;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(141, 28);
            this.txtUsuario.TabIndex = 24;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.Indigo;
            this.lblPassword.Location = new System.Drawing.Point(22, 276);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(78, 20);
            this.lblPassword.TabIndex = 23;
            this.lblPassword.Text = "Password";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.Indigo;
            this.lblUsuario.Location = new System.Drawing.Point(37, 246);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(64, 20);
            this.lblUsuario.TabIndex = 22;
            this.lblUsuario.Text = "Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(29)))), ((int)(((byte)(13)))));
            this.label1.Location = new System.Drawing.Point(92, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 26);
            this.label1.TabIndex = 19;
            this.label1.Text = "Inicio de sesión";
            // 
            // BarraInicio
            // 
            this.BarraInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(92)))), ((int)(((byte)(249)))));
            this.BarraInicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BarraInicio.Controls.Add(this.picMinimizarCerrar);
            this.BarraInicio.Controls.Add(this.picCerrar);
            this.BarraInicio.Location = new System.Drawing.Point(-6, -2);
            this.BarraInicio.Name = "BarraInicio";
            this.BarraInicio.Size = new System.Drawing.Size(326, 37);
            this.BarraInicio.TabIndex = 28;
            this.BarraInicio.Paint += new System.Windows.Forms.PaintEventHandler(this.BarraInicio_Paint);
            // 
            // picMinimizarCerrar
            // 
            this.picMinimizarCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picMinimizarCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMinimizarCerrar.Location = new System.Drawing.Point(255, 9);
            this.picMinimizarCerrar.Name = "picMinimizarCerrar";
            this.picMinimizarCerrar.Size = new System.Drawing.Size(25, 25);
            this.picMinimizarCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMinimizarCerrar.TabIndex = 6;
            this.picMinimizarCerrar.TabStop = false;
            this.picMinimizarCerrar.Click += new System.EventHandler(this.picMinimizarCerrar_Click);
            // 
            // picCerrar
            // 
            this.picCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCerrar.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picCerrar.ErrorImage")));
            this.picCerrar.Image = ((System.Drawing.Image)(resources.GetObject("picCerrar.Image")));
            this.picCerrar.InitialImage = ((System.Drawing.Image)(resources.GetObject("picCerrar.InitialImage")));
            this.picCerrar.Location = new System.Drawing.Point(291, 7);
            this.picCerrar.Name = "picCerrar";
            this.picCerrar.Size = new System.Drawing.Size(25, 25);
            this.picCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCerrar.TabIndex = 5;
            this.picCerrar.TabStop = false;
            this.picCerrar.Click += new System.EventHandler(this.picCerrar_Click);
            // 
            // picPerfil
            // 
            this.picPerfil.Image = global::Sistema_APE.Properties.Resources.administrador;
            this.picPerfil.Location = new System.Drawing.Point(113, 81);
            this.picPerfil.Name = "picPerfil";
            this.picPerfil.Size = new System.Drawing.Size(106, 93);
            this.picPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPerfil.TabIndex = 27;
            this.picPerfil.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 417);
            this.Controls.Add(this.BarraInicio);
            this.Controls.Add(this.picPerfil);
            this.Controls.Add(this.btnAcceder);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.BarraInicio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizarCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPerfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAcceder;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picPerfil;
        private System.Windows.Forms.PictureBox picMinimizarCerrar;
        private System.Windows.Forms.PictureBox picCerrar;
        private System.Windows.Forms.Panel BarraInicio;
    }
}