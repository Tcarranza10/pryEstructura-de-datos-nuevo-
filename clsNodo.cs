using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryEstructura_de_datos__nuevo_
{
    class clsNodo
    {
        private Int32 cod;
        private String nom;
        private String tram;
        private clsNodo sig;

        public Int32 Codigo
        {
            get { return cod; }
            set { cod = value; }
        }

        public String Nombre
        {
            get { return nom; }
            set { nom = value; }
        }
        public String Tramite
        {
            get { return tram; }
            set { tram = value; }
        }
        public clsNodo Siguiente
        {
            get { return sig; }
            set { sig = value; }
        }
    }
}
