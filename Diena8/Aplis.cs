using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena8
{
    public class Aplis : Figura
    {
        public double Radiuss;
        
        public Aplis (double radiuss)
        {
            this.Radiuss = radiuss; 
        }

        //void -> neatgriež rezultātu, tikai izvada
        public void Laukums()
        {
            double laukums = Math.PI * Radiuss * Radiuss;
            Console.WriteLine("Laukums = " + laukums);
        }

        //double -> metode atgriež aprēķināto rezultātu, ko var izmantot tālāk programmā
        public double Perimetrs()
        {
            double perimetrs = 2 * Math.PI * Radiuss;

            return perimetrs;
        }
        


    }
}
