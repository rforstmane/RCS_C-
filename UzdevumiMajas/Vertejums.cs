using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UzdevumiMajas
{
    public class Vertejums
    {
        public MacibuPrieksmets Prieksmeti;
        public Skolens Skolens1;
        public int Atzime;

        public void info()
        {
            Console.WriteLine(Prieksmeti.Prieksmets() +  " " + Skolens1.SkolenaRaksturojums() + " " + "Skolēna atzīme: " + Atzime);
        }
    }
}
