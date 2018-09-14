using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena4
{
    public class Aplis
    {
        public int radiuss;

        public void laukums()
        {
            double pi = Math.PI;
            Console.WriteLine("Laukums ir: " + pi * radiuss*radiuss);
        }
        public void perimetrs()
        {
            double pi = Math.PI;
            Console.WriteLine("Perimetrs ir: " + 2*pi*radiuss);
        }
    }
}
