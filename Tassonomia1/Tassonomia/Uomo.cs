using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia
{
    class Uomo:Bipede
    {
        public Uomo() : base("Uomo", "Animale Terrestre", "Terra", 2)
        {
        }
        public override string siMuove()
        {
            return "Cammino";
        }
    }
}
