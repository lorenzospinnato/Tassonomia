using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia
{
    class Salmone:Pesce
    {
        public Salmone() : base("Salmone", "Animale Acquatico", "Fiume", 0)
        { }
        public override string siMuove()
        {
            return "Nuoto";
        }
    }
}
