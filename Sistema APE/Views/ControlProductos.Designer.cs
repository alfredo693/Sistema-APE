namespace Sistema_APE.Views
{
    partial class ControlProductos
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnNuevoProducto = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.grpBusqueda = new System.Windows.Forms.GroupBox();
            this.radMarca = new System.Windows.Forms.RadioButton();
            this.radCategoria = new System.Windows.Forms.RadioButton();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.radNombre = new System.Windows.Forms.RadioButton();
            this.radId = new System.Windows.Forms.RadioButton();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.txtBuscarProducto = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 174);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(691, 264);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnNuevoProducto
            // 
            this.btnNuevoProducto.Location = new System.Drawing.Point(575, 103);
            this.btnNuevoProducto.Name = "btnNuevoProducto";
            this.btnNuevoProducto.Size = new System.Drawing.Size(128, 23);
            this.btnNuevoProducto.TabIndex = 1;
            this.btnNuevoProducto.Text = "Nuevo Producto";
            this.btnNuevoProducto.UseVisualStyleBackColor = true;
            this.btnNuevoProducto.Click += new System.EventHandler(this.btnNuevoProducto_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(441, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Editar Producto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(307, 103);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Eliminar Producto";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // grpBusqueda
            // 
            this.grpBusqueda.Controls.Add(this.button3);
            this.grpBusqueda.Controls.Add(this.radMarca);
            this.grpBusqueda.Controls.Add(this.radCategoria);
            this.grpBusqueda.Controls.Add(this.comboBox2);
            this.grpBusqueda.Controls.Add(this.comboBox1);
            this.grpBusqueda.Controls.Add(this.radNombre);
            this.grpBusqueda.Controls.Add(this.radId);
            this.grpBusqueda.Controls.Add(this.btnBuscarProducto);
            this.grpBusqueda.Controls.Add(this.txtBuscarProducto);
            this.grpBusqueda.Location = new System.Drawing.Point(12, 12);
            this.grpBusqueda.Name = "grpBusqueda";
            this.grpBusqueda.Size = new System.Drawing.Size(230, 156);
            this.grpBusqueda.TabIndex = 51;
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
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(139, 56);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Limpiar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ControlProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 450);
            this.Controls.Add(this.grpBusqueda);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNuevoProducto);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ControlProductos";
            this.Text = "ControlProductos";
            this.Load += new System.EventHandler(this.ControlProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpBusqueda.ResumeLayout(false);
            this.grpBusqueda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnNuevoProducto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox grpBusqueda;
        private System.Windows.Forms.RadioButton radMarca;
        private System.Windows.Forms.RadioButton radCategoria;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton radNombre;
        private System.Windows.Forms.RadioButton radId;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.TextBox txtBuscarProducto;
        private System.Windows.Forms.Button button3;
    }
}