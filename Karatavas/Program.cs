using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karatavas
{
    class Program
    {
        static void Main(string[] args)
        {

            Karatavas k = new Karatavas();
            k.StartNewGame();

            while(!k.VaiIrAtminets() && k.VaiIrMeginajumi())  //! nozīmē - kamēr nav atminēts
            {
                Console.WriteLine("Ievadi burtu: ");
                string ievade = Console.ReadLine();

                k.MinetBurtu(Convert.ToChar(ievade));
            }

            if(k.VaiIrMeginajumi())
            {
                Console.WriteLine("Vārds ir atminēts!");
            }
            else
            {
                Console.WriteLine("Beidzās mēģinājumi!");
                Console.WriteLine("Vārds bija: " + k.Vards());
            }

            Console.ReadLine();
            
            /*string[] words = { "VASARA", "SAULE", "PROGRAMMA", "RIGACODING", "AUGUSTS" };

            List<char> correctGuesses = new List<char>();
            List<char> incorrectGuesses = new List<char>();

            public Karatavas
              

            int position = new Random().Next(words.Length);
            string wordToGuess = words[position];
            int[] markers = new int[wordToGuess.Length];
            string missedChars = "";
            Console.WriteLine("Burtu skaits vārdā: " + wordToGuess.Length);

            char[] letters = words[position].ToCharArray();
            */

            /*int position = new Random().Next(words.Length);
            string wordToGuess = words[position];
            int[] markers = new int[wordToGuess.Length];
            Console.WriteLine("Burtu skaits vārdā: " + wordToGuess.Length);


            List<char> MinamaisVards = new List<char>();
            List<char> AtminetaisVards = new List<char>();

            for (int i = 0; i < wordToGuess.Length; i++)
            {

                Console.WriteLine("_");
            }
            char[] AtminetaisVards = words[position].ToCharArray();

            Console.WriteLine("Ievadi burtu!");
            int x = Console.Read();
            char ch = Convert.ToChar(x);
            string chStr = ch.ToString();

            if (wordToGuess.Contains(chStr))
            {
                for (int i = 0; i < wordToGuess.Length; i++)
                {

                }
            }*/



        }

    }
}
