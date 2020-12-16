using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_FINAL_WF
{
    class POP : ALBUM
    {

        protected string canciones;

        public string Canciones
        {
            get { return canciones; }
            set { canciones = value; }
        }

        public POP() : base ()
        {
            canciones= "";
        }
        public override string ToString()
        {
            return canciones +  " " + base.ToString(); ;
        }

    }
}

