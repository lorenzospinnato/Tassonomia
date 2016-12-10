using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia
{
    class Tonno:Pesce
    {
        public Tonno():base("Tonno","Pesce","Mare",0,"")
        {

        }
        public void setMantoSquamoso()
        {
            manto = "Squame";
        }
        public override string siMuove()
        {
            return "Nuoto";
        }
    }
}
