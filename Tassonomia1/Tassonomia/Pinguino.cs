using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia
{
    class Pinguino:Uccello
    {
        public Pinguino() : base("Pinguino", "Animale Terrestre", "Ghiaccio", 2)
        { }
        public override string siMuove()
        {
            return "Cammino/Nuoto";
        }
    }
}
