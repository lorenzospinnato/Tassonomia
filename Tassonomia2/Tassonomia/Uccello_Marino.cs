using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia
{
    abstract class Uccello_Marino:Animale_Marino
    {
        public Uccello_Marino(string nome, string specie, string habitat, int zampe, string manto):base(nome,"Uccello Marino",habitat,zampe,manto)
        {

        }
        public override string siMuove()
        {
            return "Cammino";
        }
        public void setMantoPiumoso()
        {
            manto = "piume";
        }
        public void setZampe()
        {
            numerozampe = 2;
        }
    }
}
