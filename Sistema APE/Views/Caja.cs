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
        public partial class Caja : Form
        {
            private static readonly string connectionString = Connection.getConnectionString();
            private readonly SqlConnection conexion = new SqlConnection(connectionString);

            private List<DetalleVenta> detallesVenta = new List<DetalleVenta>();

            public Caja()
            {
                InitializeComponent();
            }

            private void Caja_Load(object sender, EventArgs e)
            {
                dgvVenta.Columns.Add("Producto", "Producto");
                dgvVenta.Columns.Add("Cantidad", "Cantidad");
                dgvVenta.Columns.Add("PrecioUnitario", "Precio Unitario");
                dgvVenta.Columns.Add("Total", "Total");

                dgvVenta.ReadOnly = true;
                dgvVenta.AllowUserToAddRows = false;
                dgvVenta.AllowUserToDeleteRows = false;
                dgvVenta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvVenta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvVenta.AllowUserToOrderColumns = false;
                dgvVenta.MultiSelect = false;
                dgvVenta.ColumnHeadersDefaultCellStyle.Font = new Font(DefaultFont, FontStyle.Bold);
                dgvVenta.AllowUserToOrderColumns = false;
                dgvVenta.AllowUserToResizeColumns = false;
                dgvVenta.AllowUserToResizeRows = false;
            }

            private void btnGenerarVenta_Click(object sender, EventArgs e)
            {
                var fechaVenta = DateTime.Now;

                var precioTotal = dgvVenta.Rows.Cast<DataGridViewRow>()
                    .Sum(row => Convert.ToDecimal(row.Cells["Total"].Value));

                var idUsuario = 1;

                if (dgvVenta.Rows.Count > 0 && precioTotal > 0)
                    try
                    {
                        conexion.Open();

                        using (var ventaCommand = new SqlCommand("sp_InsertarVenta", conexion))
                        {
                            ventaCommand.CommandType = CommandType.StoredProcedure;

                            ventaCommand.Parameters.AddWithValue("@fechaVenta", fechaVenta);
                            ventaCommand.Parameters.AddWithValue("@total", precioTotal);
                            ventaCommand.Parameters.AddWithValue("@idUsuario", idUsuario);

                            ventaCommand.Parameters.Add("@idVenta", SqlDbType.Int).Direction = ParameterDirection.Output;

                            ventaCommand.ExecuteNonQuery();

                            var idVenta = Convert.ToInt32(ventaCommand.Parameters["@idVenta"].Value);

                            using (var detalleCommand = new SqlCommand("sp_InsertarDetalleVenta", conexion))
                            {
                                detalleCommand.CommandType = CommandType.StoredProcedure;

                                detalleCommand.Parameters.Add("@idVenta", SqlDbType.Int);
                                detalleCommand.Parameters.Add("@idProducto", SqlDbType.Int);
                                detalleCommand.Parameters.Add("@cantidad", SqlDbType.Int);
                                detalleCommand.Parameters.Add("@precioUnitario", SqlDbType.Decimal);

                                foreach (DataGridViewRow row in dgvVenta.Rows)
                                {
                                    var nombreProducto = Convert.ToString(row.Cells["Producto"].Value);
                                    var idProducto = ObtenerIdProductoPorNombre(nombreProducto);
                                    var cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                                    var precioUnitario = Convert.ToDecimal(row.Cells["PrecioUnitario"].Value);

                                    detalleCommand.Parameters["@idVenta"].Value = idVenta;
                                    detalleCommand.Parameters["@idProducto"].Value = idProducto;
                                    detalleCommand.Parameters["@cantidad"].Value = cantidad;
                                    detalleCommand.Parameters["@precioUnitario"].Value = precioUnitario;

                                    detalleCommand.ExecuteNonQuery();
                                }
                            }


                            conexion.Close();

                            MessageBox.Show("Venta generada exitosamente.", "Venta Generada", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                            dgvVenta.Rows.Clear();
                            lblTotal.Text = "Total: $0.00";
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al generar la venta: " + ex.Message, "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    finally
                    {
                        if (conexion.State == ConnectionState.Open)
                            conexion.Close();
                    }
                else
                    MessageBox.Show("No hay productos en la venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            private int ObtenerIdProductoPorNombre(string nombreProducto)
            {
                var idProducto = -1;

                try
                {
                    using (var conexion = new SqlConnection(connectionString))
                    {
                        conexion.Open();
                        var query = "SELECT id_producto FROM productos WHERE nombre = @nombreProducto";
                        using (var command = new SqlCommand(query, conexion))
                        {
                            command.Parameters.AddWithValue("@nombreProducto", nombreProducto);

                            var result = command.ExecuteScalar();

                            if (result != null && result != DBNull.Value) idProducto = Convert.ToInt32(result);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener el ID del producto: " + ex.Message, "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                return idProducto;
            }


            private void btnVerInventario_Click(object sender, EventArgs e)
            {
                var inventarioForm = new Inventario();

                inventarioForm.FormBorderStyle = FormBorderStyle.FixedSingle;

                inventarioForm.ShowDialog();

                inventarioForm.FormBorderStyle = FormBorderStyle.None;
            }

            private void btnVerProductos_Click(object sender, EventArgs e)
            {
                using (var productosForm = new Productos())
                {
                    productosForm.ShowDialog();
                }
            }

            private void btnAgregarProducto_Click(object sender, EventArgs e)
            {
                var idProducto = int.Parse(txtIdProducto.Text);
                var cantidad = int.Parse(txtCantidad.Text);

                var detalle = ObtenerDetalleProducto(idProducto);

                if (detalle != null)
                {
                    var totalDetalle = detalle.PrecioUnitario * cantidad;

                    dgvVenta.Rows.Add(detalle.Producto, detalle.PrecioUnitario, cantidad, totalDetalle);

                    var totalVenta = dgvVenta.Rows.Cast<DataGridViewRow>()
                        .Sum(row => Convert.ToDecimal(row.Cells["Total"].Value));

                    lblTotal.Text = "Total: " + totalVenta.ToString("C");
                }
                else
                {
                    MessageBox.Show("No se encontró el producto con el ID proporcionado.", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }


            private DetalleVenta ObtenerDetalleProducto(int idProducto)
            {
                DetalleVenta detalle = null;

                try
                {
                    conexion.Open();

                    var query = "SELECT nombre, precio FROM VistaProductos WHERE id_producto = @idProducto";
                    using (var command = new SqlCommand(query, conexion))
                    {
                        command.Parameters.AddWithValue("@idProducto", idProducto);

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                                detalle = new DetalleVenta
                                {
                                    IdProducto = idProducto,
                                    Producto = reader["nombre"].ToString(),
                                    PrecioUnitario = Convert.ToDecimal(reader["precio"])
                                };
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener los detalles del producto: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (conexion.State == ConnectionState.Open)
                        conexion.Close();
                }

                return detalle;
            }
        }
    }