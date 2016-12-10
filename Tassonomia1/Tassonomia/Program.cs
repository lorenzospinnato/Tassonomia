using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia
{
    class Program
    {
        static void Main(string[] args)
        {
            Uomo u = new Uomo();
            Pinguino pi = new Pinguino();
            Tonno t = new Tonno();
            Salmone s = new Salmone();
            Corvo c = new Corvo();
            Cavallo ca = new Cavallo();


            u.riepilogo();
            Console.WriteLine(u.siMuove());
            Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-");


            pi.riepilogo();
            Console.WriteLine(pi.siMuove());
            Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-");


            t.riepilogo();
            Console.WriteLine(t.siMuove());
            Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-");


            s.riepilogo();
            Console.WriteLine(s.siMuove());
            Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-");


            c.riepilogo();
            Console.WriteLine(c.siMuove());
            Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-");


            ca.riepilogo();
            Console.WriteLine(ca.siMuove());
            Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-");

            Console.ReadLine();
        }
    }
}
