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

        private void Pedidos_Load(object sender, EventArgs e)
        {
            MostrarPedidos();

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

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
