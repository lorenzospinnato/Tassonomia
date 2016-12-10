using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia
{
    abstract class Pesce:Animale_Marino
    {
        public Pesce(string nome, string specie, string habitat, int zampe, string manto):base(nome,"Pesce","Mare",0,manto)
        {

        }
        
    }
}
