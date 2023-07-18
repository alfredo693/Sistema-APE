using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_APE
{
    public class Producto
    {
            public int IdProducto { get; set; }
            public string Nombre { get; set; }
            public string Descripcion { get; set; }
            public decimal Precio { get; set; }
            public int Stock { get; set; }
            public string Categoria { get; set; }
            public string Marca { get; set; }

    }
    public class Categoria
    {
        public int IdCategoria { get; set; }
        public string Nombre { get; set; }
    }

    public class Marca
    {
        public int IdMarca { get; set; }
        public string Nombre { get; set; }
    }

}
