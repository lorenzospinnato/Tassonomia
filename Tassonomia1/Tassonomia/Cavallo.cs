using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia
{
    class Cavallo : Quadrupede
    {
        public Cavallo() : base("Cavallo", "Animale Terrestre", "Fattoria", 4)
        { }
        public override string siMuove()
        {
            return "Galoppo";
        }
    }
}
