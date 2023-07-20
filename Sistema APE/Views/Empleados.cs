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

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una fila en el DataGridView
            if (dgvEmpleados.SelectedRows.Count > 0)
            {
                // Obtener el índice de la fila seleccionada
                int indiceFilaSeleccionada = dgvEmpleados.SelectedRows[0].Index;

                // Obtener el DataRow correspondiente a la fila seleccionada
                DataRow filaSeleccionada = ((DataRowView)dgvEmpleados.Rows[indiceFilaSeleccionada].DataBoundItem).Row;

                // Crear un objeto Empleado a partir del DataRow
                Empleado empleadoSeleccionado = new Empleado
                {
                    IdEmpleado = Convert.ToInt32(filaSeleccionada["id_empleado"]),
                    Nombre = filaSeleccionada["nombre"].ToString(),
                    Apellido = filaSeleccionada["apellido"].ToString(),
                    // ... Asegúrate de agregar todos los demás atributos del empleado ...
                };

                // Abrir el formulario de edición con los datos del empleado seleccionado
                AbrirFormularioEditarEmpleado(empleadoSeleccionado);
            }
            else
            {
                MessageBox.Show("Seleccione un empleado para editar.", "Editar Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AbrirFormularioAgregarEmpleado();
        }
    }
}
