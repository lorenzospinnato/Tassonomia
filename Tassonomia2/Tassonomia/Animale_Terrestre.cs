using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia
{
    abstract class Animale_Terrestre:Animale
    {
        public Animale_Terrestre(string nome, string specie, string habitat, int zampe, string manto):base(nome,specie,habitat,zampe,manto)
        {

        }
    }
}
