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
using System.Runtime.InteropServices;
using Sistema_APE.Models;

namespace Sistema_APE
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private Empleado ObtenerEmpleadoCompleto(string nombreUsuario)
        {
            Empleado empleado = null;

            string connectionString = Connection.getConnectionString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM usuarios u INNER JOIN empleados e ON u.id_empleado = e.id_empleado WHERE u.nombre_usuario = @nombreUsuario";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);

                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        empleado = new Empleado
                        {
                            IdEmpleado = Convert.ToInt32(reader["id_empleado"]),
                            Nombre = reader["nombre"].ToString(),
                            Apellido = reader["apellido"].ToString(),
                            IdRol = Convert.ToInt32(reader["id_rol"]),
                            // Asignar otras propiedades del empleado según la estructura de tu tabla
                        };
                    }

                    reader.Close();
                }
            }

            return empleado;
        }


        private void btnAcceder_Click(object sender, EventArgs e)
        {
            string connectionString = Connection.getConnectionString();

            string nombreUsuario = txtUsuario.Text;
            string password = txtPassword.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM usuarios WHERE nombre_usuario = @nombreUsuario AND contraseña = @contraseña";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                    command.Parameters.AddWithValue("@contraseña", password);

                    connection.Open();

                    int result = (int)command.ExecuteScalar();

                    // Dentro del evento btnAcceder_Click
                    if (result > 0)
                    {
                        // Obtener el objeto Empleado completo desde la base de datos
                        Empleado empleado = ObtenerEmpleadoCompleto(nombreUsuario);

                        if (empleado != null)
                        {
                            Main formPrincipal = new Main(empleado);
                            this.Hide();
                            formPrincipal.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo obtener la información del empleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nombre de usuario o contraseña incorrectos.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtUsuario.Text = "JEguia100";
            txtPassword.Text = "JEguia";
        }

        private void picMinimizarCerrar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraInicio_Paint(object sender, PaintEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
