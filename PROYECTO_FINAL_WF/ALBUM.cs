using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_FINAL_WF
{
    class ALBUM
    {
        protected  string nombre;

        public string  Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public ALBUM ()
        {
            nombre ="";
        }
        public override string ToString()
        {
            return nombre + " " ;
        }

    }
}
