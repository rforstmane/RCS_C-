using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string izvadamsTeksts = Teksts();
            izvadamsTeksts = izvadamsTeksts + " " + Skaitlis();

            Console.WriteLine(izvadamsTeksts);
            BezRezultata();

            // Sagaidīt lietotāja ievadi
            Console.ReadLine();
            /*
             funkcija, ko nevajag izpildīt
            */
            
        }
        static void BezRezultata()
        {
            Console.WriteLine("Izsaukta funkcija BezRezultata");
        }
        static string Teksts()
        {
            return "Hello world!";
        }
        static int Skaitlis ()
        {
            return 5;
        }
    }
}
