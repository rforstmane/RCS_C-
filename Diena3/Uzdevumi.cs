using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena3
{
    public class Uzdevumi //public nozīmē, ka ir pieejams arī citām klasēm
    {
        public static void Uzdevums1()
        {
            Console.Write("Ievadi valsti: ");
            string valsts = Console.ReadLine().ToLower();
            valsts = char.ToUpper(valsts[0]) + valsts.Substring(1); //panāk, ka varu rakstīt valsti ar mazo burtu un programma atpazīs , 0 nozīmē, ka paņems pirmo simbolu

            switch (valsts)
            {
                case "Igaunija":
                    Console.Write("Galvaspilsēta ir Tallina");
                    break;
                case "Somija":
                    Console.Write("Galvaspilsēta ir Helsinki");
                    break;
                case "Ukraina":
                    Console.Write("Galvaspilsēta ir Kijeva");
                    break;
                case "Zviedrija":
                    Console.Write("Galvaspilsēta ir Stokholma");
                    break;
                case "Krievija":
                    Console.Write("Galvaspilsēta ir Maskava");
                    break;
                default:
                    Console.Write("Nezināma valsts");
                    break;

            }

        }

        public static void Uzdevums2()
        {
            //i=i+1
            //i++
            //i+=1

            //i=i+2
            //i+=2
            for (int i = 1; i <= 10; i++) // i=i+1 jeb = i++ i=1-sākās ar viens, i<=10-izpildas lidz 10, i++ - katru reizi pieskaitas par viens lidz nonak lidz desmit un tad paradas gara skaitlu rinda no viens lidz 10
            {
                Console.WriteLine(i);
            }
        }

        public static void Uzdevums3()
        {
            Console.Write("Ievadi dzimšanas gadu: ");
            int gads = Convert.ToInt32(Console.ReadLine());
            for (int i = gads; i<=2018; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void Uzdevums4()  //15.uzd
        {
            Console.Write("Ievadi skaitli: ");
            int N = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                int kvadrats = i * i;
                Console.WriteLine(kvadrats);
            }
        }

        public static void Uzdevums5() //16.uzd
        {
            Console.Write("Ievadi N: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int summa = 0; //mainigais, kas veic summesanu
            for (int i = 1; i<=N; i++)
            {
                Console.WriteLine(i);
                summa = summa + i; //summa += i;
            }
            Console.WriteLine("=>" + summa);
        }

        public static void Uzdevums6() //17uzd
        {
            Console.Write("Ievadi N: ");
            int cikluSkaits = Convert.ToInt32(Console.ReadLine());
            int summa = 0; //nozīmē to, ka sāksies no nulles
            for (int i = 0; i < cikluSkaits; i++) //i nozīmē indeks //int ir datu tips
            {
                Console.Write("Ievadi skatli: "); //uz konsoles tiek izdrukāts "ievadi skaitli"
                int temp = Convert.ToInt32(Console.ReadLine()); //temp ir mainīgais 
                summa = summa + temp;  
            }
            Console.WriteLine("=>" + summa);
            Console.WriteLine("=>" + (summa/cikluSkaits));
        }


        public static void Uzdevums7() //18uzd
        {
            Console.Write("Ievadi N: ");
            int rinda = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < rinda; i++)  // for (int rinda=1; rinda<=n; rinda++)
            {
                for (int k = 0; k < rinda; k++)
                {
                    Console.Write("?");
                }
                Console.WriteLine();
            }
            
        }

        public static void Uzdevums8()  //19uzd
        {
            Console.Write("Ievadi N: ");
            int trijsturis = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < trijsturis; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(j+1);
                }
                Console.WriteLine();
            }
        }

        public static void Uzdevums9() //20uzd
        {
            Console.Write("Ievadi N: ");
            int n = Convert.ToInt32(Console.ReadLine());

            /*
                  n=4
             *    r=1 a=3 n-r; z=1=2*r-1
             **   r=2 a=2 n-r  z=3
             ***  r=3 a=1 n-r  z=5
             **** r=4 a=0 n-r  z=7    
             */
            //apstrādā katru rindu
            for (int r = 1; r <= n; r++)
            {
                //attēlo tukšumus trijstūrim
                for (int a = 1; a <= n - r; a++)
                {
                    Console.Write(" ");
                }
                //attēlo zvaigznītes
                for (int z = 1; z <= 2 * r - 1; z++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int r = n - 1; r >= 1; r--)
            {
                //attēlo tukšumus trijstūrim
                for (int a = 1; a <= n - r; a++)
                {
                    Console.Write(" ");
                }
                //attēlo zvaigznītes
                for (int z = 1; z <= 2 * r - 1; z++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public static void WhilePiemers()
        {
            //lietotājs ievada skaitļus 
            //ievadi pārtrauc ar -1

            int sk = 0;
            int summa = 0;
            while(sk != -1)
            {
                Console.Write("Ievadi skaitli vai -1, lai pārtrauktu: ");
                sk = Convert.ToInt32(Console.ReadLine());

                if(sk != -1)
                {
                    summa = summa + sk;
                } 
            }
            Console.WriteLine("summa = " + summa);

            int summa2 = 0;
            while(true)
                //jeb for(;;)

            // = -> piešķiršana
            // == -> salīdzina, vai vērtība sakrīt
            // != -> salīdzina vai vērtības nesarīt
            {
                Console.Write("Ievadi skaitli vai -1, lai pārtrauktu: ");
                int sk2 = Convert.ToInt32(Console.ReadLine());
                if(sk2 == -1)
                {
                    break;
                }
                else
                {
                    summa2 = summa2 + sk2;
                }
            }
            Console.WriteLine("Summa2 = " + summa2);

        }
    }
}
