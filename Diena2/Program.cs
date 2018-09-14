using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Piemers();
            Vecums();
            //DiviSkaitli();
            //Menesi();
            //Aprekini();
            //kalkulators();
            //gradi();

            Console.ReadLine();
        }

        static int AtgriezSkaitli()
        {
            return 5;
        }

       /* static void gradi()
        {
            Console.Write("Ievadi grādus: ");
            string mervieniba1 = "F";
            string mervieniba2 = "K";

            if(mervieniba1 !="F" && mervieniba1 != "C" && mervieniba1 != "K") || (mervieniba2 != "F" || mervieniba2 != "C" || mervieniba2 != "K") 
            {
                Console.Write("Kļūda ievadē!");
            }
            else if (mervieniba1 == mervieniba2)
            {
                Console.Write("Grādi = " + gradi + mervieniba1);
            }
            else if(mervieniba1 == "F")
            {
                if(mervieniba2 == "C")
                {
                    //F->
                }
                else if (mervieniba2 == "K")
                {

                }
            }
        }*/


        static void Vecums()
        {
            Console.Write("Ievadi savu vecumu: ");
            int vecums = Convert.ToInt32(Console.ReadLine());
            if (vecums >= 18)
            {
                Console.Write("Pilngadigs");
            }

            else
            {
                Console.Write("Nepilngadigs");
            }
        }

        static void DiviSkaitli()
        {
            Console.Write("Ievadi pirmo skaitli: ");
            int skaitlis1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ievadi otro skaitli: ");
            int skaitlis2 = Convert.ToInt32(Console.ReadLine());
            if (skaitlis1 == skaitlis2)
            {
                Console.Write("Skaitli ir vienādi");
            }
            else
            {
                Console.Write("Skaitli nav vienādi");
            }
        }

        static void Menesi()
        {
            Console.Write("Ievadi mēneša nosaukumu: ");
            string menesis = Console.ReadLine().ToLower(); //tolower parvers uz mazajiem burtiem, toupper uz lielajiem

            if (menesis == "feb")
            {
                Console.Write("28 dienas");
            }
            else if (menesis == "apr"
                || menesis == "jun"
                || menesis == "sep"
                || menesis == "nov")
            {
                Console.Write("30 dienas");
            }
            else if (menesis == "jan"
                || menesis == "mar"
                || menesis == "mai" 
                || menesis == "jul"
                || menesis == "aug"
                || menesis == "dec"
                 )
            {
                Console.Write("Mēnesī ir 31.diena");
            }
            else
            {
                Console.Write("Nezināms mēnesis");
            }
            
        }

        static void Aprekini ()
        {
            Console.Write("Ievadi attālumu (metros): ");
            decimal metri = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Ievadi stundas: ");
            int stundas = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ievadi minūtes: ");
            int minutes = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ievadi sekundes: ");
            int sekundes = Convert.ToInt32(Console.ReadLine());

            int laiks = stundas * 60 * 60 + minutes * 60 + sekundes;
            Console.WriteLine("Kopējais laiks ir :" + laiks);

            decimal atrums = metri / laiks;
            Console.WriteLine("Ātrums m/s ir: " + atrums);

            decimal atrumsKmh = (metri / 1000) / (laiks / (60 * 60));
            Console.WriteLine("Ātrums km/h ir: " + atrumsKmh);

            decimal km = metri / 1000;
            Console.WriteLine("Attālums ir: " + km);

            decimal judzes = km * (decimal)0.621371; //vai arī pie skaitļa 'm', kas nozīme, ka decimal skaitlis
            Console.WriteLine("Jūdzes ir: " + judzes);

        }

        static void kalkulators()
        {
            Console.Write("Ievadi pirmo skaitli: ");
            int skaitlis1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ievadi darbību: ");
            string darbiba = Console.ReadLine();

            Console.Write("Ievadi otro skaitli: ");
            int skaitlis2 = Convert.ToInt32(Console.ReadLine());

            if (darbiba=="+")
            {
                int summa = skaitlis1 + skaitlis2;
                Console.WriteLine("Summa =" + summa);      
            }

            else if (darbiba == "-")
            {
                int starpiba = skaitlis1 - skaitlis2;
                Console.WriteLine("starpiba = " + starpiba);
            }

            else if (darbiba == "*")
            {
                int reiz = skaitlis1 * skaitlis2;
                Console.WriteLine("reizinājums = " + reiz);
            }

            else if (darbiba == "/")
            {
                decimal dal = (decimal)skaitlis1 / skaitlis2;
                Console.WriteLine("dalijums: " +dal);
            }
            else
            {
                Console.Write("Nezināma darbība");
            }
        }

        static void gradi()
        {

        }


        
        static void Piemers()
        {
            int skaitlis = AtgriezSkaitli();

            if (skaitlis > 10) //var būt tikai if
            {
                Console.Write("Skaitlis ir lielaks par 10");
            }
            else if (skaitlis == 10)
            {
                Console.Write("Skaitlis ir vienads ar 10");
            }
            else if (skaitlis == 9)
            {
                Console.Write("skaitlis ir vienads ar 9");
            }
            else //šis ir tikai pašās beigās
            {
                Console.Write("Skaitlis ir mazaks par 10");

            }
        }
    }
}
