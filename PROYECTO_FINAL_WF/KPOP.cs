using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_FINAL_WF
{
    class KPOP : ALBUM
    {

        protected string artista;

        public string  Artista
        {
            get { return artista; }
            set { artista = value; }
        }

        public KPOP() : base ()
        {
            artista = "";
        }
        public override string ToString()
        {
            return artista  +" " + base.ToString(); ;
        }

    }
}

