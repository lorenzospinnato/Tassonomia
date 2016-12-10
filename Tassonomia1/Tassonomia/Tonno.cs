using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia
{
    class Tonno:Pesce
    {
        public Tonno() : base("Tonno", "Animale Acquatico", "Mare", 0)
        { }
        public override string siMuove()
        {
            return "Nuoto";
        }
    }
}
