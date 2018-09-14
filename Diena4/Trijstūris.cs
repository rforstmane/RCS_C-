using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena4
{
    public class Trijstūris
    {
        public int mala1;
        public int mala2;
        public int mala3;

        public void laukums()
        {

            double pusp = (double)(mala1 + mala2 + mala3) / 2;
            double sakne = Math.Sqrt((pusp * (pusp - mala1) * (pusp - mala2) * (pusp - mala3)));
            Console.WriteLine("Laukums ir: " + sakne);
        }
        public void perimetrs()
        {
            Console.WriteLine("Perimetrs ir: " + (mala3 + mala2 + mala1));
        }
    

    }
}
