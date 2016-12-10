﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia
{
    class Ippopotamo:Mammifero_Fluviale, Quadrupede
    {

        public Ippopotamo():base("Ippopotamo","Mammifero Fluviale","Fiume",0,"Pelle")
        {

        }
        public void setZampe()
        {
            numerozampe = 4;
        }
        public override string siMuove()
        {
            return "Nuoto/Cammino";
        }
    }
}
