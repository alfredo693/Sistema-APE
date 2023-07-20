using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_APE.Models;

namespace Sistema_APE.Views
{
    public partial class DatosEmpleado : Form
    {
        private Empleado empleado;
        public DatosEmpleado(Empleado empleado = null)
        {
            InitializeComponent();
            this.empleado = empleado;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void DatosEmpleado_Load(object sender, EventArgs e)
        {
            txtNombre.Text = empleado.Nombre;
            txtApellido.Text = empleado.Apellido;
            dtpFechaNacimiento.Value = empleado.FechaNacimiento;
            txtDireccion.Text = empleado.Direccion;
            txtSalario.Text = empleado.Salario.ToString();
        }
    }
}
