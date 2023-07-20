using Sistema_APE.Models;
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
    public partial class Empleados : Form
    {
        private static readonly string connectionString = Connection.getConnectionString();
        private readonly SqlConnection conexion = new SqlConnection(connectionString);

        public Empleados()
        {
            InitializeComponent();
        }

        private void Empleados_Load(object sender, EventArgs e)
        {
            MostrarTabla();

            dgvEmpleados.ReadOnly = true;
            dgvEmpleados.AllowUserToAddRows = false;
            dgvEmpleados.AllowUserToDeleteRows = false;
            dgvEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmpleados.AllowUserToOrderColumns = false;
            dgvEmpleados.MultiSelect = false;
            dgvEmpleados.ColumnHeadersDefaultCellStyle.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);
            dgvEmpleados.AllowUserToOrderColumns = false;
            dgvEmpleados.AllowUserToResizeColumns = false;
            dgvEmpleados.AllowUserToResizeRows = false;
        }

        private void MostrarTabla()
        {
            var query = "SELECT * FROM VistaEmpleadosConUsuario";
            var adapter = new SqlDataAdapter(query, conexion);
            var dataTable = new DataTable();
            adapter.Fill(dataTable);

            dgvEmpleados.DataSource = dataTable;
            conexion.Close();
        }

        private void AbrirFormularioAgregarEmpleado()
        {
            DatosEmpleado datosEmpleadoForm = new DatosEmpleado();
            datosEmpleadoForm.ShowDialog();
        }

        private void AbrirFormularioEditarEmpleado(Empleado empleado)
        {
            DatosEmpleado datosEmpleadoForm = new DatosEmpleado(empleado);
            datosEmpleadoForm.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.SelectedRows.Count > 0)
            {
                int idEmpleado = Convert.ToInt32(dgvEmpleados.SelectedRows[0].Cells["id_empleado"].Value);

                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este empleado?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        conexion.Open();

                        using (SqlCommand command = new SqlCommand("sp_EliminarEmpleado", conexion))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@id_empleado", idEmpleado);

                            command.ExecuteNonQuery();

                            MostrarTabla();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar el empleado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conexion.Close();
                    }
                }
            }
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.SelectedRows.Count > 0)
            {
                int idEmpleado = Convert.ToInt32(dgvEmpleados.SelectedRows[0].Cells["id_empleado"].Value);
                string nombre = dgvEmpleados.SelectedRows[0].Cells["nombre"].Value.ToString();
                string apellido = dgvEmpleados.SelectedRows[0].Cells["apellido"].Value.ToString();
                string direccion = dgvEmpleados.SelectedRows[0].Cells["direccion"].Value.ToString();
                decimal salario = decimal.Parse(dgvEmpleados.SelectedRows[0].Cells["salario"].Value.ToString());


                Empleado empleado = new Empleado
                {
                    IdEmpleado = idEmpleado,
                    Nombre = nombre,
                    Apellido = apellido,
                    Salario = salario,
                    Direccion = direccion
                };

                AbrirFormularioEditarEmpleado(empleado);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AbrirFormularioAgregarEmpleado();
        }
    }
}
