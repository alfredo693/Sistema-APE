using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Font = System.Drawing.Font;

namespace Sistema_APE
{
    public partial class Inventario : Form
    {
        private static readonly string connectionString = Connection.getConnectionString();

        private readonly SqlConnection conexion = new SqlConnection(connectionString);

        public Inventario()
        {
            InitializeComponent();
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            MostrarTabla();
            

            string mostrarCategorias = "SELECT id_categoria, nombre FROM categorias";
            SqlDataAdapter adapter = new SqlDataAdapter(mostrarCategorias, conexion);

            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "categorias");
            comboBox1.DisplayMember = "nombre";
            comboBox1.ValueMember = "id_categoria";
            comboBox1.DataSource = dataSet.Tables["categorias"];

            string mostrarMarcas = "SELECT id_marca, nombre FROM marcas";
            SqlDataAdapter adapterMarcas = new SqlDataAdapter(mostrarMarcas, conexion);
            DataSet dataSetMarcas = new DataSet();
            adapterMarcas.Fill(dataSetMarcas, "marcas");
            comboBox2.DisplayMember = "nombre";
            comboBox2.ValueMember = "id_marca";
            comboBox2.DataSource = dataSetMarcas.Tables["marcas"];

            conexion.Open();

            dtgProductosInventario.ReadOnly = true;
            dtgProductosInventario.AllowUserToAddRows = false;
            dtgProductosInventario.AllowUserToDeleteRows = false;
            dtgProductosInventario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgProductosInventario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgProductosInventario.AllowUserToOrderColumns = false;
            dtgProductosInventario.MultiSelect = false;
            dtgProductosInventario.ColumnHeadersDefaultCellStyle.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);
            dtgProductosInventario.AllowUserToOrderColumns = false;
            dtgProductosInventario.AllowUserToResizeColumns = false;
            dtgProductosInventario.AllowUserToResizeRows = false;

            dtgProductosInventario.Columns[0].HeaderText = "ID";
            dtgProductosInventario.Columns[1].HeaderText = "Producto";
            dtgProductosInventario.Columns[2].HeaderText = "Descripción";
            dtgProductosInventario.Columns[3].HeaderText = "Precio";
            dtgProductosInventario.Columns[4].HeaderText = "Stock";
            dtgProductosInventario.Columns[5].HeaderText = "Categoría";
            dtgProductosInventario.Columns[6].HeaderText = "Marca";

        }

        public void MostrarTabla()
        {
            var query = "SELECT * FROM VistaInventario";
            var adapter = new SqlDataAdapter(query, conexion);
            var dataTable = new DataTable();
            adapter.Fill(dataTable);

            dtgProductosInventario.DataSource = dataTable;
            conexion.Close();
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (radId.Checked)
                {
                    ConsultarPorId();
                }
                else if (radNombre.Checked)
                {
                    ConsultarPorNombre();
                }
                else if (radCategoria.Checked)
                {
                    ConsultarPorCategoria();
                }
                else if (radMarca.Checked)
                {
                    ConsultarPorMarca();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Introduzca una palabra clave para buscar el producto de acuerdo a la opción que eligió", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConsultarPorId()
        {
            var strId = txtBuscarProducto.Text.Trim();

            if (!int.TryParse(strId, out int idProducto))
            {
                MessageBox.Show("Ingrese un ID de producto válido.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var consultaProducto = "SELECT * FROM VistaInventario WHERE id_producto = @id";
            var comandoProducto = new SqlCommand(consultaProducto, conexion);
            comandoProducto.Parameters.AddWithValue("@id", idProducto);
            var adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comandoProducto;
            var dataTable = new DataTable();
            adaptador.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                dtgProductosInventario.DataSource = dataTable;
            }
            else
            {
                MessageBox.Show("No existe un producto con ese ID.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ConsultarPorNombre()
        {
            var strNombre = txtBuscarProducto.Text.Trim();

            if (string.IsNullOrEmpty(strNombre))
            {
                MessageBox.Show("Introduzca una palabra clave para buscar el producto.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var consultaProductos = "SELECT * FROM VistaInventario WHERE nombre_producto LIKE @nombre";
            var comandoProducto = new SqlCommand(consultaProductos, conexion);
            comandoProducto.Parameters.AddWithValue("@nombre", "%" + strNombre + "%");
            var adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comandoProducto;
            var dataTable = new DataTable();
            adaptador.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                dtgProductosInventario.DataSource = dataTable;
            }
            else
            {
                MessageBox.Show("No existe un producto con ese nombre.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ConsultarPorCategoria()
        {
            var strCategoria = comboBox1.Text.Trim();

            if (string.IsNullOrEmpty(strCategoria))
            {
                MessageBox.Show("Seleccione una categoría para buscar el producto.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var consultaProductos = "SELECT * FROM VistaInventario WHERE nombre_categoria LIKE @nombre_categoria";
            var comandoProducto = new SqlCommand(consultaProductos, conexion);
            comandoProducto.Parameters.AddWithValue("@nombre_categoria", "%" + strCategoria + "%");
            var adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comandoProducto;
            var dataTable = new DataTable();
            adaptador.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                dtgProductosInventario.DataSource = dataTable;
            }
            else
            {
                MessageBox.Show("No existen productos en esa categoría.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ConsultarPorMarca()
        {
            var strMarca = comboBox2.Text.Trim();

            if (string.IsNullOrEmpty(strMarca))
            {
                MessageBox.Show("Seleccione una marca para buscar el producto.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var consultaProductos = "SELECT * FROM VistaInventario WHERE nombre_marca LIKE @nombre_marca";
            var comandoProducto = new SqlCommand(consultaProductos, conexion);
            comandoProducto.Parameters.AddWithValue("@nombre_marca", "%" + strMarca + "%");
            var adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comandoProducto;
            var dataTable = new DataTable();
            adaptador.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                dtgProductosInventario.DataSource = dataTable;
            }
            else
            {
                MessageBox.Show("No existen productos de esa marca.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void txtBuscarAlumno_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnVerTodosProductos_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            ActiveForm.Visible = false;
            var Login = new Login();
            Login.Show();
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            var selectedRow = dtgProductosInventario.CurrentRow;
            if (selectedRow == null)
            {
                MessageBox.Show("Seleccione un producto para eliminar.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var productoId = selectedRow.Cells["id_producto"].Value.ToString();

            if (MessageBox.Show("¿Desea eliminar el producto seleccionado?", "ELIMINAR PRODUCTO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    conexion.Open();
                    var eliminarProductoQuery = "DELETE FROM Productos WHERE id_producto = @productoId";
                    var eliminarProductoCommand = new SqlCommand(eliminarProductoQuery, conexion);
                    eliminarProductoCommand.Parameters.AddWithValue("@productoId", productoId);
                    eliminarProductoCommand.ExecuteNonQuery();
                    MessageBox.Show("Producto eliminado correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el producto: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conexion.Close();
                }

                MostrarTabla();
            }
            else
            {
                MessageBox.Show("Operación cancelada.", "ELIMINACIÓN CANCELADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExportarInventario_Click(object sender, EventArgs e)
        {

        }

        public void GenerarPDF(List<Producto> productos)
        {
           
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            
        }
    }
}