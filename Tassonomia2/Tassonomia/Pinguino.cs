using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia
{
    class Pinguino : Uccello_Marino, Animale_Piumoso
    {
        public Pinguino():base("Pinguino","Uccello_Marino","Ghiaccio",2,"")
        {

        }
        public void setMantoPiumoso()
        {
            manto = "Piume";
        }
        public override string siMuove()
        {
            return "Nuoto/Cammino";
        }
    }
}
