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
            this.radMarca = new System.Windows.Forms.RadioButton();
            this.radCategoria = new System.Windows.Forms.RadioButton();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.radNombre = new System.Windows.Forms.RadioButton();
            this.radId = new System.Windows.Forms.RadioButton();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.txtBuscarProducto = new System.Windows.Forms.TextBox();
            this.btnExportarInventario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductosInventario)).BeginInit();
            this.grpBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgProductosInventario
            // 
            this.dtgProductosInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProductosInventario.Location = new System.Drawing.Point(11, 197);
            this.dtgProductosInventario.Margin = new System.Windows.Forms.Padding(2);
            this.dtgProductosInventario.Name = "dtgProductosInventario";
            this.dtgProductosInventario.RowHeadersWidth = 51;
            this.dtgProductosInventario.RowTemplate.Height = 24;
            this.dtgProductosInventario.Size = new System.Drawing.Size(739, 386);
            this.dtgProductosInventario.TabIndex = 0;
            // 
            // lblAlumnosInscritos
            // 
            this.lblAlumnosInscritos.AutoSize = true;
            this.lblAlumnosInscritos.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlumnosInscritos.Location = new System.Drawing.Point(233, 9);
            this.lblAlumnosInscritos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAlumnosInscritos.Name = "lblAlumnosInscritos";
            this.lblAlumnosInscritos.Size = new System.Drawing.Size(300, 24);
            this.lblAlumnosInscritos.TabIndex = 53;
            this.lblAlumnosInscritos.Text = "Inventario de Productos";
            // 
            // btnVerTodosProductos
            // 
            this.btnVerTodosProductos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerTodosProductos.Location = new System.Drawing.Point(246, 108);
            this.btnVerTodosProductos.Margin = new System.Windows.Forms.Padding(2);
            this.btnVerTodosProductos.Name = "btnVerTodosProductos";
            this.btnVerTodosProductos.Size = new System.Drawing.Size(222, 40);
            this.btnVerTodosProductos.TabIndex = 52;
            this.btnVerTodosProductos.Text = "Ver todos los producto";
            this.btnVerTodosProductos.UseVisualStyleBackColor = true;
            this.btnVerTodosProductos.Click += new System.EventHandler(this.btnVerTodosProductos_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(850, 648);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(128, 61);
            this.btnSalir.TabIndex = 51;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // grpBusqueda
            // 
            this.grpBusqueda.Controls.Add(this.radMarca);
            this.grpBusqueda.Controls.Add(this.radCategoria);
            this.grpBusqueda.Controls.Add(this.comboBox2);
            this.grpBusqueda.Controls.Add(this.comboBox1);
            this.grpBusqueda.Controls.Add(this.radNombre);
            this.grpBusqueda.Controls.Add(this.radId);
            this.grpBusqueda.Controls.Add(this.btnBuscarProducto);
            this.grpBusqueda.Controls.Add(this.txtBuscarProducto);
            this.grpBusqueda.Location = new System.Drawing.Point(11, 36);
            this.grpBusqueda.Name = "grpBusqueda";
            this.grpBusqueda.Size = new System.Drawing.Size(230, 156);
            this.grpBusqueda.TabIndex = 50;
            this.grpBusqueda.TabStop = false;
            this.grpBusqueda.Text = "Buscar Producto";
            // 
            // radMarca
            // 
            this.radMarca.AutoSize = true;
            this.radMarca.Location = new System.Drawing.Point(6, 126);
            this.radMarca.Name = "radMarca";
            this.radMarca.Size = new System.Drawing.Size(55, 17);
            this.radMarca.TabIndex = 8;
            this.radMarca.Text = "Marca";
            this.radMarca.UseVisualStyleBackColor = true;
            // 
            // radCategoria
            // 
            this.radCategoria.AutoSize = true;
            this.radCategoria.Location = new System.Drawing.Point(6, 103);
            this.radCategoria.Name = "radCategoria";
            this.radCategoria.Size = new System.Drawing.Size(70, 17);
            this.radCategoria.TabIndex = 7;
            this.radCategoria.Text = "Categoria";
            this.radCategoria.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(82, 126);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(82, 102);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // radNombre
            // 
            this.radNombre.AutoSize = true;
            this.radNombre.Location = new System.Drawing.Point(6, 80);
            this.radNombre.Name = "radNombre";
            this.radNombre.Size = new System.Drawing.Size(62, 17);
            this.radNombre.TabIndex = 4;
            this.radNombre.Text = "Nombre";
            this.radNombre.UseVisualStyleBackColor = true;
            // 
            // radId
            // 
            this.radId.AutoSize = true;
            this.radId.Checked = true;
            this.radId.Location = new System.Drawing.Point(6, 57);
            this.radId.Name = "radId";
            this.radId.Size = new System.Drawing.Size(34, 17);
            this.radId.TabIndex = 3;
            this.radId.TabStop = true;
            this.radId.Text = "Id";
            this.radId.UseVisualStyleBackColor = true;
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Location = new System.Drawing.Point(139, 27);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarProducto.TabIndex = 1;
            this.btnBuscarProducto.Text = "Buscar";
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.Location = new System.Drawing.Point(6, 29);
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.Size = new System.Drawing.Size(118, 20);
            this.txtBuscarProducto.TabIndex = 0;
            this.txtBuscarProducto.TextChanged += new System.EventHandler(this.txtBuscarAlumno_TextChanged);
            // 
            // btnExportarInventario
            // 
            this.btnExportarInventario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportarInventario.Location = new System.Drawing.Point(246, 152);
            this.btnExportarInventario.Margin = new System.Windows.Forms.Padding(2);
            this.btnExportarInventario.Name = "btnExportarInventario";
            this.btnExportarInventario.Size = new System.Drawing.Size(222, 40);
            this.btnExportarInventario.TabIndex = 54;
            this.btnExportarInventario.Text = "Exportar Inventario";
            this.btnExportarInventario.UseVisualStyleBackColor = true;
            this.btnExportarInventario.Click += new System.EventHandler(this.btnExportarInventario_Click);
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(762, 594);
            this.Controls.Add(this.btnExportarInventario);
            this.Controls.Add(this.lblAlumnosInscritos);
            this.Controls.Add(this.btnVerTodosProductos);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.grpBusqueda);
            this.Controls.Add(this.dtgProductosInventario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.RadioButton radNombre;
        private System.Windows.Forms.RadioButton radId;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.TextBox txtBuscarProducto;
        private System.Windows.Forms.Button btnExportarInventario;
        public System.Windows.Forms.DataGridView dtgProductosInventario;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton radMarca;
        private System.Windows.Forms.RadioButton radCategoria;
    }
}