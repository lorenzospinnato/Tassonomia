using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia
{
    abstract class Bipede:Animale_Terrestre
    {
        public Bipede(string nomeAnimale, string tipoAnimale, string habitat, int numeroZampe) : base(nomeAnimale, "Animale Terrestre", habitat, 2)
        { }
    }
}
