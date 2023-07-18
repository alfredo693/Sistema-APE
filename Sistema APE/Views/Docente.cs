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
using System.Threading;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace Sistema_APE
{
    public partial class Docente : Form
    {
        public Docente()
        {
            InitializeComponent();
        }

        //SqlConnection conexion = new SqlConnection("server = LAPTOP-0V1K6DNO\\SQLEXPRESS ; database = BORRADORPROYECTO; integrated security = true");
        SqlConnection conexion = new SqlConnection("server = DESKTOP-ME7K31C\\MSSQLSERVER01 ; database = BORRADORPROYECTO; integrated security = true");

        private void Docente_Load(object sender, EventArgs e)
        {
            /* dtgAlumnosIncripcion.Columns.Add("Nombre", "Nombre");
          dtgAlumnosIncripcion.Columns.Add("Apelido paterno", "Apellido paterno");
          dtgAlumnosIncripcion.Columns.Add("Apelido materno", "Apellido materno");
           dtgAlumnosIncripcion.Columns.Add("GradoyGrupo", "GradoyGrupo");
           dtgAlumnosIncripcion.Columns.Add("CURP", "CURP");
           dtgAlumnosIncripcion.Columns.Add("Edad", "Edad");
          dtgAlumnosIncripcion.Columns.Add("Genero", "Genero");
          dtgAlumnosIncripcion.Columns.Add("Nombre de la madre", "Nombre de la madre");
          dtgAlumnosIncripcion.Columns.Add("Nombre del padre", "Nombre del padre");
          dtgAlumnosIncripcion.Columns.Add("Direccion", "Direccion");
          dtgAlumnosIncripcion.Columns.Add("FechaNa", "FechaNa");

           dtgProfesor.Columns.Add("ID", "ID");
           dtgProfesor.Columns.Add("Nombre", "Nombre");
           dtgProfesor.Columns.Add("Telefono", "Telefono");*/

            //CONSULTA Y MUESTRA LA TABLA EN LOS DTG DE LOS REGISTROS NUEVOS Y LS QUE YA ESTABAN EN LA BD
            conexion.Open();
            SqlCommand comando = new SqlCommand(" Select * from ALUMNOS", conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;


            SqlCommand comando1 = new SqlCommand(" Select * from PROFESORES1", conexion);
            SqlDataAdapter adaptador1 = new SqlDataAdapter();
            adaptador.SelectCommand = comando1;
            DataTable PROFESORES1 = new DataTable();
            adaptador.Fill(PROFESORES1);
            dtgProfesor.DataSource = PROFESORES1;
            conexion.Close();
        }

        private void btnRegistrarProfesor_Click(object sender, EventArgs e)
        {
            RegistarProfesor();
        }

        private void RegistarProfesor()
        {
            conexion.Open();
            Profesor unProfe = new Profesor();
            try
            {

                unProfe.ID = int.Parse(txtIDprofe.Text);
                unProfe.Nombre = txtnombreProfe.Text;
                unProfe.Cedula = int.Parse(txtcedula.Text);
                unProfe.Grupo = cboGrupo.Text;
                unProfe.Usuario = txtusuario.Text;
                unProfe.Password = txtPassword.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("No puede dejar espacios en blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                string cadena = "insert into PROFESORES1(UsuarioP,ContrasenaP,NombreP,IDP,Cedula,Grupo) values ('" + unProfe.Usuario + "','" + unProfe.Password + "','" + unProfe.Nombre + "','" + unProfe.ID + "','" + unProfe.Cedula + "','" + unProfe.Grupo + "')";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("Se agrego correctamente");
                SqlCommand comando1 = new SqlCommand(" Select * from PROFESORES1", conexion);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando1;
                DataTable Profesores = new DataTable();
                adaptador.Fill(Profesores);
                dtgProfesor.DataSource = Profesores;
            }
            conexion.Close();
            foreach (Control x in grpProfesor.Controls)
                if (x is TextBox)
                    x.Text = "";
        }



        //MODIFICAR/ACTUALIZAR PROFESORES====================================================================================================================
        private void ConsultarProfe(string usuario)
        {
            Profesor unProfe = new Profesor();
            conexion.Open();
            string usuarioP = usuario;

            string cadena = "select UsuarioP,ContrasenaP,NombreP,Grupo,IDP,Cedula,Grupo from PROFESORES1 where UsuarioP= '" + usuarioP + "'";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                unProfe.Nombre = registro["NombreP"].ToString();
                unProfe.Grupo = registro["Grupo"].ToString();
                unProfe.Cedula = int.Parse(registro["Cedula"].ToString());
                unProfe.Usuario = registro["UsuarioP"].ToString();
                unProfe.Password = registro["ContrasenaP"].ToString();
                unProfe.ID = int.Parse(registro["IDP"].ToString());

                txtnombreProfe.Text = unProfe.Nombre;
                cboGrupo.Text = unProfe.Grupo;
                txtcedula.Text = unProfe.Cedula.ToString();
                txtusuario.Text = unProfe.Usuario;
                txtPassword.Text = unProfe.Password;
                txtIDprofe.Text = unProfe.ID.ToString();
                conexion.Close();
            }
            else

                MessageBox.Show("No existe un profesor con el ID ingresado");
            conexion.Close();
        }

        private void btnModificarProfe_Click(object sender, EventArgs e)
        {
            string usuarioProfesor = "";
            DataGridViewRow renglonSeleccionado = dtgProfesor.CurrentRow;
            if (renglonSeleccionado == null)
            {
                MessageBox.Show("Seleccione un renglon", "ERROR", MessageBoxButtons.OK,
               MessageBoxIcon.Error);

            }
            else
            {
                try
                {
                    usuarioProfesor = renglonSeleccionado.Cells[0].Value.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Seleccione un renglon", "ERROR", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }

                Profesor unProfe = new Profesor();
                try
                {

                    unProfe.ID = int.Parse(txtIDprofe.Text);
                    unProfe.Nombre = txtnombreProfe.Text;
                    unProfe.Cedula = int.Parse(txtcedula.Text);
                    unProfe.Grupo = cboGrupo.Text;
                    unProfe.Usuario = txtusuario.Text;
                    unProfe.Password = txtPassword.Text;
                }
                catch (Exception)
                {
                    MessageBox.Show("No puede dejar espacios en blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    string scriptModifProfe = "update PROFESORES1 set UsuarioP= @Usuario, ContrasenaP= @Contrasena, " +
                        "NombreP= @Nombre, IDP= @ID, Cedula= @Cedula, Grupo= @Grupo where UsuarioP= '" + usuarioProfesor + "'";
                    conexion.Open();

                    SqlCommand comandoModificarProfe = new SqlCommand(scriptModifProfe, conexion);
                    comandoModificarProfe.Parameters.AddWithValue("@Usuario", unProfe.Usuario);
                    comandoModificarProfe.Parameters.AddWithValue("@Contrasena", unProfe.Password);
                    comandoModificarProfe.Parameters.AddWithValue("@Nombre", unProfe.Nombre);
                    comandoModificarProfe.Parameters.AddWithValue("@ID", unProfe.ID);
                    comandoModificarProfe.Parameters.AddWithValue("@Cedula", unProfe.Cedula);
                    comandoModificarProfe.Parameters.AddWithValue("@Grupo", unProfe.Grupo);

                    comandoModificarProfe.ExecuteNonQuery();
                    MessageBox.Show("Profesor actualizado correctamente");

                    SqlCommand comandoMostrarProfe = new SqlCommand(" Select * from PROFESORES1", conexion);
                    SqlDataAdapter adaptador = new SqlDataAdapter();
                    adaptador.SelectCommand = comandoMostrarProfe;
                    DataTable PROFESORES1 = new DataTable();
                    adaptador.Fill(PROFESORES1);
                    dtgProfesor.DataSource = PROFESORES1;
                    conexion.Close();
                }
            }
        }

        private void btnBuscarProfe_Click(object sender, EventArgs e)
        {
            try
            {
                if (radUsuarioProfe.Checked)
                {
                    ConsultarPorUsuario();
                }
                if (radNombreProfe.Checked)
                {
                    ConsultarPorNombre();
                }
                if (radCedula.Checked)
                {
                    ConsultarPorCedula();
                }
                if (radIDProfe.Checked)
                {
                    ConsultarPorID();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Introduzca una palabra clave para buscar el profesor de acuerdo a la opción que eligió", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConsultarPorUsuario()
        {
            Profesor unProfe = new Profesor();
            conexion.Open();

            string strUsuario = txtBuscarProfe.Text;

            string consultaProfe = "select UsuarioP, ContrasenaP, NombreP, IDP, Cedula, Grupo from PROFESORES1 where UsuarioP= '" + strUsuario + "'";
            SqlCommand comandoProfe = new SqlCommand(consultaProfe, conexion);
            SqlDataReader registroProfe = comandoProfe.ExecuteReader();
            if (registroProfe.Read())
            {
                unProfe.Nombre = registroProfe["NombreP"].ToString();
                unProfe.Grupo = registroProfe["Grupo"].ToString();
                unProfe.Cedula = int.Parse(registroProfe["Cedula"].ToString());
                unProfe.Usuario = registroProfe["UsuarioP"].ToString();
                unProfe.Password = registroProfe["ContrasenaP"].ToString();
                unProfe.ID = int.Parse(registroProfe["IDP"].ToString());

                conexion.Close();
            }
            else
            {
                MessageBox.Show("No existe un profesor con ese usuario");
            }

            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comandoProfe;
            DataTable PROFESORES1 = new DataTable();
            adaptador.Fill(PROFESORES1);
            dtgProfesor.DataSource = PROFESORES1;

            conexion.Close();
            registroProfe.Close();

        }

        private void ConsultarPorNombre()
        {
            Profesor unProfe = new Profesor();
            conexion.Open();

            string strNombre = txtBuscarProfe.Text;

            string consultaProfe = "select UsuarioP, ContrasenaP, NombreP, IDP, Cedula, Grupo from PROFESORES1 where NombreP= '" + strNombre + "'";
            SqlCommand comandoProfe = new SqlCommand(consultaProfe, conexion);
            SqlDataReader registroProfe = comandoProfe.ExecuteReader();
            if (registroProfe.Read())
            {
                unProfe.Nombre = registroProfe["NombreP"].ToString();
                unProfe.Grupo = registroProfe["Grupo"].ToString();
                unProfe.Cedula = int.Parse(registroProfe["Cedula"].ToString());
                unProfe.Usuario = registroProfe["UsuarioP"].ToString();
                unProfe.Password = registroProfe["ContrasenaP"].ToString();
                unProfe.ID = int.Parse(registroProfe["IDP"].ToString());

                conexion.Close();
            }
            else
            {
                MessageBox.Show("No existe un profesor con ese nombre");
            }

            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comandoProfe;
            DataTable PROFESORES1 = new DataTable();
            adaptador.Fill(PROFESORES1);
            dtgProfesor.DataSource = PROFESORES1;

            conexion.Close();
            registroProfe.Close();

        }

        private void ConsultarPorCedula()
        {
            Profesor unProfe = new Profesor();
            conexion.Open();

            string strCedula = txtBuscarProfe.Text;

            string consultaProfe = "select UsuarioP, ContrasenaP, NombreP, IDP, Cedula, Grupo from PROFESORES1 where Cedula= '" + strCedula + "'";
            SqlCommand comandoProfe = new SqlCommand(consultaProfe, conexion);
            SqlDataReader registroProfe = comandoProfe.ExecuteReader();
            if (registroProfe.Read())
            {
                unProfe.Nombre = registroProfe["NombreP"].ToString();
                unProfe.Grupo = registroProfe["Grupo"].ToString();
                unProfe.Cedula = int.Parse(registroProfe["Cedula"].ToString());
                unProfe.Usuario = registroProfe["UsuarioP"].ToString();
                unProfe.Password = registroProfe["ContrasenaP"].ToString();
                unProfe.ID = int.Parse(registroProfe["IDP"].ToString());

                conexion.Close();
            }
            else
            {
                MessageBox.Show("No existe un profesor con esa cedula");
            }

            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comandoProfe;
            DataTable PROFESORES1 = new DataTable();
            adaptador.Fill(PROFESORES1);
            dtgProfesor.DataSource = PROFESORES1;

            conexion.Close();
            registroProfe.Close();

        }

        private void ConsultarPorID()
        {
            Profesor unProfe = new Profesor();
            conexion.Open();

            string strID = txtBuscarProfe.Text;

            string consultaProfe = "select UsuarioP, ContrasenaP, NombreP, IDP, Cedula, Grupo from PROFESORES1 where IDP= '" + strID + "'";
            SqlCommand comandoProfe = new SqlCommand(consultaProfe, conexion);
            SqlDataReader registroProfe = comandoProfe.ExecuteReader();
            if (registroProfe.Read())
            {
                unProfe.Nombre = registroProfe["NombreP"].ToString();
                unProfe.Grupo = registroProfe["Grupo"].ToString();
                unProfe.Cedula = int.Parse(registroProfe["Cedula"].ToString());
                unProfe.Usuario = registroProfe["UsuarioP"].ToString();
                unProfe.Password = registroProfe["ContrasenaP"].ToString();
                unProfe.ID = int.Parse(registroProfe["IDP"].ToString());

                conexion.Close();
            }
            else
            {
                MessageBox.Show("No existe un profesor con ese ID");
            }

            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comandoProfe;
            DataTable PROFESORES1 = new DataTable();
            adaptador.Fill(PROFESORES1);
            dtgProfesor.DataSource = PROFESORES1;

            conexion.Close();
            registroProfe.Close();

        }


        private void btnEliminarProfe_Click(object sender, EventArgs e)
        {
            string usuarioProfesor = "";
            DataGridViewRow renglonSeleccionado = dtgProfesor.CurrentRow;
            if (renglonSeleccionado == null)
            {
                MessageBox.Show("Seleccione un renglon", "ERROR", MessageBoxButtons.OK,
               MessageBoxIcon.Error);

            }
            else
            {
                try
                {
                    usuarioProfesor = renglonSeleccionado.Cells[0].Value.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Seleccione un renglon", "ERROR", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }

                if (MessageBox.Show("¿Desea eliminar el profesor seleccionado?", "ELIMINAR PROFESOR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string scriptEliminar = "delete from PROFESORES1 where UsuarioP= '" + usuarioProfesor + "'";
                    conexion.Open();
                    SqlCommand comandoEliminarProfe = new SqlCommand(scriptEliminar, conexion);
                    comandoEliminarProfe.ExecuteNonQuery();
                    MessageBox.Show("Profesor Eliminado correctamente");

                    SqlCommand comandoMostrarProfes = new SqlCommand(" Select * from PROFESORES1", conexion);
                    SqlDataAdapter adaptador = new SqlDataAdapter();
                    adaptador.SelectCommand = comandoMostrarProfes;
                    DataTable PROFESORES1 = new DataTable();
                    adaptador.Fill(PROFESORES1);
                    dtgProfesor.DataSource = PROFESORES1;
                    conexion.Close();
                }
                else
                {
                    MessageBox.Show("Operación cancelada por el admin", "ELIMINACION FALLIDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnVerTodosProfes_Click(object sender, EventArgs e)
        {
            conexion.Open();
            SqlCommand comando1 = new SqlCommand(" Select * from PROFESORES1", conexion);
            SqlDataAdapter adaptador1 = new SqlDataAdapter();
            adaptador1.SelectCommand = comando1;
            DataTable PROFESORES1 = new DataTable();
            adaptador1.Fill(PROFESORES1);
            dtgProfesor.DataSource = PROFESORES1;
            conexion.Close();
        }

        private void btnListaProfes_Click(object sender, EventArgs e)
        {
            GenerarListaPdf1();
            MessageBox.Show("Se ha guardado con éxito", "SE HA GUARDADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void GenerarListaPdf1()
        {
            try
            {
                Document doc = new Document(PageSize.A4);

                SaveFileDialog dlg = new SaveFileDialog();
                dlg.Filter = "PDF Files|*.pdf";
                dlg.FilterIndex = 0;
                string fileName = string.Empty;
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    fileName = dlg.FileName;
                    PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(fileName, FileMode.Create));

                    doc.Open();
                    Paragraph titulo = new Paragraph("LISTA DE DOCENTES", FontFactory.GetFont(FontFactory.TIMES_BOLD, 30));
                    titulo.Alignment = Element.ALIGN_CENTER;
                    doc.Add(titulo);
                    //ESTILO DE LETRAS
                    iTextSharp.text.Font _letraDatos = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                    BaseFont letraDatos = BaseFont.CreateFont(BaseFont.COURIER, BaseFont.CP1250, BaseFont.NOT_EMBEDDED);
                    iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 13, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                    //TABLA PARA DATOS DEL GRUPO
                    PdfPTable tblDatos = new PdfPTable(2);
                    tblDatos.WidthPercentage = 100f;
                    float[] medidaCeldas2 = { 8f, 8.50f };  //          
                    tblDatos.SetWidths(medidaCeldas2);
                    tblDatos.SpacingBefore = 25;
                    PdfPCell cl1 = new PdfPCell(new Phrase("   ", _standardFont));
                    cl1.BorderWidth = 0;
                    PdfPCell cl2 = new PdfPCell(new Phrase(" "));
                    cl2.BorderWidth = 0;
                    // Añadimos las celdas a la tabla
                    tblDatos.AddCell(cl1);
                    tblDatos.AddCell(cl2);
                    // Llenamos la tabla con información
                    cl1 = new PdfPCell(new Phrase(""));
                    //cl1.VerticalAlignment = CenterToParent;
                    //cl1.BorderWidth = 0;
                    cl1.BorderWidth = 0;
                    cl2 = new PdfPCell(new Phrase(""));
                    cl2.BorderWidth = 0;

                    // Añadimos las celdas a la tabla
                    tblDatos.AddCell(cl1);
                    tblDatos.AddCell(cl2);

                    tblDatos.HorizontalAlignment = Element.ALIGN_LEFT;
                    tblDatos.SpacingAfter = 30;
                    //TABLA CON LOS ALUMNOS
                    PdfPTable pdfTableProfes = new PdfPTable(dtgProfesor.ColumnCount);
                    pdfTableProfes.DefaultCell.Padding = 3;
                    float[] medidaCeldas = { 6f, 6f, 6f, 6f, 6f, 6f, };  //          
                    pdfTableProfes.SetWidths(medidaCeldas);
                    pdfTableProfes.WidthPercentage = 100f;
                    // pdfTableAlumnos.WidthPercentage = 100;
                    pdfTableProfes.HorizontalAlignment = Element.ALIGN_LEFT;
                    pdfTableProfes.DefaultCell.BorderWidth = 0;
                    pdfTableProfes.SpacingAfter = 0;

                    //Adding Header row
                    foreach (DataGridViewColumn column in dtgProfesor.Columns)
                    {
                        PdfPCell cell1 = new PdfPCell(new Phrase(column.HeaderText));
                        cell1.BackgroundColor = new BaseColor(206, 240, 255);
                        cell1.Border = 0;

                        pdfTableProfes.AddCell(cell1);

                    }

                    //Adding DataRow
                    for (int i = 0; i < dtgProfesor.RowCount - 1; i++)
                    {
                        for (int j = 0; j < dtgProfesor.ColumnCount; j++)
                        {
                            if (dtgProfesor[j, i].Value != null)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(dtgProfesor[j, i].Value.ToString()));
                                cell.Border = 0;

                                pdfTableProfes.AddCell(cell);
                            }


                        }
                        pdfTableProfes.CompleteRow();
                    }
                    doc.Add(tblDatos);
                    doc.Add(pdfTableProfes);
                    doc.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                //    MessageBox.Show("Ha ocurrido un error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar la sesión como Admin?", "CERRAR SESIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form.ActiveForm.Visible = false;
                Login Lg = new Login();
                Lg.Show();
            }
            else
            {
                MessageBox.Show("Operación cancelada por el admin", "CANCELADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgProfesor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string usuarioProfesor = "";
            DataGridViewRow renglonSeleccionado = dtgProfesor.CurrentRow;
            usuarioProfesor = renglonSeleccionado.Cells[0].Value.ToString();
            ConsultarProfe(usuarioProfesor);
        }
    }
}
