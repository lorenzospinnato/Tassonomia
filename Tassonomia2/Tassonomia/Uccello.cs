using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia
{
    abstract class Uccello:Animale_Terrestre
    {
        public Uccello(string nome, string specie, string habitat, int zampe, string manto) : base(nome, "Uccello", "Terra", zampe, manto)
        {

        }
        public void setMantoPiumoso()
        {
            manto = "Piume";
        }
        public void setZampe()
        {
            numerozampe = 2;
        }
    }
}
