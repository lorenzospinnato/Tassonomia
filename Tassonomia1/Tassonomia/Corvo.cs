using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia
{
    class Corvo : Uccello
    {
        public Corvo() : base("Corvo", "Animale Terrestre", "Bosco", 2)
        { }
        public override string siMuove()
        {
            return "Volo";
        }
    }
}

