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

namespace Sistema_APE
{
    public partial class ModificarProducto : Form
    {
        SqlConnection conexion = new SqlConnection("server = ALFREDOLOPEZ; database = TIENDADETECNOLOGIA; integrated security = true");
        public ModificarProducto()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CreateProducto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tIENDADETECNOLOGIADataSet.Marcas' Puede moverla o quitarla según sea necesario.
            this.marcasTableAdapter.Fill(this.tIENDADETECNOLOGIADataSet.Marcas);
            // TODO: esta línea de código carga datos en la tabla 'tIENDADETECNOLOGIADataSet.Categorias' Puede moverla o quitarla según sea necesario.
            this.categoriasTableAdapter.Fill(this.tIENDADETECNOLOGIADataSet.Categorias);
            FillComboBoxCategoria();
            FillComboBoxMarca();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            conexion.Open();

            string nombreProducto = txtNombre.Text;
            string descripcionProducto = txtDescripcion.Text;
            double precioProducto = double.Parse(txtPrecio2.Text);
            int stockProducto = int.Parse(txtStock2.Text);

            string nombreCategoriaSeleccionada = cmbCategoria2.SelectedValue.ToString();
            string Categoria = "SELECT id_categoria FROM Categorias WHERE nombre = @nombre";
            SqlCommand commandCategoria = new SqlCommand(Categoria, conexion);
            commandCategoria.Parameters.AddWithValue("@nombre", nombreCategoriaSeleccionada);
            int idCategoriaProducto = Convert.ToInt32(commandCategoria.ExecuteScalar());

            string nombreMarcaSeleccionada = cmbMarca2.SelectedValue.ToString();
            string Marca = "SELECT id_marca FROM Marcas WHERE nombre = @nombre";
            SqlCommand commandMarca = new SqlCommand(Marca, conexion);
            commandMarca.Parameters.AddWithValue("@nombre", nombreMarcaSeleccionada);
            int idMarcaProducto = Convert.ToInt32(commandMarca.ExecuteScalar());

            string actualizar = "UPDATE Productos SET nombre = @nombre, descripcion = @descripcion, precio = @precio, stock = @stock, id_categoria = @id_categoria, id_marca = @id_marca WHERE id_producto = @id_producto";
            SqlCommand command = new SqlCommand(actualizar, conexion);
            command.Parameters.AddWithValue("@nombre", nombreProducto);
            command.Parameters.AddWithValue("@descripcion", descripcionProducto);
            command.Parameters.AddWithValue("@precio", precioProducto);
            command.Parameters.AddWithValue("@stock", stockProducto);
            command.Parameters.AddWithValue("@id_categoria", idCategoriaProducto);
            command.Parameters.AddWithValue("@id_marca", idMarcaProducto);
            command.Parameters.AddWithValue("@id_producto", int.Parse(lblId.Text));

            int rowsAffected = command.ExecuteNonQuery();

            conexion.Close();

            Inventario inventario = new Inventario();

            inventario.MostrarTabla();
            
            Form.ActiveForm.Visible = false;

        }

        public void FillComboBoxCategoria() 
        {
            string query = "SELECT id_categoria, nombre FROM Categorias";
            SqlCommand command = new SqlCommand(query, conexion);
            conexion.Open();
            SqlDataReader reader = command.ExecuteReader();
            cmbCategoria.Items.Clear();
            while (reader.Read())
            {
                int idCategoria = reader.GetInt32(0);
                string nombreCategoria = reader.GetString(1);

                cmbCategoria.Items.Add(nombreCategoria);
            }
            reader.Close();
            conexion.Close();
        }
        public void FillComboBoxMarca()
        {
            SqlConnection conexion = new SqlConnection("server = ALFREDOLOPEZ; database = TIENDADETECNOLOGIA; integrated security = true");
            string query = "SELECT id_marca, nombre FROM Marcas";
            SqlCommand command = new SqlCommand(query, conexion);
            conexion.Open();
            SqlDataReader reader = command.ExecuteReader();
            cmbMarca.Items.Clear();
            while (reader.Read())
            {
                int idMarca = reader.GetInt32(0);
                string nombreMarca = reader.GetString(1);

                cmbMarca.Items.Add(nombreMarca);
            }
            reader.Close();
            conexion.Close();
        }

        private void picCerrar_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Visible = false;
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si el carácter ingresado no es un número, el punto decimal ni la tecla de retroceso
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // Bloquear la entrada del carácter
            }

            // Verificar si se ingresó más de un punto decimal
            if (e.KeyChar == '.' && ((TextBox)sender).Text.Contains('.'))
            {
                e.Handled = true; // Bloquear la entrada del punto decimal adicional
            }
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si el carácter ingresado no es un número ni la tecla de retroceso
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloquear la entrada del carácter
            }
        }
    }
}
