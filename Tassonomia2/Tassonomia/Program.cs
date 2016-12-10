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

            Balena b = new Balena();
            Cavallo ca = new Tassonomia.Cavallo();
            Corvo co = new Corvo();
            Ippopotamo i = new Ippopotamo();
            Salmone sa = new Salmone();
            Tonno t = new Tonno();
            Uomo u = new Uomo();

            {

                b.riepilogo();
                Console.WriteLine(b.siMuove());
                Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-");
                
                ca.riepilogo();
                Console.WriteLine(ca.siMuove());
                Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-");

                co.riepilogo();
                Console.WriteLine(co.siMuove());
                Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-");

                i.riepilogo();
                Console.WriteLine(i.siMuove());
                Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-");

                sa.riepilogo();
                Console.WriteLine(sa.siMuove());
                Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-");

                t.riepilogo();
                Console.WriteLine(t.siMuove());
                Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-");

                u.riepilogo();
                Console.WriteLine(u.siMuove());
                Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-");

            }

            Console.ReadLine();
        }
    }
}
