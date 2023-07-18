namespace Sistema_APE
{
    partial class Inventario
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
            this.dtgProductosInventario = new System.Windows.Forms.DataGridView();
            this.lblAlumnosInscritos = new System.Windows.Forms.Label();
            this.btnVerTodosProductos = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grpBusqueda = new System.Windows.Forms.GroupBox();
            this.radCategoria = new System.Windows.Forms.RadioButton();
            this.radMarca = new System.Windows.Forms.RadioButton();
            this.radNombre = new System.Windows.Forms.RadioButton();
            this.radId = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.txtBuscarProducto = new System.Windows.Forms.TextBox();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.btnExportarInventario = new System.Windows.Forms.Button();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductosInventario)).BeginInit();
            this.grpBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgProductosInventario
            // 
            this.dtgProductosInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProductosInventario.Location = new System.Drawing.Point(32, 83);
            this.dtgProductosInventario.Name = "dtgProductosInventario";
            this.dtgProductosInventario.RowHeadersWidth = 51;
            this.dtgProductosInventario.RowTemplate.Height = 24;
            this.dtgProductosInventario.Size = new System.Drawing.Size(1011, 789);
            this.dtgProductosInventario.TabIndex = 0;
            // 
            // lblAlumnosInscritos
            // 
            this.lblAlumnosInscritos.AutoSize = true;
            this.lblAlumnosInscritos.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlumnosInscritos.Location = new System.Drawing.Point(510, 24);
            this.lblAlumnosInscritos.Name = "lblAlumnosInscritos";
            this.lblAlumnosInscritos.Size = new System.Drawing.Size(381, 30);
            this.lblAlumnosInscritos.TabIndex = 53;
            this.lblAlumnosInscritos.Text = "Inventario de Productos";
            // 
            // btnVerTodosProductos
            // 
            this.btnVerTodosProductos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerTodosProductos.Location = new System.Drawing.Point(1133, 609);
            this.btnVerTodosProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVerTodosProductos.Name = "btnVerTodosProductos";
            this.btnVerTodosProductos.Size = new System.Drawing.Size(171, 80);
            this.btnVerTodosProductos.TabIndex = 52;
            this.btnVerTodosProductos.Text = "Ver todos los producto";
            this.btnVerTodosProductos.UseVisualStyleBackColor = true;
            this.btnVerTodosProductos.Click += new System.EventHandler(this.btnVerTodosProductos_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(1133, 797);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(171, 75);
            this.btnSalir.TabIndex = 51;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // grpBusqueda
            // 
            this.grpBusqueda.Controls.Add(this.radCategoria);
            this.grpBusqueda.Controls.Add(this.radMarca);
            this.grpBusqueda.Controls.Add(this.radNombre);
            this.grpBusqueda.Controls.Add(this.radId);
            this.grpBusqueda.Controls.Add(this.label1);
            this.grpBusqueda.Controls.Add(this.btnBuscarProducto);
            this.grpBusqueda.Controls.Add(this.txtBuscarProducto);
            this.grpBusqueda.Location = new System.Drawing.Point(1089, 83);
            this.grpBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.grpBusqueda.Name = "grpBusqueda";
            this.grpBusqueda.Padding = new System.Windows.Forms.Padding(4);
            this.grpBusqueda.Size = new System.Drawing.Size(316, 223);
            this.grpBusqueda.TabIndex = 50;
            this.grpBusqueda.TabStop = false;
            this.grpBusqueda.Text = "Buscar Producto";
            // 
            // radCategoria
            // 
            this.radCategoria.AutoSize = true;
            this.radCategoria.Location = new System.Drawing.Point(12, 181);
            this.radCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.radCategoria.Name = "radCategoria";
            this.radCategoria.Size = new System.Drawing.Size(87, 20);
            this.radCategoria.TabIndex = 6;
            this.radCategoria.Text = "Categoria";
            this.radCategoria.UseVisualStyleBackColor = true;
            // 
            // radMarca
            // 
            this.radMarca.AutoSize = true;
            this.radMarca.Location = new System.Drawing.Point(12, 153);
            this.radMarca.Margin = new System.Windows.Forms.Padding(4);
            this.radMarca.Name = "radMarca";
            this.radMarca.Size = new System.Drawing.Size(66, 20);
            this.radMarca.TabIndex = 5;
            this.radMarca.Text = "Marca";
            this.radMarca.UseVisualStyleBackColor = true;
            // 
            // radNombre
            // 
            this.radNombre.AutoSize = true;
            this.radNombre.Location = new System.Drawing.Point(12, 126);
            this.radNombre.Margin = new System.Windows.Forms.Padding(4);
            this.radNombre.Name = "radNombre";
            this.radNombre.Size = new System.Drawing.Size(77, 20);
            this.radNombre.TabIndex = 4;
            this.radNombre.Text = "Nombre";
            this.radNombre.UseVisualStyleBackColor = true;
            // 
            // radId
            // 
            this.radId.AutoSize = true;
            this.radId.Checked = true;
            this.radId.Location = new System.Drawing.Point(12, 97);
            this.radId.Margin = new System.Windows.Forms.Padding(4);
            this.radId.Name = "radId";
            this.radId.Size = new System.Drawing.Size(39, 20);
            this.radId.TabIndex = 3;
            this.radId.TabStop = true;
            this.radId.Text = "Id";
            this.radId.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Por:";
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Location = new System.Drawing.Point(185, 33);
            this.btnBuscarProducto.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(100, 28);
            this.btnBuscarProducto.TabIndex = 1;
            this.btnBuscarProducto.Text = "Buscar";
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.Location = new System.Drawing.Point(8, 36);
            this.txtBuscarProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.Size = new System.Drawing.Size(156, 22);
            this.txtBuscarProducto.TabIndex = 0;
            this.txtBuscarProducto.TextChanged += new System.EventHandler(this.txtBuscarAlumno_TextChanged);
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProducto.Location = new System.Drawing.Point(1133, 514);
            this.btnEliminarProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(171, 75);
            this.btnEliminarProducto.TabIndex = 49;
            this.btnEliminarProducto.Text = "Eliminar Producto";
            this.btnEliminarProducto.UseVisualStyleBackColor = true;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // btnExportarInventario
            // 
            this.btnExportarInventario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportarInventario.Location = new System.Drawing.Point(1133, 706);
            this.btnExportarInventario.Name = "btnExportarInventario";
            this.btnExportarInventario.Size = new System.Drawing.Size(171, 71);
            this.btnExportarInventario.TabIndex = 54;
            this.btnExportarInventario.Text = "Exportar Inventario";
            this.btnExportarInventario.UseVisualStyleBackColor = true;
            this.btnExportarInventario.Click += new System.EventHandler(this.btnExportarInventario_Click);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProducto.Location = new System.Drawing.Point(1133, 312);
            this.btnAgregarProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(171, 88);
            this.btnAgregarProducto.TabIndex = 55;
            this.btnAgregarProducto.Text = "Agregar Producto";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(1133, 421);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(171, 75);
            this.btnModificar.TabIndex = 56;
            this.btnModificar.Text = "Modificar Producto";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1593, 891);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.btnExportarInventario);
            this.Controls.Add(this.lblAlumnosInscritos);
            this.Controls.Add(this.btnVerTodosProductos);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.grpBusqueda);
            this.Controls.Add(this.btnEliminarProducto);
            this.Controls.Add(this.dtgProductosInventario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.Inventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductosInventario)).EndInit();
            this.grpBusqueda.ResumeLayout(false);
            this.grpBusqueda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAlumnosInscritos;
        private System.Windows.Forms.Button btnVerTodosProductos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox grpBusqueda;
        private System.Windows.Forms.RadioButton radCategoria;
        private System.Windows.Forms.RadioButton radMarca;
        private System.Windows.Forms.RadioButton radNombre;
        private System.Windows.Forms.RadioButton radId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.TextBox txtBuscarProducto;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.Button btnExportarInventario;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Button btnModificar;
        public System.Windows.Forms.DataGridView dtgProductosInventario;
    }
}