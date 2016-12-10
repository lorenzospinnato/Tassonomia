using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia
{
    class Cavallo : Animale_Terrestre, Animale_Peloso, Quadrupede
    {
        public Cavallo():base("Cavallo","Mammifero Terrestre","Fattoria",0,"")
        {

        }
        public void setMantoPeloso()
        {
            manto = "Pelo";
        }
        public void setZampe()
        {
            numerozampe = 4;
        }
        public override string siMuove()
        {
            return "Galoppo";
        }
    }
}
