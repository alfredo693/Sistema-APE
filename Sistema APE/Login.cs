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

        SqlConnection conexion = new SqlConnection("server = ALFREDOLOPEZ; database = TIENDADETECNOLOGIA; integrated security = true");

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            if (radVendedor.Checked)
            {
                AccesosGerente(this.txtUsuario.Text, this.txtPassword.Text);
            }
            if (radGerente.Checked)
            {
                AccesoVendedor(this.txtUsuario.Text, this.txtPassword.Text);
            }
            if (radAlmacen.Checked)
            {
                AccesoAlmacen(this.txtUsuario.Text, this.txtPassword.Text);
            }
        }


        public void AccesosGerente(string usuario, string contraseña)
        {
            try
            {
                SqlCommand comando1 = new SqlCommand(" Select nombre FROM Empleados  WHERE nombre= @Usuario AND  clave= @Contrasena and id_puesto = 1", conexion);
                comando1.Parameters.AddWithValue("Usuario", usuario);
                comando1.Parameters.AddWithValue("Contrasena", contraseña);

                SqlDataAdapter adaptador = new SqlDataAdapter(comando1);
                DataTable Usuarios = new DataTable();
                adaptador.Fill(Usuarios);
                if (Usuarios.Rows.Count == 1)
                {
                    MessageBox.Show("Bienvenida/o");
                    Form.ActiveForm.Visible = false;
                    Main Main = new Main();
                    Main.Show();
                }
                else
                {
                    MessageBox.Show("Usuario y|o Cotraseña incorrecta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conexion.Close();
            }
        }
        public void AccesoVendedor(string usuario, string contraseña)
        {
            try
            {
                SqlCommand comando1 = new SqlCommand(" Select Nombre FROM Empleados  WHERE nombre= @Usuario AND  clave= @Contrasena and id_puesto = 3", conexion);
                comando1.Parameters.AddWithValue("Usuario", usuario);
                comando1.Parameters.AddWithValue("Contrasena", contraseña);

                SqlDataAdapter adaptador = new SqlDataAdapter(comando1);
                DataTable Empleados = new DataTable();
                adaptador.Fill(Empleados);
                if (Empleados.Rows.Count == 1)
                {
                    MessageBox.Show("Bienvenida/o");
                    Form.ActiveForm.Visible = false;
                    //Gerente gerente = new Gerente();
                    //gerente.Show();
                }
                else
                {
                    MessageBox.Show("Usuario y|o Cotraseña incorrecta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conexion.Close();
            }
        }
        public void AccesoAlmacen(string usuario, string contraseña)
        {
            try
            {
                SqlCommand comando1 = new SqlCommand(" Select Nombre FROM Empleados  WHERE nombre= @Usuario AND  clave= @Contrasena AND id_puesto = 4", conexion);
                comando1.Parameters.AddWithValue("Usuario", usuario);
                comando1.Parameters.AddWithValue("Contrasena", contraseña);

                SqlDataAdapter adaptador = new SqlDataAdapter(comando1);
                DataTable Empleados = new DataTable();
                adaptador.Fill(Empleados);
                if (Empleados.Rows.Count == 1)
                {
                    MessageBox.Show("Bienvenida/o");
                    Form.ActiveForm.Visible = false;
                    Main Inventario = new Main();
                    Inventario.Show();
                }
                else
                {
                    MessageBox.Show("Usuario y|o Cotraseña incorrecta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conexion.Close();
            }
        }



        private void Login_Load(object sender, EventArgs e)
        {
            radAlmacen.Checked = true;
            txtUsuario.Text = "Mario";
            txtPassword.Text = "12345";
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
