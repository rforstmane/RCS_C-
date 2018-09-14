using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UzdevumiMajas
{
    public class Klase
    {
        public string Nosaukums;
        public int SkolenuSkaits;
        public Telpa KlasesApraksts; 

        public string KlasesRaksturojums()
        {
            return "Klases nosaukums " + Nosaukums + "\n"  + "Skolēnu skaits " + SkolenuSkaits + "\n" + ", " + KlasesApraksts.TelpasRaksturojums() + "\n";
        }
       
    }
}
