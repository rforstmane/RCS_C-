using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena4
{
    public class Auto
    {
        // Auto īpašība - krāsa
        public String Krasa;
        //Auto īpašība - max ātrums
        public int MaxAtrums;

        public void Braukt()
        {
            Console.WriteLine("Auto brauc! MaxAtrums = " + MaxAtrums);
        }

        public void KrasasNoteiksana()
        {
            Console.WriteLine("Auto ir " + Krasa + " krāsā!");
        }

        public static void BrauktStatic(int maxAtrums) //statiska funkcija nevar izpildīt klases funkcijas, nespēja nolasīt mainīgos, tāpēc int ir jāliek aiz brauktstatic
        {
            Console.WriteLine("Auto brauc! MaxAtrums = " + maxAtrums);
        }
    }


}
