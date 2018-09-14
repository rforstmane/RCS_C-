using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UzdevumiMajas
{
    public class Skolotajs
    {
        public string Vards;
        public string Uzvards;
        public string Epasts;

        public string SkolotajaRaksturojums()
        {
            return "Skolotāja vārds: " + Vards + "\n" + "Skolotāja uzvārds: " + Uzvards + "\n" + "Skolotāja epasts: " + Epasts + "\n";
        }
    }
}
