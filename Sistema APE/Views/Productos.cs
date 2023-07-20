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
            if (e.RowIndex >= 0)
            {
                int idProducto = Convert.ToInt32(dtgProductos.Rows[e.RowIndex].Cells["id_producto"].Value);
                string nombreProducto = dtgProductos.Rows[e.RowIndex].Cells["nombre"].Value.ToString();

                Pedidos frmPedidos = Application.OpenForms["Pedidos"] as Pedidos;

                if (frmPedidos != null)
                {
                    // Actualizar los TextBoxes del formulario "Pedidos" con los nuevos datos
                    frmPedidos.IdProducto = idProducto;
                    frmPedidos.NombreProducto = nombreProducto;
                }

                this.Hide();
            }
        }
    }
}
