using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia
{
    class Uomo : Mammifero_Terrestre, Bipede, Animale_Peloso
    {
        public Uomo() : base("Uomo", "Terrestre", "Terra", 0, "")
        {

        }
        public void setMantoPeloso()
        {
            manto = "SemiPeloso";
        }
        public void setZampe()
        {
            numerozampe = 2;
        }
        public override string siMuove()
        {
            return "Cammino";
        }
    }
}
