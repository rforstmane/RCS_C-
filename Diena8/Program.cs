using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena8
{
    class Program
    {
        static void Main(string[] args)
        {

            Aplis aplis = new Aplis(6);
            // ja nav konstruktors: aplis.Radiuss = 5;
            Kvadrats kvadrats = new Kvadrats(10);

            Taisnsturis taisnsturis = new Taisnsturis(5, 10);

            VeiktAprekinu("Aplis: ", aplis);
            VeiktAprekinu("Kvadrats: ", kvadrats);
            VeiktAprekinu("Taisnstūris: ", taisnsturis);

            Console.ReadLine();
        }

        static void VeiktAprekinu(string nosaukums, Figura figura)
        {
            Console.WriteLine(nosaukums);
            // izvada rezultātu
            figura.Laukums();

            // saņem aprēķināto rezultātu un tad izvada, jo metode atgriež double
            double perimetrs = figura.Perimetrs();
            Console.WriteLine("Perimetrs = " + perimetrs);

            // lai noteiktu kāda klase bija
            /*if (figura is Kvadrats)
            {
                Console.WriteLine("Tika aprēķināti kvadrāta dati");
            }*/
        }

        static void Piemers(string[] args)
        {
            Auto auto = new Auto();
            Lidmasina lidmasina = new Lidmasina();

            ParvietotAuto(auto);
            ParvietotLidmasinu(lidmasina);

            Parvietot(auto);
            Parvietot(lidmasina);

            Console.ReadLine();
        }

        static void Parvietot(Transportlidzeklis tr)
        {
            tr.Parvietoties();
        }

        static void ParvietotAuto(Auto auto)
        {
            auto.Parvietoties();
        }

        static void ParvietotLidmasinu(Lidmasina lidmasina)
        {
            lidmasina.Parvietoties();
        }


    }
}
