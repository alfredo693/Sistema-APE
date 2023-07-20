using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Sistema_APE.Models;

namespace Sistema_APE.Views
{
    public partial class Pedidos : Form
    {
        private static readonly string connectionString = Connection.getConnectionString();
        private readonly SqlConnection conexion = new SqlConnection(connectionString);

        private List<DetallePedido> detallesPedido = new List<DetallePedido>();

        public Pedidos()
        {
            InitializeComponent();
        }

        public int IdProducto
        {
            get => Convert.ToInt32(txtIdProducto.Text);
            set => txtIdProducto.Text = value.ToString();
        }

        public string NombreProducto
        {
            get => txtProducto.Text;
            set => txtProducto.Text = value;
        }

        public int CantidadTotal { get; set; }
        public decimal PrecioTotal { get; set; }
        public decimal PrecioUnitario { get; set; }

        private void Pedidos_Load(object sender, EventArgs e)
        {
            dtgPedidos.CellClick += dtgPedidos_CellClick;

            MostrarPedidos();

            dtgDetalles.ReadOnly = true;
            dtgDetalles.AllowUserToAddRows = false;
            dtgDetalles.AllowUserToDeleteRows = false;
            dtgDetalles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgDetalles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgDetalles.AllowUserToOrderColumns = false;
            dtgDetalles.MultiSelect = false;
            dtgDetalles.ColumnHeadersDefaultCellStyle.Font = new Font(DefaultFont, FontStyle.Bold);
            dtgDetalles.AllowUserToOrderColumns = false;
            dtgDetalles.AllowUserToResizeColumns = false;
            dtgDetalles.AllowUserToResizeRows = false;

            dtgPedidos.ReadOnly = true;
            dtgPedidos.AllowUserToAddRows = false;
            dtgPedidos.AllowUserToDeleteRows = false;
            dtgPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgPedidos.AllowUserToOrderColumns = false;
            dtgPedidos.MultiSelect = false;
            dtgPedidos.ColumnHeadersDefaultCellStyle.Font = new Font(DefaultFont, FontStyle.Bold);
            dtgPedidos.AllowUserToOrderColumns = false;
            dtgPedidos.AllowUserToResizeColumns = false;
            dtgPedidos.AllowUserToResizeRows = false;
        }

        private void MostrarPedidos()
        {
            var query = "SELECT * FROM pedidos ORDER BY fecha_pedido ASC";
            var adapter = new SqlDataAdapter(query, conexion);
            var dataTable = new DataTable();
            adapter.Fill(dataTable);

            dtgPedidos.DataSource = dataTable;
            conexion.Close();
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            var productos = new Productos();
            productos.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var idProducto = int.Parse(txtIdProducto.Text);
            var producto = txtProducto.Text;
            var cantidad = int.Parse(txtCantidad.Text);
            var precioUnitario = PrecioUnitario;

            var item =
                $"•ID Producto: {idProducto} • Producto: {producto} • Cantidad: {cantidad} • Precio Unitario: {precioUnitario:C}";
            listBox1.Items.Add(item);

            detallesPedido.Add(new DetallePedido
            {
                IdProducto = idProducto,
                Cantidad = cantidad,
                PrecioUnitario = precioUnitario
            });
        }

        public void AgregarProducto(Producto producto)
        {
            txtIdProducto.Text = producto.IdProducto.ToString();
            txtProducto.Text = producto.Nombre;
        }

        private void btnGenrarPedido_Click(object sender, EventArgs e)
        {
            var fechaPedido = DateTime.Now;

            CantidadTotal = detallesPedido.Sum(detalle => detalle.Cantidad);
            PrecioTotal = detallesPedido.Sum(detalle => detalle.Cantidad * detalle.PrecioUnitario);

            if (PrecioTotal > 0)
            {
                conexion.Open();

                using (var command = new SqlCommand("sp_InsertarPedido", conexion))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@fechaPedido", SqlDbType.Date).Value = fechaPedido;
                    command.Parameters.Add("@cantidadTotal", SqlDbType.Int).Value = CantidadTotal;
                    command.Parameters.Add("@precioTotal", SqlDbType.Decimal).Value = PrecioTotal;

                    command.Parameters.Add("@idPedido", SqlDbType.Int).Direction = ParameterDirection.Output;

                    command.ExecuteNonQuery();

                    var idPedido = Convert.ToInt32(command.Parameters["@idPedido"].Value);

                    foreach (var detalle in detallesPedido)
                        using (var detalleCommand = new SqlCommand("sp_InsertarDetallePedido", conexion))
                        {
                            detalleCommand.CommandType = CommandType.StoredProcedure;

                            detalleCommand.Parameters.Add("@idPedido", SqlDbType.Int).Value = idPedido;
                            detalleCommand.Parameters.Add("@idProducto", SqlDbType.Int).Value = detalle.IdProducto;
                            detalleCommand.Parameters.Add("@cantidad", SqlDbType.Int).Value = detalle.Cantidad;
                            detalleCommand.Parameters.Add("@precioUnitario", SqlDbType.Int).Value =
                                detalle.PrecioUnitario;

                            detalleCommand.ExecuteNonQuery();
                        }

                    conexion.Close();
                }
            }
            else
            {
                MessageBox.Show("El PrecioTotal no es válido.");
            }

            listBox1.Items.Clear();
            dtgPedidos.DataSource = null;
            MostrarPedidos();
        }

        private void dtgPedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var idPedidoSeleccionado = int.Parse(dtgPedidos.Rows[e.RowIndex].Cells["id_pedido"].Value.ToString());

                var detallesPedido = ObtenerDetallesPedido(idPedidoSeleccionado);

                dtgDetalles.DataSource = detallesPedido;

                dtgDetalles.Columns["IdProducto"].Visible = false;
                dtgDetalles.Columns["NombreProducto"].DisplayIndex = 0;
                dtgDetalles.Columns["Cantidad"].DisplayIndex = 1;
            }
        }

        private List<DetallePedido> ObtenerDetallesPedido(int idPedido)
        {
            var detallesPedido = new List<DetallePedido>();

            using (var conexion = new SqlConnection(connectionString))
            {
                var query = "SELECT NombreProducto, cantidad, precio_unitario FROM VistaDetallesPedidos WHERE id_pedido = @idPedido";

                using (var command = new SqlCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@idPedido", idPedido);
                    conexion.Open();
                    var reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        var detalle = new DetallePedido
                        {
                            NombreProducto = reader["NombreProducto"].ToString(),
                            Cantidad = int.Parse(reader["cantidad"].ToString()),
                            PrecioUnitario = decimal.Parse(reader["precio_unitario"].ToString())
                        };
                        detallesPedido.Add(detalle);
                    }

                    reader.Close();
                    conexion.Close();
                }
            }

            return detallesPedido;
        }

    }
}