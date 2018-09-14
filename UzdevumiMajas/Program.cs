using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UzdevumiMajas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uzdevums1();
            //Uzdevums2();
            //Uzdevums3();
            //Uzdevums4();
            //Uzdevums5();
            //Uzdevums6();
            //Uzdevums7();
            //Uzdevums8();
            //Uzdevums10();
            //Uzdevums11();
            //Uzdevums12();
            //Uzdevums20();
            //Uzdevums13();
            //Uzdevums14();
            //Uzdevums15();
            //Uzdevums16();
            //Uzdevums17();
            //Uzdevums18();
            //Uzdevums19();
            //Uzdevums201();
            Uzdevums22();

        }

        static void Uzdevums1()
        {
            Console.WriteLine("Kāds ir tavs vārds?");
            string vards = Console.ReadLine();
            Console.WriteLine("Kāds ir tavs uzvārds? ");
            string uzvards = Console.ReadLine();
            Console.Write("Tevi sauc: " + vards + " " + uzvards);
            Console.ReadLine();
        }

        static void Uzdevums2()
        {
            Console.WriteLine("Ievadi pirmo skaitli: ");
            int sk1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ievadi otro skaitli: ");
            int sk2 = Convert.ToInt32(Console.ReadLine());
            int summa = sk1 + sk2;
            Console.WriteLine("Summa ir: " + summa);
            Console.ReadLine();
        }

        static void Uzdevums3()
        {
            Console.WriteLine("Ievadi pirmo skaitli: ");
            int sk1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ievadi otro skaitli: ");
            int sk2 = Convert.ToInt32(Console.ReadLine());

            int summa = sk1 + sk2;
            Console.WriteLine("Summa ir: " + summa);

            int starpiba = sk1 - sk2;
            Console.WriteLine("Starpība ir: " + starpiba);

            int reiz = sk1 * sk2;
            Console.WriteLine("Reizinājums ir: " + reiz);

            if (sk2 == 0)
            {
                Console.WriteLine("Ar nulli dalīt nevar");
            }
            else
            {
                float dal = (float)sk1 / sk2;
                Console.WriteLine("Dalījums ir: " + dal);

                int atlik = sk1 % sk2;
                Console.WriteLine("Atlikums ir: " + atlik);

            }
            Console.ReadLine();
        }

        static void Uzdevums4()
        {
            Console.WriteLine("Ievadi pirmo skaitli: ");
            int sk1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ievadi otro skaitli: ");
            int sk2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ievadi trešo skaitli: ");
            int sk3 = Convert.ToInt32(Console.ReadLine());

            int reiz = sk1 * sk2 * sk3;
            Console.WriteLine("Skaitļu reizinaājums ir: " + reiz);

            Console.ReadLine();
        }

        static void Uzdevums5()
        {
            Console.WriteLine(" Ievadi grādus pēc Celsija: ");
            int celsijs = Convert.ToInt32(Console.ReadLine());

            int K = celsijs + 273;
            Console.WriteLine("Kelvini ir: " + K);

            double F = (celsijs * 1.8) + 32;
            Console.WriteLine("Fārenheiti ir: " + F);

            Console.ReadLine();
        }

        static void Uzdevums6()
        {
            Console.WriteLine("Ievadi savu vecumu: ");
            int gadi = Convert.ToInt32(Console.ReadLine());

            if (gadi >= 18)
            {
                Console.WriteLine("Tu esi pilngadīgs");
            }
            else
            {
                Console.WriteLine("Tu esi nepilngadīgs");
            }
            Console.ReadLine();
        }

        static void Uzdevums7()
        {
            Console.WriteLine("Ievadi pirmo skaitli: ");
            int sk1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ievadi otro skaitli: ");
            int sk2 = Convert.ToInt32(Console.ReadLine());

            if (sk1 == sk2)
            {
                Console.WriteLine("Skaitļi ir vienādi");
            }
            else
            {
                Console.WriteLine("Skaitļi nav vienādi");
            }
            Console.ReadLine();
        }

        static void Uzdevums8()
        {
            Console.WriteLine("Ievadi mēneša nosaukumu: ");
            string men = Console.ReadLine().ToUpper();

            if ((men == "JAN") || (men == "MAR") || (men == "MAI") || (men == " JUL") || (men == "AUG") || (men == " OKT") || (men == " DEC"))
            {
                Console.WriteLine("Mēnesī ir 31 diena");
            }
            else if ((men == "APR") || (men == "JUN") || (men == "SEP") || (men == "NOV"))
            {
                Console.WriteLine("Mēnesī ir 30 dienas");
            }
            else if (men == "FEB")
            {
                Console.WriteLine("Mēnesī ir 28 vai 29 dienas");
            }
            else
            {
                Console.WriteLine("Nezināms mēnesis");
            }
            Console.ReadLine();
        }

        static void Uzdevums10()
        {
            Console.WriteLine("Ievadi attālumu metros: ");
            decimal metri = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ievadi stundu laiku: ");
            int h = Convert.ToInt32(Console.ReadLine().ToUpper());

            Console.WriteLine("Ievadi minūšu laiku: ");
            int min = Convert.ToInt32(Console.ReadLine().ToUpper());

            Console.WriteLine("Ievadi sekunžu laiku: ");
            int sec = Convert.ToInt32(Console.ReadLine().ToUpper());

            int kopejais = h * 60 * 60 + min * 60 + sec;
            Console.WriteLine("Kopējais laikes ir : " + kopejais + "sekundes");

            decimal atrums = metri / kopejais;
            Console.WriteLine("Ātrums ir: " + atrums + "m/s");

            decimal atrums2 = (metri / 1000) / (kopejais / (60 * 60));
            Console.WriteLine("Ātrums ir: " + atrums2 + "km/h");

            decimal kilometri = metri / 1000;
            Console.WriteLine("Attālums ir: " + kilometri + "km");

            decimal judzes = kilometri * (decimal)0.621371;
            Console.WriteLine("Jūdzes ir: " + judzes);

            Console.ReadLine();
        }

        static void Uzdevums11()
        {
            Console.WriteLine("Ievadi pirmo skaitli");
            int sk1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ievadi darbību");
            string darbiba = Console.ReadLine();

            Console.WriteLine("Ievadi otro skaitli");
            int sk2 = Convert.ToInt32(Console.ReadLine());


            if (darbiba == "+")
            {
                int summa = sk1 + sk2;
                Console.WriteLine("Summa ir: " + summa);
            }

            else if (darbiba == "-")
            {
                int starpiba = sk1 - sk2;
                Console.WriteLine("Starpība ir: " + starpiba);
            }

            else if (darbiba == "*")
            {
                int reiz = sk1 * sk2;
                Console.WriteLine("Reizinājums ir: " + reiz);
            }

            else if (darbiba == "/")
            {
                Decimal dal = sk1 / (decimal)sk2;
                Console.WriteLine("Dalījums ir: " + dal);
            }

            else
            {
                Console.WriteLine("Nezināma darbība");
            }
            Console.ReadLine();

        }

        /*static void Uzdevums12()
        {
            Console.WriteLine("Ievadi grādus");
        }*/

        static void Uzdevums20()
        {
            Console.WriteLine("Ievadi valsti");
            string valsts = Console.ReadLine();

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
            Console.ReadLine();
        }

        public static void Uzdevums13()
        {
            for (int i = 1; i <= 10; i++) // i=i+1 jeb = i++ i=1-sākās ar viens, i<=10-izpildas lidz 10, i++ - katru reizi pieskaitas par viens lidz nonak lidz desmit un tad paradas gara skaitlu rinda no viens lidz 10
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }

        public static void Uzdevums14()
        {
            Console.WriteLine("Ievadi dzimšanas gadu");
            int gads = Convert.ToInt32(Console.ReadLine());
            for (int i = gads; i <= 2018; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }

        public static void Uzdevums15()
        {
            Console.WriteLine("Ievadi N");
            int N = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= N; i++ )
            {
                int kvadr = i * i;
                Console.WriteLine(i + "=> " + kvadr);
            }
            Console.ReadLine();
        }

        public static void Uzdevums16()
        {
            Console.Write("Ievadi N ");
            int N = Convert.ToInt32(Console.ReadLine());
            int summa = 0;
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine(i);
                summa = summa + i;
            }
            Console.WriteLine("Summa ir: " + summa);
            Console.ReadLine();
        }

        public static void Uzdevums17()
        {
            Console.Write("Ievadi N ");
            int cikluskaits = Convert.ToInt32(Console.ReadLine());
            int summa = 0;
            for(int i = 1; i <= cikluskaits; i++)
            {
                Console.Write("Ievadi skatli: "); 
                int temp = Convert.ToInt32(Console.ReadLine()); 
                summa = summa + temp;
            }
            Console.WriteLine("=>" + summa);
            Console.WriteLine("=>" + (summa / cikluskaits));
            Console.ReadLine();
        }

        public static void Uzdevums18()
        {
            Console.Write("Ievadi N: ");
            int rinda = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < rinda; i++) 
            {
                for (int k = 0; k < rinda; k++)
                {
                    Console.Write("?");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        public static void Uzdevums19() 
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
            Console.ReadLine();
        }

        public static void Uzdevums201()
        {
            Console.Write("Ievadi N: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int r = 1; r <= n; r++)
            {
                for (int a = 1; a <= n - r; a++)
                {
                    Console.Write(" ");
                }

                for (int z = 1; z <= 2 * r - 1; z++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int r = n - 1; r >= 1; r--)
            {
                for (int a = 1; a <= n - r; a++)
                {
                    Console.Write(" ");
                }

                for (int z = 1; z <= 2 * r - 1; z++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        
        }

        public static void Uzdevums22()
        {
            Vertejums vert = new Vertejums();
            vert.Atzime = 10;
            vert.Prieksmeti = new MacibuPrieksmets();
            vert.Prieksmeti.Nosaukums = "Matemātika";
            vert.Prieksmeti.KlasesApraksts = new Telpa();
            vert.Prieksmeti.KlasesApraksts.Numurs = 10;
            vert.Prieksmeti.KlasesApraksts.Stavs = 3;
            vert.Prieksmeti.Pasniedzejs = new Skolotajs();
            vert.Prieksmeti.Pasniedzejs.Vards = "Kristaps";
            vert.Prieksmeti.Pasniedzejs.Uzvards = "Codings";
            vert.Prieksmeti.Pasniedzejs.Epasts = "KristapsCoding@coding.com";
            vert.Skolens1 = new Skolens();
            vert.Skolens1.Vards = "Krists";
            vert.Skolens1.Uzvards = "Egle";
            vert.Skolens1.Epasts = "krists.egle@gmail.com";
            vert.Skolens1.Dzimsana = 1999;
            vert.Skolens1.Klase1 = new Klase();
            vert.Skolens1.Klase1.Nosaukums = "Informātikas klase";
            vert.Skolens1.Klase1.SkolenuSkaits = 20;
            vert.Skolens1.Klase1.KlasesApraksts = new Telpa();

            vert.info();

            Console.ReadLine();



        }




    }
}
