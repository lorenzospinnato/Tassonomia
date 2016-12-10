using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia
{
    abstract class Animale_Acquatico:Animale
    {
        public Animale_Acquatico(string nomeAnimale, string tipoAnimale, string habitat, int numeroZampe) : base(nomeAnimale, "Animale Acquatico", habitat, 0)
        {
        }

    }
}
