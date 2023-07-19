using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_APE.Views;

namespace Sistema_APE
{
    public partial class Main : Form
    {
        private string nombreEmpleado;
        public Main(string nombreEmpleado)
        {
            InitializeComponent();
            this.nombreEmpleado = nombreEmpleado;
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
        }

        private void picCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCaja_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario que deseas mostrar
            Caja Caja = new Caja();

            // Establecer la propiedad TopLevel del formulario en false para que se pueda mostrar dentro de otro control
            Caja.TopLevel = false;

            PanelContenedor.Controls.Clear();

            // Agregar el formulario al panel
            PanelContenedor.Controls.Add(Caja);

            // Mostrar el formulario dentro del panel
            Caja.Show();
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario que deseas mostrar
            Compras Compras = new Compras();

            // Establecer la propiedad TopLevel del formulario en false para que se pueda mostrar dentro de otro control
            Compras.TopLevel = false;

            PanelContenedor.Controls.Clear();
                
            // Agregar el formulario al panel
            PanelContenedor.Controls.Add(Compras);

            // Mostrar el formulario dentro del panel
            Compras.Show();
        }

        private void picCerrar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            Pedidos pedidos = new Pedidos();
            pedidos.TopLevel = false;
            PanelContenedor.Controls.Clear();
            PanelContenedor.Controls.Add(pedidos);
            pedidos.Show();
        }
    }
}
