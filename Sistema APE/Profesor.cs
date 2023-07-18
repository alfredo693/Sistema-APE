using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_APE
{
    class Profesor : Personal
    {
        private int _intID;

        public int ID
        {
            get { return _intID; }
            set { _intID = value; }
        }

        private string _strGrupo;

        public string Grupo
        {
            get { return _strGrupo; }
            set { _strGrupo = value; }
        }


        private int _intCedula;

        public int Cedula
        {
            get { return _intCedula; }
            set { _intCedula = value; }
        }




    }
}
