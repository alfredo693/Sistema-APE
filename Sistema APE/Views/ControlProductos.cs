using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_APE.Views
{
    public partial class ControlProductos : Form
    {
        private static readonly string connectionString = Connection.getConnectionString();
        private readonly SqlConnection conexion = new SqlConnection(connectionString);

        public ControlProductos()
        {
            InitializeComponent();
        }

        private void ControlProductos_Load(object sender, EventArgs e)
        {
            MostrarTablaProductos();
            CargarComboBoxCategorias();
            CargarComboBoxMarcas();

            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToOrderColumns = false;
            dataGridView1.MultiSelect = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);
            dataGridView1.AllowUserToOrderColumns = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
        }

        private void CargarComboBoxCategorias()
        {
            DataTable dataTableCategorias = ObtenerCategorias();
            comboBox1.DataSource = dataTableCategorias;
            comboBox1.DisplayMember = "nombre";
            comboBox1.ValueMember = "id_categoria";
        }

        private void CargarComboBoxMarcas()
        {
            DataTable dataTableMarcas = ObtenerMarcas();
            comboBox2.DataSource = dataTableMarcas;
            comboBox2.DisplayMember = "nombre";
            comboBox2.ValueMember = "id_marca";
        }

        private DataTable ObtenerCategorias()
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    string query = "SELECT id_categoria, nombre FROM categorias";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexion);
                    adapter.Fill(dataTable);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener las categorías: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dataTable;
        }

        private DataTable ObtenerMarcas()
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    string query = "SELECT id_marca, nombre FROM marcas";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexion);
                    adapter.Fill(dataTable);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener las marcas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dataTable;
        }


        private void MostrarTablaProductos()
        {
            var query = "SELECT * FROM VistaProductos";
            var adapter = new SqlDataAdapter(query, conexion);
            var dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;
            conexion.Close();
        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            var productos = new NuevoProducto();
            productos.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var productos = new NuevoProducto();
            productos.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtener el ID del producto seleccionado
                int idProducto = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id_producto"].Value);

                // Mostrar un cuadro de diálogo de confirmación antes de eliminar el producto
                DialogResult resultado = MessageBox.Show("¿Estás seguro de eliminar este producto?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    // Llamar al método para eliminar el producto
                    EliminarProducto(idProducto);

                    // Actualizar la tabla de productos después de eliminar el producto (opcional)
                    MostrarTablaProductos();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un producto para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EliminarProducto(int idProducto)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();

                    using (SqlCommand command = new SqlCommand("sp_EliminarProducto", conexion))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@id_producto", idProducto);

                        command.ExecuteNonQuery();

                        MessageBox.Show("Producto eliminado correctamente.", "Producto Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Verificar que se haya seleccionado una celda válida
            {
                // Obtener los datos de la fila seleccionada
                int idProducto = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id_producto"].Value);
                string nombre = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["nombre_producto"].Value);
                string descripcion = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["descripcion"].Value);
                int idCategoria = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id_categoria"].Value);
                int idMarca = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id_marca"].Value);
                decimal precio = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells["precio"].Value);

                // Crear el objeto Producto con los datos de la fila seleccionada
                Producto productoSeleccionado = new Producto
                {
                    IdProducto = idProducto,
                    Nombre = nombre,
                    Descripcion = descripcion,
                    IdCategoria = idCategoria,
                    IdMarca = idMarca,
                    Precio = precio
                };

                // Abrir la forma NuevoProducto y pasar los datos del producto seleccionado
                NuevoProducto nuevoProductoForm = new NuevoProducto
                {
                    ProductoSeleccionado = productoSeleccionado
                };

                nuevoProductoForm.ShowDialog();

                // Actualizar la tabla de productos después de cerrar la forma NuevoProducto (opcional)
                MostrarTablaProductos();
            }
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
                dataGridView1.DataSource = dataTable;
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

            try
            {
                var consultaProductos = "SELECT * FROM VistaProductos WHERE nombre_producto LIKE @nombre";
                var comandoProducto = new SqlCommand(consultaProductos, conexion);
                comandoProducto.Parameters.AddWithValue("@nombre", "%" + strNombre + "%");
                var adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comandoProducto;
                var dataTable = new DataTable();
                adaptador.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("No existe un producto con ese nombre.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la búsqueda: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            try
            {
                var consultaProductos = "SELECT * FROM VistaProductos WHERE nombre_categoria LIKE @nombre_categoria";
                var comandoProducto = new SqlCommand(consultaProductos, conexion);
                comandoProducto.Parameters.AddWithValue("@nombre_categoria", "%" + strCategoria + "%");
                var adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comandoProducto;
                var dataTable = new DataTable();
                adaptador.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("No existen productos en esa categoría.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la búsqueda: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            try
            {
                var consultaProductos = "SELECT * FROM VistaProductos WHERE nombre_marca LIKE @nombre_marca";
                var comandoProducto = new SqlCommand(consultaProductos, conexion);
                comandoProducto.Parameters.AddWithValue("@nombre_marca", "%" + strMarca + "%");
                var adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comandoProducto;
                var dataTable = new DataTable();
                adaptador.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("No existen productos de esa marca.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la búsqueda: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var query = "SELECT * FROM VistaProductos";
            var adapter = new SqlDataAdapter(query, conexion);
            var dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;
            conexion.Close();
        }
    }
}
