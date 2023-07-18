using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_APE.Models
{
    public class Inventario
    {
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public DateTime FechaActualizacion { get; set; }
    }
}
