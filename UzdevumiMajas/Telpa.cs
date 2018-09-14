using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UzdevumiMajas
{
    public class Telpa
    {
        public int Numurs;
        public int Stavs;

        public string TelpasRaksturojums()
        {
            return "Telpas numurs: " + Numurs + "\n" + "Telpa atrodas " + Stavs + " stāvā" + "\n"; 
        }


    }

    
}
