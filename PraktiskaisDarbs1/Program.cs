using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraktiskaisDarbs1
{
    class Program
    {
        static void Main(string[] args)
        {
            DilstosaVirkne();
            //Modinatajs();
            //Modinatajs2();
            //AtrumaParkapejs();
            //Neveiksmigais();
            //Problema();
            //Karatavas();
        }

        static void DilstosaVirkne()
        {
            Console.WriteLine("Ievadi N");
            int N = Convert.ToInt32(Console.ReadLine());
            for (int i = N; i >= 1; i--)
            {
                Console.Write("#");
            }
            Console.ReadLine();
        }

        static void Modinatajs()
        {
            Console.WriteLine("Ievadi nedēļas dienu: ");
            string diena = Console.ReadLine();

            Console.WriteLine("Vai esi atvaļinājumā? ");
            string atvalis = Console.ReadLine();


            if (((diena == "P")|| (diena == "O")||(diena == "T")||(diena == "C")||(diena == "Pk")) && (atvalis == "J")) 
            {
                Console.WriteLine("Modinātājs => 10:00");
            }

            else if (((diena == "P") || (diena == "O") || (diena == "T") || (diena == "C") || (diena == "Pk")) &&(atvalis == "N"))
            {
                Console.WriteLine("Modinātājs => 7:00");
            }

            else if (((diena == "Se")||(diena =="Sv")) && (atvalis =="N"))
            {
                Console.WriteLine("Modinātājs => 10:00");
            }

            else if (((diena == "Se") || (diena == "Sv")) && (atvalis == "J"))
            {
                Console.WriteLine("Modinātājs => Off");
            }

            else
            {
                Console.WriteLine("Ārpus uztveršanas zonas");
            }

            Console.ReadLine();

        }

        static void Modinatajs2()
        {
            Console.WriteLine("Ievadi nedēļas dienu: ");
            string diena = Console.ReadLine();


            Console.WriteLine("Vai esi atvaļinājumā? ");
            string atvalis = Console.ReadLine();

            switch(diena) //? nozīmē "tad", bet " : " nozīmē "citādi"
            {
                case "P":
                case "O":
                case "T":
                case "C":
                case "Pk":
                    if(atvalis == "J")
                    {
                        Console.Write("10:00");
                    }
                    else
                    {
                        Console.Write("7:00");
                    }
                    //console.Write(atvalis == "J" ? "10:00" : "Off";
                    break;
                case "Se":
                case "Sv":
                    if (atvalis == "N")
                    {
                        Console.Write("10:00");
                    }
                    else Console.Write("Off");
                    break;

            }

            Console.ReadLine();
        }
            

        static void AtrumaParkapejs()
        {
            Console.WriteLine("Vai tev ir dzimšanas diena? ");
            string dz = Console.ReadLine();

            Console.WriteLine("Ievadi ātrumu: ");
            int atrums = Convert.ToInt32(Console.ReadLine());

            if(dz == "J")
            {
                atrums = atrums - 5;
            }

            if (atrums <=60)
            {
                Console.WriteLine("Nav soda");
            }

            else if (atrums <= 80)
            {
                Console.WriteLine("Neliels sods");
            }

            else if (atrums > 80 )
            {
                Console.WriteLine("Liels sods");
            }

            Console.ReadLine();


        }

        

        static void Neveiksmigais()
        {

            List<int> saraksts = new List<int>();
            int summa = 0;
            while (true)
            {
                Console.WriteLine("Ievadi skaitli vai 13, lai pārtrauktu");
                int skaitlis = Convert.ToInt32(Console.ReadLine());

                if (skaitlis == 13)
                {
                    break;
                }
                saraksts.Add(skaitlis);
            }

            foreach (int skaitlis in saraksts)
            {
                summa = summa + skaitlis;
                
            }
            Console.WriteLine("Summa ir: " + summa);
            Console.ReadLine();
        }

        static void Problema()
        {
            Console.WriteLine("Ievadi sākuma skaitli");
            int sk1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ievadi beigu skaitli");
            int sk2 = Convert.ToInt32(Console.ReadLine());

            for ( int i=sk1; i<=sk2; i++)
            {

                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }

                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz ");
                }

                else if ( i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }

                else
                {
                    Console.WriteLine(i);
                }

            }

            Console.ReadLine();
        }

        static void Karatavas()
        {
            string [] words = { "vasara", "saule", "programmesana", "karstums", "karatavas" };
            int position = new Random().Next(words.Length - 1); //dos random skaitli
            string wordToGuess = words[position]; // vārds, kurš tiks izvēlēts 

            int[] markers = new int[wordToGuess.Length]; // markers masīvs saglabā, kurš burts tika uzminēts

            Console.WriteLine("Burtu skaits vārdā: " + wordToGuess.Length);
            
            Console.ReadLine();
        }


    }


}
