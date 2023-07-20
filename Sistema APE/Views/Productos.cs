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
    public partial class Productos : Form
    {
        private static readonly string connectionString = Connection.getConnectionString();
        private readonly SqlConnection conexion = new SqlConnection(connectionString);
        public Productos()
        {
            InitializeComponent();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            MostrarTablaProductos();

            dtgProductos.Columns[0].HeaderText = "ID";
            dtgProductos.Columns[1].HeaderText = "Nombre";
            dtgProductos.Columns[2].HeaderText = "Precio";
            dtgProductos.Columns[3].HeaderText = "Categoría";
            dtgProductos.Columns[4].HeaderText = "Marca";


            dtgProductos.ReadOnly = true;
            dtgProductos.AllowUserToAddRows = false;
            dtgProductos.AllowUserToDeleteRows = false;
            dtgProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgProductos.AllowUserToOrderColumns = false;
            dtgProductos.MultiSelect = false;
            dtgProductos.ColumnHeadersDefaultCellStyle.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);
            dtgProductos.AllowUserToOrderColumns = false;
            dtgProductos.AllowUserToResizeColumns = false;
            dtgProductos.AllowUserToResizeRows = false;
        }

        private void MostrarTablaProductos()
        {
            var query = "SELECT * FROM VistaProductos";
            var adapter = new SqlDataAdapter(query, conexion);
            var dataTable = new DataTable();
            adapter.Fill(dataTable);

            dtgProductos.DataSource = dataTable;
            conexion.Close();
        }

        private void dtgProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int idProductoSeleccionado = int.Parse(dtgProductos.SelectedRows[0].Cells["id_producto"].Value.ToString());

            Producto productoSeleccionado = ObtenerProductoPorID(idProductoSeleccionado);

            Pedidos formPedidos = (Pedidos)Application.OpenForms["Pedidos"];
            formPedidos.AgregarProducto(productoSeleccionado);

            formPedidos.PrecioUnitario = productoSeleccionado.Precio;

            this.Close();
        }

        private Producto ObtenerProductoPorID(int idProducto)
        {
            Producto producto = null;

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM productos WHERE id_producto = @id_producto";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@id_producto", idProducto);
                    conexion.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        producto = new Producto
                        {
                            IdProducto = int.Parse(reader["id_producto"].ToString()),
                            Nombre = reader["nombre"].ToString(),
                            Descripcion = reader["descripcion"].ToString(),
                            IdCategoria = int.Parse(reader["id_categoria"].ToString()),
                            IdMarca = int.Parse(reader["id_marca"].ToString()),
                            Precio = decimal.Parse(reader["precio"].ToString())
                        };
                    }

                    reader.Close();
                    conexion.Close();
                }
            }

            return producto;
        }


    }
}
