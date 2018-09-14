using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UzdevumiMajas
{
    public class MacibuPrieksmets
    {
        public string Nosaukums;
        public Telpa KlasesApraksts;
        public Skolotajs Pasniedzejs;

        public string Prieksmets()
        {
            return "Mācību priekšmets" + Nosaukums + "\n" +  " " + KlasesApraksts.TelpasRaksturojums() + "\n" + " " + Pasniedzejs.SkolotajaRaksturojums() + "\n";
        }
    }
}
