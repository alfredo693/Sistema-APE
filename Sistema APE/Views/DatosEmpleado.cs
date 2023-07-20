using Sistema_APE.Models;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sistema_APE.Views
{
    public partial class DatosEmpleado : Form
    {
        private Empleado empleado;
        private static readonly string connectionString = Connection.getConnectionString();
        private readonly SqlConnection conexion = new SqlConnection(connectionString);

        public DatosEmpleado(Empleado empleado = null)
        {
            InitializeComponent();
            this.empleado = empleado;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (empleado == null) // Agregar un nuevo empleado
            {
                AgregarEmpleado();
            }
            else // Actualizar un empleado existente
            {
                ActualizarEmpleado();
            }
        }

        private void DatosEmpleado_Load(object sender, EventArgs e)
        {
            if (empleado != null)
            {
                txtNombre.Text = empleado.Nombre;
                txtApellido.Text = empleado.Apellido;
                txtDireccion.Text = empleado.Direccion;
                txtSalario.Text = empleado.Salario.ToString();
                txtDireccion.Text = empleado.Direccion;
                cboDepartamento.TabIndex = empleado.IdDepartamento;
                cboRol.TabIndex = empleado.IdRol;
            }
            CargarRoles();
            CargarDepartamentos();
        }

        private void CargarRoles()
        {
            string query = "SELECT id_rol, nombre_rol FROM roles";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conexion);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            // Asignar los datos al ComboBox de roles
            cboRol.DataSource = dataTable;
            cboRol.DisplayMember = "nombre_rol";
            cboRol.ValueMember = "id_rol";
        }

        private void CargarDepartamentos()
        {
            string query = "SELECT id_departamento, nombre FROM departamentos";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conexion);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            
            cboDepartamento.DataSource = dataTable;
            cboDepartamento.DisplayMember = "nombre";
            cboDepartamento.ValueMember = "id_departamento";
            cboDepartamento.SelectedValue = empleado.IdDepartamento;

        }

        private void AgregarEmpleado()
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();

                    using (SqlCommand command = new SqlCommand("sp_AgregarEmpleado", conexion))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@nombre", txtNombre.Text);
                        command.Parameters.AddWithValue("@apellido", txtApellido.Text);
                        command.Parameters.AddWithValue("@direccion", txtDireccion.Text);
                        command.Parameters.AddWithValue("@salario", Convert.ToDecimal(txtSalario.Text));
                        command.Parameters.AddWithValue("@idRol", Convert.ToInt32(cboRol.SelectedIndex));
                        command.Parameters.AddWithValue("@idDepartamento", Convert.ToInt32(cboDepartamento.SelectedIndex));

                        command.ExecuteNonQuery();

                        MessageBox.Show("Empleado agregado correctamente.", "Empleado Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el empleado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarEmpleado()
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();

                    using (SqlCommand command = new SqlCommand("sp_ActualizarEmpleado", conexion))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@idEmpleado", empleado.IdEmpleado);
                        command.Parameters.AddWithValue("@nombre", txtNombre.Text);
                        command.Parameters.AddWithValue("@apellido", txtApellido.Text);
                        command.Parameters.AddWithValue("@direccion", txtDireccion.Text);
                        command.Parameters.AddWithValue("@salario", Convert.ToDecimal(txtSalario.Text));
                        command.Parameters.AddWithValue("@idRol", cboRol.SelectedValue);
                        command.Parameters.AddWithValue("@idDepartamento", cboDepartamento.SelectedValue);

                        command.ExecuteNonQuery();

                        MessageBox.Show("Empleado actualizado correctamente.", "Empleado Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el empleado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
