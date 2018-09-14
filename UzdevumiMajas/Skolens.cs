using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UzdevumiMajas
{
    public class Skolens
    {
        public string Vards;
        public string Uzvards;
        public string Epasts;
        public int Dzimsana;
        public Klase Klase1;

        public string SkolenaRaksturojums()
        {
            return "Vārds: " + Vards + "\n" + " " + "Uzvārds: " + Uzvards + "\n" + " " + "Epasts: " + Epasts + "\n" + " " + "Dzimšanas gads: " + Dzimsana + "\n" + " " + Klase1.KlasesRaksturojums();
        }
    }
}
