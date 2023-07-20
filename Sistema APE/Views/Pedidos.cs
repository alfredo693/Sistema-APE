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
    public partial class Pedidos : Form
    {
        private static readonly string connectionString = Connection.getConnectionString();
        private readonly SqlConnection conexion = new SqlConnection(connectionString);
        public Pedidos()
        {
            InitializeComponent();
        }

        public int IdProducto
        {
            get { return Convert.ToInt32(txtIdProducto.Text); }
            set { txtIdProducto.Text = value.ToString(); }
        }

        public string NombreProducto
        {
            get { return txtProducto.Text; }
            set { txtProducto.Text = value; }
        }

        private void Pedidos_Load(object sender, EventArgs e)
        {
            MostrarPedidos();

            dtgProductos.Columns[0].HeaderText = "ID Producto";
            dtgProductos.Columns[1].HeaderText = "Producto";
            dtgProductos.Columns[2].HeaderText = "Cantidad";

            dtgPedidos.ReadOnly = true;
            dtgPedidos.AllowUserToAddRows = false;
            dtgPedidos.AllowUserToDeleteRows = false;
            dtgPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgPedidos.AllowUserToOrderColumns = false;
            dtgPedidos.MultiSelect = false;
            dtgPedidos.ColumnHeadersDefaultCellStyle.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);
            dtgPedidos.AllowUserToOrderColumns = false;
            dtgPedidos.AllowUserToResizeColumns = false;
            dtgPedidos.AllowUserToResizeRows = false;
        }

        private void MostrarPedidos()
        {
            var query = "SELECT * FROM VistaPedidos";
            var adapter = new SqlDataAdapter(query, conexion);
            var dataTable = new DataTable();
            adapter.Fill(dataTable);

            dtgPedidos.DataSource = dataTable;
            conexion.Close();
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            Productos productos = new Productos();
            productos.Show();
        }
        

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}
