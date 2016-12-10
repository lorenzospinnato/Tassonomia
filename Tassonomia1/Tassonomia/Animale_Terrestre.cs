using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia
{
    abstract class Animale_Terrestre:Animale
    {
        public Animale_Terrestre(string nomeAnimale, string tipoAnimale, string habitat, int numeroZampe): base(nomeAnimale, "Animale Terrestre", "Mare", 0)
        { }
    }
}
