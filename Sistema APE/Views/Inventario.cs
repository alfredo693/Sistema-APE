using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Diagnostics;

namespace Sistema_APE
{
    public partial class Inventario : Form
    {
        private static string connectionString = Connection.getConnectionString();

        SqlConnection conexion = new SqlConnection(connectionString);
        public Inventario()
        {
            InitializeComponent();
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            MostrarTabla();
        }
        public void MostrarTabla()
        {
            conexion.Open();
            //CONSULTA DE INVENTARIO
            string query = "SELECT * FROM VistaInventario";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conexion);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            // Asigna el DataTable al DataGridView control para mostrar los datos en la tabla
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
                if (radNombre.Checked)
                {
                    ConsultarPorNombre();
                }
                if (radMarca.Checked)
                {
                    ConsultarPorMarca();
                }
                if (radCategoria.Checked)
                {
                    ConsultarPorCategoria();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Introduzca una palabra clave para buscar el producto de acuerdo a la opción que eligió", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ConsultarPorId()
        {
            Producto unProducto = new Producto();
            conexion.Open();

            string strId = txtBuscarProducto.Text;

            string consultaProducto = "SELECT * FROM VistaInventario WHERE id_producto = " + int.Parse(strId);
            SqlCommand comandoProducto = new SqlCommand(consultaProducto, conexion);
            SqlDataReader registroProductos = comandoProducto.ExecuteReader();
            if (registroProductos.Read())
            {
                unProducto.IdProducto = int.Parse(registroProductos["id_producto"].ToString());
                unProducto.Nombre = registroProductos["nombre_producto"].ToString();
                unProducto.Stock = int.Parse(registroProductos["cantidad"].ToString());

                conexion.Close();
            }
            else
            {
                MessageBox.Show("No existe un producto con ese id", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comandoProducto;
            DataTable PRODUCTOS = new DataTable();
            adaptador.Fill(PRODUCTOS);
            dtgProductosInventario.DataSource = PRODUCTOS;

            conexion.Close();
            registroProductos.Close();
        }

        private void ConsultarPorNombre()
        {
            //CONSULTA DE LOS PRODUCTOS============================================================================
            Producto unProducto = new Producto();
            conexion.Open();

            string strNombre = txtBuscarProducto.Text;

            string consultaProductos = $"SELECT * FROM VistaInventario WHERE nombre_producto LIKE '%{strNombre}%'";
            SqlCommand comandoProducto = new SqlCommand(consultaProductos, conexion);
            SqlDataReader registroProductos = comandoProducto.ExecuteReader();
            if (registroProductos.Read())
            {
                unProducto.IdProducto = int.Parse(registroProductos["id_producto"].ToString());
                unProducto.Nombre = registroProductos["nombre"].ToString();
                unProducto.Descripcion = registroProductos["descripcion"].ToString();
                unProducto.Precio = decimal.Parse(registroProductos["precio"].ToString());
                unProducto.Stock = int.Parse(registroProductos["stock"].ToString());
                unProducto.Categoria = registroProductos["categoria"].ToString();
                unProducto.Marca = registroProductos["marca"].ToString();

                conexion.Close();
            }
            else
            {
                MessageBox.Show("No existe un producto con ese id", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comandoProducto;
            DataTable PRODUCTOS = new DataTable();
            adaptador.Fill(PRODUCTOS);
            dtgProductosInventario.DataSource = PRODUCTOS;

            conexion.Close();
            registroProductos.Close();
        }

        private void ConsultarPorMarca()
        {
            //CONSULTA DE LOS PRODUCTOS============================================================================
            Producto unProducto = new Producto();
            conexion.Open();

            string strMarca = txtBuscarProducto.Text;

            string consultaProductos = "SELECT P.id_producto, P.nombre, P.descripcion, P.precio, P.stock, C.nombre AS categoria, M.nombre AS marca " +
                "FROM Productos P " +
                "JOIN Categorias C ON P.id_categoria = C.id_categoria " +
                "JOIN Marcas M ON P.id_marca = M.id_marca " +
                "WHERE M.nombre LIKE '%" + strMarca + "%'";
            SqlCommand comandoProducto = new SqlCommand(consultaProductos, conexion);
            SqlDataReader registroProductos = comandoProducto.ExecuteReader();
            if (registroProductos.Read())
            {
                unProducto.IdProducto = int.Parse(registroProductos["id_producto"].ToString());
                unProducto.Nombre = registroProductos["nombre"].ToString();
                unProducto.Descripcion = registroProductos["descripcion"].ToString();
                unProducto.Precio = decimal.Parse(registroProductos["precio"].ToString());
                unProducto.Stock = int.Parse(registroProductos["stock"].ToString());
                unProducto.Categoria = registroProductos["categoria"].ToString();
                unProducto.Marca = registroProductos["marca"].ToString();

                conexion.Close();
            }
            else
            {
                MessageBox.Show("No existe un producto con ese id", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comandoProducto;
            DataTable PRODUCTOS = new DataTable();
            adaptador.Fill(PRODUCTOS);
            dtgProductosInventario.DataSource = PRODUCTOS;

            conexion.Close();
            registroProductos.Close();
        }
        private void ConsultarPorCategoria()
        {
            //CONSULTA DE LOS PRODUCTOS============================================================================
            Producto unProducto = new Producto();
            conexion.Open();

            string strCategoria = txtBuscarProducto.Text;

            string consultaProductos = "SELECT P.id_producto, P.nombre, P.descripcion, P.precio, P.stock, C.nombre AS categoria, M.nombre AS marca " +
               "FROM Productos P " +
               "JOIN Categorias C ON P.id_categoria = C.id_categoria " +
               "JOIN Marcas M ON P.id_marca = M.id_marca " +
               "WHERE C.nombre LIKE '%" + strCategoria + "%'";
            SqlCommand comandoProducto = new SqlCommand(consultaProductos, conexion);
            SqlDataReader registroProductos = comandoProducto.ExecuteReader();
            if (registroProductos.Read())
            {
                unProducto.IdProducto = int.Parse(registroProductos["id_producto"].ToString());
                unProducto.Nombre = registroProductos["nombre"].ToString();
                unProducto.Descripcion = registroProductos["descripcion"].ToString();
                unProducto.Precio = decimal.Parse(registroProductos["precio"].ToString());
                unProducto.Stock = int.Parse(registroProductos["stock"].ToString());
                unProducto.Categoria = registroProductos["categoria"].ToString();
                unProducto.Marca = registroProductos["marca"].ToString();

                conexion.Close();
            }
            else
            {
                MessageBox.Show("No existe un producto con ese id", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comandoProducto;
            DataTable PRODUCTOS = new DataTable();
            adaptador.Fill(PRODUCTOS);
            dtgProductosInventario.DataSource = PRODUCTOS;

            conexion.Close();
            registroProductos.Close();
        }

        private void txtBuscarAlumno_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVerTodosProductos_Click(object sender, EventArgs e)
        {
            conexion.Open();
            //CONSULTA DE INVENTARIO
            string query = "SELECT P.id_producto, P.nombre, P.descripcion, P.precio, P.stock, C.nombre AS categoria, M.nombre AS marca " +
               "FROM Productos P " +
               "JOIN Categorias C ON P.id_categoria = C.id_categoria " +
               "JOIN Marcas M ON P.id_marca = M.id_marca";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conexion);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            // Asigna el DataTable al DataGridView control para mostrar los datos en la tabla
            dtgProductosInventario.DataSource = dataTable;
            conexion.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Visible = false;
            Login Login = new Login();
            Login.Show();
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            string idProducto = "";
            DataGridViewRow renglonSeleccionado = dtgProductosInventario.CurrentRow;
            if (renglonSeleccionado == null)
            {
                MessageBox.Show("Seleccione un renglon", "ERROR", MessageBoxButtons.OK,
               MessageBoxIcon.Error);

            }
            else
            {
                try
                {
                    idProducto = renglonSeleccionado.Cells[0].Value.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Seleccione un renglon", "ERROR", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }


                if (MessageBox.Show("¿Desea eliminar el producto seleccionado?", "ELIMINAR PRODUCTO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string scriptEliminar = "delete from Productos where id_producto = " + idProducto;
                    conexion.Open();
                    SqlCommand comandoEliminarAlumno = new SqlCommand(scriptEliminar, conexion);
                    comandoEliminarAlumno.ExecuteNonQuery();
                    MessageBox.Show("Producto Eliminado correctamente");

                    SqlCommand comandoMostrarProductos = new SqlCommand("SELECT P.id_producto, P.nombre, P.descripcion, P.precio, P.stock, C.nombre AS categoria, M.nombre AS marca " +
                        "FROM Productos P " +
                        "JOIN Categorias C ON P.id_categoria = C.id_categoria " +
                        "JOIN Marcas M ON P.id_marca = M.id_marca", conexion);
                    SqlDataAdapter adaptador = new SqlDataAdapter();
                    adaptador.SelectCommand = comandoMostrarProductos;
                    DataTable PRODUCTOS = new DataTable();
                    adaptador.Fill(PRODUCTOS);
                    dtgProductosInventario.DataSource = PRODUCTOS;
                    conexion.Close();
                }
                else
                {
                    MessageBox.Show("Operación cancelada", "ELIMINACION FALLIDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnExportarInventario_Click(object sender, EventArgs e)
        {
            List<Producto> productos = new List<Producto>();

            // Conexión y consulta a la base de datos
            string connectionString = "tu_cadena_de_conexión";
            string query = "SELECT P.id_producto, P.nombre, P.descripcion, P.precio, P.stock, C.nombre AS categoria, M.nombre AS marca " +
                "FROM Productos P " +
                "JOIN Categorias C ON P.id_categoria = C.id_categoria " +
                "JOIN Marcas M ON P.id_marca = M.id_marca";

            using (SqlCommand command = new SqlCommand(query, conexion))
            {
                conexion.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Producto producto = new Producto();

                        producto.IdProducto = reader.GetInt32(0);
                        producto.Nombre = reader.GetString(1);
                        producto.Descripcion = reader.GetString(2);
                        producto.Precio = reader.GetDecimal(3);
                        producto.Stock = reader.GetInt32(4);
                        producto.Categoria = reader.GetString(5);
                        producto.Marca = reader.GetString(6);

                        productos.Add(producto);
                    }
                }
                conexion.Close();
            }

            // Llamar al método GenerarPDF pasando la lista de productos
            GenerarPDF(productos);
        }

        public void GenerarPDF(List<Producto> productos)
        {
            // Crear el documento PDF
            Document document = new Document();
            string NombreArchivo = "Inventario " + DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") + ".pdf";
            // Especificar la ruta y el nombre del archivo PDF
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), NombreArchivo);

            // Crear un objeto PdfWriter para escribir en el archivo PDF
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));

            // Abrir el documento PDF
            document.Open();

            // Crear una tabla para mostrar los datos de los productos
            PdfPTable table = new PdfPTable(5); // 5 columnas para los datos de los productos

            // Añadir las cabeceras de las columnas
            table.AddCell("ID");
            table.AddCell("Nombre");
            table.AddCell("Descripción");
            table.AddCell("Precio");
            table.AddCell("Stock");

            // Recorrer la lista de productos y añadir cada producto a la tabla
            foreach (Producto producto in productos)
            {
                table.AddCell(producto.IdProducto.ToString());
                table.AddCell(producto.Nombre);
                table.AddCell(producto.Descripcion);
                table.AddCell(producto.Precio.ToString());
                table.AddCell(producto.Stock.ToString());
            }

            // Añadir la tabla al documento
            document.Add(table);

            // Cerrar el documento PDF
            document.Close();

            // Abrir el archivo PDF con el visor predeterminado
            Process.Start(filePath);

        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            CreateProducto CreateProducto = new CreateProducto();
            CreateProducto.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string idProducto = "";
            DataGridViewRow renglonSeleccionado = dtgProductosInventario.CurrentRow;
            if (renglonSeleccionado == null)
            {
                MessageBox.Show("Seleccione un renglon", "ERROR", MessageBoxButtons.OK,
               MessageBoxIcon.Error);

            }
            else
            {
                try
                {
                    idProducto = renglonSeleccionado.Cells[0].Value.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Seleccione un renglon", "ERROR", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }

                conexion.Open();
                string consulta = "SELECT P.id_producto, P.nombre, P.descripcion, P.precio, P.stock, C.nombre AS categoria, M.nombre AS marca " +
                                  "FROM Productos P " +
                                  "JOIN Categorias C ON P.id_categoria = C.id_categoria " +
                                  "JOIN Marcas M ON P.id_marca = M.id_marca " +
                                  "WHERE P.id_producto = @idProducto";
                SqlCommand command = new SqlCommand(consulta, conexion);
                command.Parameters.AddWithValue("@idProducto", idProducto);

                // Ejecutar la consulta y obtener el resultado en un SqlDataReader
                SqlDataReader reader = command.ExecuteReader();

                // Verificar si hay filas en el resultado
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ModificarProducto ModificarProducto = new ModificarProducto();
                        // Obtener los valores de las columnas y asignarlos a variables
                        int idProductoObtenido = reader.GetInt32(reader.GetOrdinal("id_producto"));
                        string nombreProductoObtenido = reader.GetString(reader.GetOrdinal("nombre"));
                        string descripcionProductoObtenido = reader.GetString(reader.GetOrdinal("descripcion"));
                        decimal precioProductoObtenido = reader.GetDecimal(reader.GetOrdinal("precio"));
                        int stockProductoObtenido = reader.GetInt32(reader.GetOrdinal("stock"));
                        string marcaProductoObtenido = reader.GetString(reader.GetOrdinal("marca"));
                        string categoriaProductoObtenido = reader.GetString(reader.GetOrdinal("categoria"));

                        ModificarProducto.lblId.Text = idProductoObtenido.ToString();
                        ModificarProducto.txtNombre.Text = nombreProductoObtenido;
                        ModificarProducto.txtDescripcion.Text = descripcionProductoObtenido;
                        ModificarProducto.txtPrecio2.Text = precioProductoObtenido.ToString();
                        ModificarProducto.txtStock2.Text = stockProductoObtenido.ToString();
                        ModificarProducto.cmbMarca2.Text = marcaProductoObtenido;
                        ModificarProducto.cmbCategoria2.Text = categoriaProductoObtenido;
                        ModificarProducto.Show();

                        // Hacer algo con los valores obtenidos...
                    }
                }
                else
                {
                    // No se encontró ninguna fila que coincida con el criterio de búsqueda
                }

                // Cerrar el SqlDataReader
                reader.Close();
                conexion.Close();
            }

        }
    }
}
