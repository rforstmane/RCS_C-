using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena8
{
    public class Taisnsturis : Figura
    {
        public double Mala1;
        public double Mala2;

        public Taisnsturis(double mala1, double mala2) //šis ir konstruktors, jo nosaukums vienmēŗ sakrīt ar klasi
        {
            Mala1 = mala1;
            Mala2 = mala2;
        }

        public void Laukums()
        {
            double laukums = Mala1 * Mala2;
            Console.WriteLine("Laukums = " + laukums);
            
        }

        public double Perimetrs()
        {
            double perimetrs = 2 * (Mala1 + Mala2);

            return perimetrs; 
        }
    }
}
