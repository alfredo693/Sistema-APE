using System.Windows.Forms;

namespace Sistema_APE.Views
{
    partial class Caja
    {
        // Otros controles necesarios
        private DataGridView dgvVenta;
        private TextBox txtIdProducto;
        private TextBox txtCantidad;
        private Button btnVerProductos;
        private Button btnVerInventario;
        private Button btnAgregarProducto;
        private Button btnGenerarVenta;
        private Label lblTotal;

        // Otros métodos y eventos necesarios

        private void InitializeComponent()
        {
            this.dgvVenta = new System.Windows.Forms.DataGridView();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnVerProductos = new System.Windows.Forms.Button();
            this.btnVerInventario = new System.Windows.Forms.Button();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.btnGenerarVenta = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVenta
            // 
            this.dgvVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVenta.Location = new System.Drawing.Point(12, 12);
            this.dgvVenta.Name = "dgvVenta";
            this.dgvVenta.Size = new System.Drawing.Size(738, 250);
            this.dgvVenta.TabIndex = 0;
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Location = new System.Drawing.Point(12, 309);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(100, 20);
            this.txtIdProducto.TabIndex = 1;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(118, 309);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 2;
            // 
            // btnVerProductos
            // 
            this.btnVerProductos.Location = new System.Drawing.Point(12, 335);
            this.btnVerProductos.Name = "btnVerProductos";
            this.btnVerProductos.Size = new System.Drawing.Size(100, 23);
            this.btnVerProductos.TabIndex = 3;
            this.btnVerProductos.Text = "Ver Productos";
            this.btnVerProductos.UseVisualStyleBackColor = true;
            this.btnVerProductos.Click += new System.EventHandler(this.btnVerProductos_Click);
            // 
            // btnVerInventario
            // 
            this.btnVerInventario.Location = new System.Drawing.Point(118, 335);
            this.btnVerInventario.Name = "btnVerInventario";
            this.btnVerInventario.Size = new System.Drawing.Size(100, 23);
            this.btnVerInventario.TabIndex = 4;
            this.btnVerInventario.Text = "Ver Inventario";
            this.btnVerInventario.UseVisualStyleBackColor = true;
            this.btnVerInventario.Click += new System.EventHandler(this.btnVerInventario_Click);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(224, 307);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(100, 23);
            this.btnAgregarProducto.TabIndex = 5;
            this.btnAgregarProducto.Text = "Agregar Producto";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // btnGenerarVenta
            // 
            this.btnGenerarVenta.Location = new System.Drawing.Point(12, 364);
            this.btnGenerarVenta.Name = "btnGenerarVenta";
            this.btnGenerarVenta.Size = new System.Drawing.Size(100, 23);
            this.btnGenerarVenta.TabIndex = 6;
            this.btnGenerarVenta.Text = "Generar Venta";
            this.btnGenerarVenta.UseVisualStyleBackColor = true;
            this.btnGenerarVenta.Click += new System.EventHandler(this.btnGenerarVenta_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(225, 343);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "Total:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Codigo del producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Cantidad";
            // 
            // Caja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 548);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnGenerarVenta);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.btnVerInventario);
            this.Controls.Add(this.btnVerProductos);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtIdProducto);
            this.Controls.Add(this.dgvVenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Caja";
            this.Text = "Caja";
            this.Load += new System.EventHandler(this.Caja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Label label1;
        private Label label2;
    }
}
