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

namespace Sistema_APE
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private string ObtenerNombreEmpleado(string nombreUsuario)
        {
            string nombreCompleto = string.Empty;

            string connectionString = Connection.getConnectionString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT e.nombre, e.apellido FROM usuarios u INNER JOIN empleados e ON u.id_empleado = e.id_empleado WHERE u.nombre_usuario = @nombreUsuario";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);

                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        string nombre = reader["nombre"].ToString();
                        string apellido = reader["apellido"].ToString();
                        nombreCompleto = $"{nombre} {apellido}";
                    }

                    reader.Close();
                }
            }

            return nombreCompleto;
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

                    if (result > 0)
                    {
                        String nombreEmpleado = ObtenerNombreEmpleado(nombreUsuario);

                        Main formPrincipal = new Main(nombreEmpleado);
                        this.Hide();
                        formPrincipal.ShowDialog();
                        this.Close();
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
            radAlmacen.Checked = true;
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
