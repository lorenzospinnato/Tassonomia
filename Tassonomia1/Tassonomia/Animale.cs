using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia
{
    abstract class Animale
    {
        protected string nomeAnimale;
        protected string tipoAnimale;
        protected string habitat;
        protected int numeroZampe;
        public Animale(string na, string ta, string ha, int nz)
        {
            nomeAnimale=na;
            tipoAnimale=ta;
            habitat=ha;
            numeroZampe=nz;
        }
        public abstract string siMuove();
        public void riepilogo()
        {
            Console.WriteLine("Nome:" + nomeAnimale);
            Console.WriteLine("Tipo:" + tipoAnimale);
            Console.WriteLine("Habitat:" + habitat);
            Console.WriteLine("Numero di zampe:" + numeroZampe);
        }
    }
}
