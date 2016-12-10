using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia
{
    abstract class Animale
    {
        protected string nomeanimale;
        protected string specieanimale;
        protected string habitat;
        protected int numerozampe;
        protected string manto;

        public Animale(string na, string sa, string ha, int nz, string ma)
        {
            nomeanimale=na;
            specieanimale=sa;
            habitat=ha;
            numerozampe=nz;
        }

        public abstract string siMuove();

        public void riepilogo()
        {
            Console.WriteLine("NOME:" + nomeanimale);
            Console.WriteLine("SPECIE:" + specieanimale);
            Console.WriteLine("HABITAT:" + habitat);
            Console.WriteLine("ZAMPE:" + numerozampe);
        }
    }
}
