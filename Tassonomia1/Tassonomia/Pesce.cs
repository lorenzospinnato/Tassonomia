using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia
{
    abstract class Pesce:Animale_Acquatico
    {
        public Pesce(string nomeAnimale, string tipoAnimale, string habitat, int numeroZampe) : base(nomeAnimale, "Animale Acquatico", habitat, 0)
        { }
        public override string siMuove()
        {
            return "Nuoto";
        }
    }
}
