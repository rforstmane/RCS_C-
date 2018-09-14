using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena4
{
    class Program
    {

        static void Main(string[] args)
        {
            Trijstūris trijsturis1 = new Trijstūris();
            trijsturis1.mala1 = 5;
            trijsturis1.mala2 = 4;
            trijsturis1.mala3 = 7;
            trijsturis1.laukums();
            trijsturis1.perimetrs();

            Console.ReadLine();
        }

        static void aplis(string[] args)
        {
            Aplis aplis1 = new Aplis();
            aplis1.radiuss = 4;
            aplis1.laukums();
            aplis1.perimetrs();

            Console.ReadLine();
        }

        static void kvadrats(string[] args)
        {
            kvadrats a = new kvadrats();
            a.garums = 4;
            a.krasa = "zaļa";
            a.laukums();
            a.perimetrs();
            a.krasa1();

           


            Console.ReadLine();

        }

        static void taisnsturis(string[] args)
        {
            taisnsturis taisnsturis1 = new taisnsturis();
            taisnsturis1.mala1 = 3;
            taisnsturis1.mala2 = 4;
            taisnsturis1.laukums();
            taisnsturis1.perimetrs();

            Console.ReadLine();

        }

        static void Piemers (string[] args)
        {
            Auto auto1 = new Auto(); //jauns mainīgais, kurš atbilst iepriekšējam auto
            //auto1 ir objekts
            //auto ir klase
            auto1.MaxAtrums = 200;  
            auto1.Krasa = "melna";
            auto1.Braukt();
            auto1.KrasasNoteiksana();

            //auto1 ir objekts
            //auto ir klase
            Auto auto2 = new Auto();
            auto1.MaxAtrums = 150;
            auto1.Krasa = "sarkanā";
            auto1.Braukt();
            auto1.KrasasNoteiksana();


            Console.ReadLine();
        }
    }
}
