using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia
{
    abstract class Animale_Marino:Animale_Acquatico
    {
        public Animale_Marino(string nomeAnimale, string tipoAnimale, string habitat, int numeroZampe): base(nomeAnimale, "Animale Acquatico", "Mare", 0)
        { }
    }
}
