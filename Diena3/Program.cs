using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena3
{
    class Program
    {
        static void Main(string[] args)
        {
            Uzdevumi.WhilePiemers();

            Console.ReadLine();
        }
        static void Piemers()
        {
            string mervieniba = "C";
            switch(mervieniba) //switch ir atslegvards 
            {
                case "C": //case vērtibas, kas interese
                    Console.Write("Ievadīti celsiji");
                    break; //beidzas bloks
                case "F":
                    Console.Write("Ievadīti Farenheiti");
                    break;
                case "K":
                    Console.Write("Ievadīti kelvini");
                    break;
                case "Z":
                case "A":
                    Console.Write("Ievadits A vai Z");
                    break;
                default: //nostrada, ja neviens no caseim nestrada
                    Console.Write("Nezināma mērvienība");
                    break;
            }
        }
    }
}
