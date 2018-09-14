using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena4
{
    public class taisnsturis
    {
        public int mala1;
        public int mala2;

        public void laukums()
        {
            Console.WriteLine("Laukums ir: " + mala1 * mala2);
        }
        public void perimetrs()
        {
            Console.WriteLine("Perimetrs ir: " + (mala1+mala2)*2);
        }
    }
}
