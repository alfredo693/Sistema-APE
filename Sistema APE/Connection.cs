using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_APE
{
    public static class Connection
    {
        public static string getConnectionString()
        {
            string servidor = "localhost";
            string baseDatos = "ProyectoFinalTienda";
            string usuario = "sa";
            string password = "9cg43pqE";

            return $"Data Source={servidor};Initial Catalog={baseDatos};User ID={usuario};Password={password}";
        }
    }
}
