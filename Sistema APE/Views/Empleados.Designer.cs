using System.Windows.Forms;
using System;

namespace Sistema_APE.Views
{
    partial class Empleados
    {
        private System.ComponentModel.IContainer components = null;

        // Controles del formulario
        private DataGridView dgvEmpleados;
        private Button btnAgregar;
        private Button btnEditar;
        private Button btnEliminar;
        private TextBox txtBuscar;
        private Label lblBuscar;
        private RadioButton rbNombre;
        private RadioButton rbApellido;
        private RadioButton rbDepartamento;

        // Método para inicializar los componentes
        private void InitializeComponent()
        {
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.rbNombre = new System.Windows.Forms.RadioButton();
            this.rbApellido = new System.Windows.Forms.RadioButton();
            this.rbDepartamento = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.Location = new System.Drawing.Point(12, 12);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.Size = new System.Drawing.Size(678, 300);
            this.dgvEmpleados.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(12, 318);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(93, 318);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(174, 318);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(9, 42);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(275, 20);
            this.txtBuscar.TabIndex = 4;
            // 
            // lblBuscar
            // 
            this.lblBuscar.Location = new System.Drawing.Point(6, 21);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(40, 13);
            this.lblBuscar.TabIndex = 5;
            this.lblBuscar.Text = "Buscar:";
            // 
            // rbNombre
            // 
            this.rbNombre.Location = new System.Drawing.Point(52, 19);
            this.rbNombre.Name = "rbNombre";
            this.rbNombre.Size = new System.Drawing.Size(60, 17);
            this.rbNombre.TabIndex = 6;
            this.rbNombre.Text = "Nombre";
            // 
            // rbApellido
            // 
            this.rbApellido.Location = new System.Drawing.Point(118, 19);
            this.rbApellido.Name = "rbApellido";
            this.rbApellido.Size = new System.Drawing.Size(70, 17);
            this.rbApellido.TabIndex = 7;
            this.rbApellido.Text = "Apellido";
            // 
            // rbDepartamento
            // 
            this.rbDepartamento.Location = new System.Drawing.Point(194, 19);
            this.rbDepartamento.Name = "rbDepartamento";
            this.rbDepartamento.Size = new System.Drawing.Size(90, 17);
            this.rbDepartamento.TabIndex = 8;
            this.rbDepartamento.Text = "Departamento";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBuscar);
            this.groupBox1.Controls.Add(this.rbDepartamento);
            this.groupBox1.Controls.Add(this.rbApellido);
            this.groupBox1.Controls.Add(this.rbNombre);
            this.groupBox1.Controls.Add(this.lblBuscar);
            this.groupBox1.Location = new System.Drawing.Point(12, 347);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // Empleados
            // 
            this.ClientSize = new System.Drawing.Size(706, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvEmpleados);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEliminar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Empleados";
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.Empleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        private GroupBox groupBox1;
    }
}
