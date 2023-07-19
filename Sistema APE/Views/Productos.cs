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
    }
}
