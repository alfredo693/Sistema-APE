namespace Sistema_APE
{
    partial class Docente
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
            this.btnListaProfes = new System.Windows.Forms.Button();
            this.btnVerTodosProfes = new System.Windows.Forms.Button();
            this.grpBusquedaProf = new System.Windows.Forms.GroupBox();
            this.radIDProfe = new System.Windows.Forms.RadioButton();
            this.radCedula = new System.Windows.Forms.RadioButton();
            this.radNombreProfe = new System.Windows.Forms.RadioButton();
            this.radUsuarioProfe = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBuscarProfe = new System.Windows.Forms.Button();
            this.txtBuscarProfe = new System.Windows.Forms.TextBox();
            this.btnEliminarProfe = new System.Windows.Forms.Button();
            this.btnModificarProfe = new System.Windows.Forms.Button();
            this.dtgProfesor = new System.Windows.Forms.DataGridView();
            this.btnRegistrarProfesor = new System.Windows.Forms.Button();
            this.grpProfesor = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.txtcedula = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.cboGrupo = new System.Windows.Forms.ComboBox();
            this.lblCedula = new System.Windows.Forms.Label();
            this.txtnombreProfe = new System.Windows.Forms.TextBox();
            this.lblGrupoAsignado = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtIDprofe = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grpBusquedaProf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProfesor)).BeginInit();
            this.grpProfesor.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnListaProfes
            // 
            this.btnListaProfes.Location = new System.Drawing.Point(1064, 554);
            this.btnListaProfes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnListaProfes.Name = "btnListaProfes";
            this.btnListaProfes.Size = new System.Drawing.Size(139, 50);
            this.btnListaProfes.TabIndex = 23;
            this.btnListaProfes.Text = "Guardar lista";
            this.btnListaProfes.UseVisualStyleBackColor = true;
            this.btnListaProfes.Click += new System.EventHandler(this.btnListaProfes_Click);
            // 
            // btnVerTodosProfes
            // 
            this.btnVerTodosProfes.Location = new System.Drawing.Point(902, 554);
            this.btnVerTodosProfes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVerTodosProfes.Name = "btnVerTodosProfes";
            this.btnVerTodosProfes.Size = new System.Drawing.Size(139, 50);
            this.btnVerTodosProfes.TabIndex = 22;
            this.btnVerTodosProfes.Text = "Ver todos los profesores";
            this.btnVerTodosProfes.UseVisualStyleBackColor = true;
            this.btnVerTodosProfes.Click += new System.EventHandler(this.btnVerTodosProfes_Click);
            // 
            // grpBusquedaProf
            // 
            this.grpBusquedaProf.Controls.Add(this.radIDProfe);
            this.grpBusquedaProf.Controls.Add(this.radCedula);
            this.grpBusquedaProf.Controls.Add(this.radNombreProfe);
            this.grpBusquedaProf.Controls.Add(this.radUsuarioProfe);
            this.grpBusquedaProf.Controls.Add(this.label6);
            this.grpBusquedaProf.Controls.Add(this.btnBuscarProfe);
            this.grpBusquedaProf.Controls.Add(this.txtBuscarProfe);
            this.grpBusquedaProf.Location = new System.Drawing.Point(902, 226);
            this.grpBusquedaProf.Margin = new System.Windows.Forms.Padding(4);
            this.grpBusquedaProf.Name = "grpBusquedaProf";
            this.grpBusquedaProf.Padding = new System.Windows.Forms.Padding(4);
            this.grpBusquedaProf.Size = new System.Drawing.Size(316, 223);
            this.grpBusquedaProf.TabIndex = 21;
            this.grpBusquedaProf.TabStop = false;
            this.grpBusquedaProf.Text = "Buscar Profesor";
            // 
            // radIDProfe
            // 
            this.radIDProfe.AutoSize = true;
            this.radIDProfe.Location = new System.Drawing.Point(12, 181);
            this.radIDProfe.Margin = new System.Windows.Forms.Padding(4);
            this.radIDProfe.Name = "radIDProfe";
            this.radIDProfe.Size = new System.Drawing.Size(41, 20);
            this.radIDProfe.TabIndex = 6;
            this.radIDProfe.Text = "ID";
            this.radIDProfe.UseVisualStyleBackColor = true;
            // 
            // radCedula
            // 
            this.radCedula.AutoSize = true;
            this.radCedula.Location = new System.Drawing.Point(12, 153);
            this.radCedula.Margin = new System.Windows.Forms.Padding(4);
            this.radCedula.Name = "radCedula";
            this.radCedula.Size = new System.Drawing.Size(71, 20);
            this.radCedula.TabIndex = 5;
            this.radCedula.Text = "Cedula";
            this.radCedula.UseVisualStyleBackColor = true;
            // 
            // radNombreProfe
            // 
            this.radNombreProfe.AutoSize = true;
            this.radNombreProfe.Location = new System.Drawing.Point(12, 126);
            this.radNombreProfe.Margin = new System.Windows.Forms.Padding(4);
            this.radNombreProfe.Name = "radNombreProfe";
            this.radNombreProfe.Size = new System.Drawing.Size(77, 20);
            this.radNombreProfe.TabIndex = 4;
            this.radNombreProfe.Text = "Nombre";
            this.radNombreProfe.UseVisualStyleBackColor = true;
            // 
            // radUsuarioProfe
            // 
            this.radUsuarioProfe.AutoSize = true;
            this.radUsuarioProfe.Checked = true;
            this.radUsuarioProfe.Location = new System.Drawing.Point(12, 97);
            this.radUsuarioProfe.Margin = new System.Windows.Forms.Padding(4);
            this.radUsuarioProfe.Name = "radUsuarioProfe";
            this.radUsuarioProfe.Size = new System.Drawing.Size(75, 20);
            this.radUsuarioProfe.TabIndex = 3;
            this.radUsuarioProfe.TabStop = true;
            this.radUsuarioProfe.Text = "Usuario";
            this.radUsuarioProfe.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 74);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Por:";
            // 
            // btnBuscarProfe
            // 
            this.btnBuscarProfe.Location = new System.Drawing.Point(185, 33);
            this.btnBuscarProfe.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarProfe.Name = "btnBuscarProfe";
            this.btnBuscarProfe.Size = new System.Drawing.Size(100, 28);
            this.btnBuscarProfe.TabIndex = 1;
            this.btnBuscarProfe.Text = "Buscar";
            this.btnBuscarProfe.UseVisualStyleBackColor = true;
            this.btnBuscarProfe.Click += new System.EventHandler(this.btnBuscarProfe_Click);
            // 
            // txtBuscarProfe
            // 
            this.txtBuscarProfe.Location = new System.Drawing.Point(8, 36);
            this.txtBuscarProfe.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarProfe.Name = "txtBuscarProfe";
            this.txtBuscarProfe.Size = new System.Drawing.Size(156, 22);
            this.txtBuscarProfe.TabIndex = 0;
            // 
            // btnEliminarProfe
            // 
            this.btnEliminarProfe.Location = new System.Drawing.Point(902, 477);
            this.btnEliminarProfe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarProfe.Name = "btnEliminarProfe";
            this.btnEliminarProfe.Size = new System.Drawing.Size(139, 50);
            this.btnEliminarProfe.TabIndex = 20;
            this.btnEliminarProfe.Text = "Eliminar Profesor";
            this.btnEliminarProfe.UseVisualStyleBackColor = true;
            this.btnEliminarProfe.Click += new System.EventHandler(this.btnEliminarProfe_Click);
            // 
            // btnModificarProfe
            // 
            this.btnModificarProfe.Location = new System.Drawing.Point(928, 106);
            this.btnModificarProfe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificarProfe.Name = "btnModificarProfe";
            this.btnModificarProfe.Size = new System.Drawing.Size(139, 50);
            this.btnModificarProfe.TabIndex = 19;
            this.btnModificarProfe.Text = "Modificar Profesor";
            this.btnModificarProfe.UseVisualStyleBackColor = true;
            this.btnModificarProfe.Click += new System.EventHandler(this.btnModificarProfe_Click);
            // 
            // dtgProfesor
            // 
            this.dtgProfesor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProfesor.Location = new System.Drawing.Point(27, 226);
            this.dtgProfesor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgProfesor.Name = "dtgProfesor";
            this.dtgProfesor.RowHeadersWidth = 51;
            this.dtgProfesor.RowTemplate.Height = 24;
            this.dtgProfesor.Size = new System.Drawing.Size(853, 394);
            this.dtgProfesor.TabIndex = 18;
            this.dtgProfesor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProfesor_CellClick);
            // 
            // btnRegistrarProfesor
            // 
            this.btnRegistrarProfesor.Location = new System.Drawing.Point(928, 36);
            this.btnRegistrarProfesor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistrarProfesor.Name = "btnRegistrarProfesor";
            this.btnRegistrarProfesor.Size = new System.Drawing.Size(139, 48);
            this.btnRegistrarProfesor.TabIndex = 17;
            this.btnRegistrarProfesor.Text = "Registrar Profesor";
            this.btnRegistrarProfesor.UseVisualStyleBackColor = true;
            this.btnRegistrarProfesor.Click += new System.EventHandler(this.btnRegistrarProfesor_Click);
            // 
            // grpProfesor
            // 
            this.grpProfesor.Controls.Add(this.txtPassword);
            this.grpProfesor.Controls.Add(this.lblPassword);
            this.grpProfesor.Controls.Add(this.txtusuario);
            this.grpProfesor.Controls.Add(this.txtcedula);
            this.grpProfesor.Controls.Add(this.lblUsuario);
            this.grpProfesor.Controls.Add(this.cboGrupo);
            this.grpProfesor.Controls.Add(this.lblCedula);
            this.grpProfesor.Controls.Add(this.txtnombreProfe);
            this.grpProfesor.Controls.Add(this.lblGrupoAsignado);
            this.grpProfesor.Controls.Add(this.lblNombre);
            this.grpProfesor.Controls.Add(this.txtIDprofe);
            this.grpProfesor.Controls.Add(this.lblId);
            this.grpProfesor.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpProfesor.Location = new System.Drawing.Point(27, 25);
            this.grpProfesor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpProfesor.Name = "grpProfesor";
            this.grpProfesor.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpProfesor.Size = new System.Drawing.Size(853, 180);
            this.grpProfesor.TabIndex = 16;
            this.grpProfesor.TabStop = false;
            this.grpProfesor.Text = "DOCENTE";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(131, 129);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(143, 30);
            this.txtPassword.TabIndex = 12;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(16, 129);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(90, 24);
            this.lblPassword.TabIndex = 11;
            this.lblPassword.Text = "Password";
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(131, 80);
            this.txtusuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(143, 30);
            this.txtusuario.TabIndex = 10;
            // 
            // txtcedula
            // 
            this.txtcedula.Location = new System.Drawing.Point(521, 81);
            this.txtcedula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcedula.Name = "txtcedula";
            this.txtcedula.Size = new System.Drawing.Size(143, 30);
            this.txtcedula.TabIndex = 7;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(32, 80);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(74, 24);
            this.lblUsuario.TabIndex = 9;
            this.lblUsuario.Text = "Usuario";
            // 
            // cboGrupo
            // 
            this.cboGrupo.FormattingEnabled = true;
            this.cboGrupo.Items.AddRange(new object[] {
            "1ºA",
            "1ºB",
            "1ºC",
            "2ºA",
            "2ºB",
            "2ºC",
            "3ºA",
            "3ºB",
            "3ºC",
            "4ºA",
            "4ºB",
            "4ºC",
            "3ºA",
            "3ºB",
            "3ºC",
            "5ºA",
            "5ºB",
            "5ºC",
            "6ºA",
            "6ºB",
            "6ºC"});
            this.cboGrupo.Location = new System.Drawing.Point(521, 124);
            this.cboGrupo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboGrupo.Name = "cboGrupo";
            this.cboGrupo.Size = new System.Drawing.Size(121, 32);
            this.cboGrupo.TabIndex = 8;
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedula.Location = new System.Drawing.Point(440, 81);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(68, 24);
            this.lblCedula.TabIndex = 6;
            this.lblCedula.Text = "Cedula";
            // 
            // txtnombreProfe
            // 
            this.txtnombreProfe.Location = new System.Drawing.Point(521, 34);
            this.txtnombreProfe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtnombreProfe.Name = "txtnombreProfe";
            this.txtnombreProfe.Size = new System.Drawing.Size(281, 30);
            this.txtnombreProfe.TabIndex = 3;
            // 
            // lblGrupoAsignado
            // 
            this.lblGrupoAsignado.AutoSize = true;
            this.lblGrupoAsignado.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrupoAsignado.Location = new System.Drawing.Point(445, 129);
            this.lblGrupoAsignado.Name = "lblGrupoAsignado";
            this.lblGrupoAsignado.Size = new System.Drawing.Size(62, 24);
            this.lblGrupoAsignado.TabIndex = 4;
            this.lblGrupoAsignado.Text = "Grupo";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(428, 39);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(80, 24);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // txtIDprofe
            // 
            this.txtIDprofe.Location = new System.Drawing.Point(128, 34);
            this.txtIDprofe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIDprofe.Name = "txtIDprofe";
            this.txtIDprofe.Size = new System.Drawing.Size(143, 30);
            this.txtIDprofe.TabIndex = 1;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(76, 36);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(31, 25);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(1107, 653);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(128, 34);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Docente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 717);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnListaProfes);
            this.Controls.Add(this.btnVerTodosProfes);
            this.Controls.Add(this.grpBusquedaProf);
            this.Controls.Add(this.btnEliminarProfe);
            this.Controls.Add(this.btnModificarProfe);
            this.Controls.Add(this.dtgProfesor);
            this.Controls.Add(this.btnRegistrarProfesor);
            this.Controls.Add(this.grpProfesor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Docente";
            this.Text = "Docente";
            this.Load += new System.EventHandler(this.Docente_Load);
            this.grpBusquedaProf.ResumeLayout(false);
            this.grpBusquedaProf.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProfesor)).EndInit();
            this.grpProfesor.ResumeLayout(false);
            this.grpProfesor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListaProfes;
        private System.Windows.Forms.Button btnVerTodosProfes;
        private System.Windows.Forms.GroupBox grpBusquedaProf;
        private System.Windows.Forms.RadioButton radIDProfe;
        private System.Windows.Forms.RadioButton radCedula;
        private System.Windows.Forms.RadioButton radNombreProfe;
        private System.Windows.Forms.RadioButton radUsuarioProfe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBuscarProfe;
        private System.Windows.Forms.TextBox txtBuscarProfe;
        private System.Windows.Forms.Button btnEliminarProfe;
        private System.Windows.Forms.Button btnModificarProfe;
        private System.Windows.Forms.DataGridView dtgProfesor;
        private System.Windows.Forms.Button btnRegistrarProfesor;
        private System.Windows.Forms.GroupBox grpProfesor;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.TextBox txtcedula;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ComboBox cboGrupo;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.TextBox txtnombreProfe;
        private System.Windows.Forms.Label lblGrupoAsignado;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtIDprofe;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnSalir;
    }
}