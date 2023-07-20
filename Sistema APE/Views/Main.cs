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
using Sistema_APE.Views;

namespace Sistema_APE
{
    public partial class Main : Form
    {
        private readonly Empleado empleado;
        public Main(Empleado empleado)
        {
            InitializeComponent();
            this.empleado = empleado;

            if (empleado.IdRol == 1)
            {
                // Solo el rol 1 puede dar clic en el botón de caja
                btnCaja.Enabled = true;
                btnPedidos.Enabled = false;
                btnInventario.Enabled = false;
                btnEmpleados.Enabled =false;
                btnProductos.Enabled = false;
            }
            else if (empleado.IdRol== 2)
            {
                // El rol 2 puede dar clic en los botones de caja, pedidos e inventario
                btnCaja.Enabled = true;
                btnPedidos.Enabled = true;
                btnInventario.Enabled = true;
                btnEmpleados.Enabled = false;
                btnProductos.Enabled = true;
            }
            else if (empleado.IdRol == 3)
            {
                // El rol 3 puede dar clic en todos los botones
                btnCaja.Enabled = true;
                btnPedidos.Enabled = true;
                btnInventario.Enabled = true;
                btnEmpleados.Enabled = true;
                btnProductos.Enabled = true;
            }
            else
            {
                // Si el rol no coincide con ninguno de los valores esperados, deshabilitar todos los botones por seguridad.
                btnCaja.Enabled = false;
                btnPedidos.Enabled = false;
                btnInventario.Enabled = false;
            }
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            Inventario Inventario = new Inventario();
            Inventario.TopLevel = false;
            Inventario.FormBorderStyle = FormBorderStyle.None;

            PanelContenedor.Controls.Clear();
            PanelContenedor.Controls.Add(Inventario);
            Inventario.Show();
        }

        private void PanelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            PanelContenedor.Size = ClientSize;
            lblNombreEmpleado.Text = empleado.Nombre + " " + empleado.Apellido;
        }

        private void btnCaja_Click(object sender, EventArgs e)
        {
            Caja Caja = new Caja();
            Caja.TopLevel = false;
            PanelContenedor.Controls.Clear();
            PanelContenedor.Controls.Add(Caja);
            Caja.Show();
        }
        
        private void btnPedidos_Click(object sender, EventArgs e)
        {
            Pedidos pedidos = new Pedidos();
            pedidos.TopLevel = false;
            PanelContenedor.Controls.Clear();
            PanelContenedor.Controls.Add(pedidos);
            pedidos.Show();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            Empleados empleado = new Empleados();
            empleado.TopLevel = false;
            PanelContenedor.Controls.Clear();
            PanelContenedor.Controls.Add(empleado);
            empleado.Show();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            ControlProductos productos = new ControlProductos();
            productos.TopLevel = false;
            PanelContenedor.Controls.Clear();
            PanelContenedor.Controls.Add(productos);
            productos.Show();
        }
    }
}
