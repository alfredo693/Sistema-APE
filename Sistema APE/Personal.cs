using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_APE
{
    class Personal
    {

        private string _strUsuario;

        public string Usuario
        {
            get { return _strUsuario; }
            set { _strUsuario = value; }
        }
        private string _strPassword;

        public string Password
        {
            get { return _strPassword; }
            set { _strPassword = value; }
        }
        private string _strNombre;

        public string Nombre
        {
            get { return _strNombre; }
            set { _strNombre = value; }
        }

    }
}
