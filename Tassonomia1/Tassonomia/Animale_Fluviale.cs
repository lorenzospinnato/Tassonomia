using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia
{
    abstract class Animale_Fluviale:Animale_Acquatico
    {
        public Animale_Fluviale(string nomeAnimale, string tipoAnimale, string habitat, int numeroZampe) : base(nomeAnimale, "Animale Acquatico", "fiume", 0)
        { }
    }
}
