using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sistema_APE.Views
{
    public partial class NuevoProducto : Form
    {
        private static readonly string connectionString = Connection.getConnectionString();
        private readonly SqlConnection conexion = new SqlConnection(connectionString);

        public Producto ProductoSeleccionado { get; set; }

        private bool esActualizacion = false;

        public NuevoProducto()
        {
            InitializeComponent();
            CargarComboBoxCategorias();
            CargarComboBoxMarcas();
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


        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            string descripcion = textBox3.Text;
            string idCategoria = Convert.ToString(comboBox1.SelectedValue);
            string idMarca = Convert.ToString(comboBox2.SelectedValue);
            decimal precio = Convert.ToDecimal(textBox2.Text);

            // Llamar al método para guardar el nuevo producto
            GuardarProducto(nombre, descripcion, idCategoria, idMarca, precio);
        }

        private void GuardarProducto(string nombre, string descripcion, string idCategoria, string idMarca, decimal precio)
        {
            if (esActualizacion)
            {
                try
                {
                    using (SqlConnection conexion = new SqlConnection(connectionString))
                    {
                        conexion.Open();

                        using (SqlCommand command = new SqlCommand("sp_ActualizarProducto", conexion))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@id_producto", ProductoSeleccionado.IdProducto);
                            command.Parameters.AddWithValue("@nombre", nombre);
                            command.Parameters.AddWithValue("@descripcion", descripcion);
                            command.Parameters.AddWithValue("@id_categoria", idCategoria);
                            command.Parameters.AddWithValue("@id_marca", idMarca);
                            command.Parameters.AddWithValue("@precio", precio);

                            command.ExecuteNonQuery();
                            this.Hide();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    using (SqlConnection conexion = new SqlConnection(connectionString))
                    {
                        conexion.Open();

                        using (SqlCommand command = new SqlCommand("sp_AgregarProducto", conexion))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@nombre", nombre);
                            command.Parameters.AddWithValue("@descripcion", descripcion);
                            command.Parameters.AddWithValue("@id_categoria", idCategoria);
                            command.Parameters.AddWithValue("@id_marca", idMarca);
                            command.Parameters.AddWithValue("@precio", precio);

                            int nuevoID = (int)command.ExecuteScalar();

                            MessageBox.Show("Producto agregado correctamente. ID del nuevo producto: " + nuevoID, "Producto Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void NuevoProducto_Load(object sender, EventArgs e)
        {
            if (ProductoSeleccionado != null)
            {
                // Si se recibieron datos del producto seleccionado, mostrarlos en los campos
                esActualizacion = true;
                textBox1.Text = ProductoSeleccionado.Nombre;
                textBox3.Text = ProductoSeleccionado.Descripcion;
                comboBox1.SelectedValue = ProductoSeleccionado.IdCategoria;
                comboBox2.SelectedValue = ProductoSeleccionado.IdMarca;
                textBox2.Text = ProductoSeleccionado.Precio.ToString();
                button1.Text = "Actualizar";
            }
        }
    }
}
