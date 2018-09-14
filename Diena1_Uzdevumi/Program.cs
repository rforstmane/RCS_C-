using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena1_Uzdevumi
{
    class Program
    {
        static void Main(string[] args)
        {
            //VardaIzvade();
            //SkaitluSumma(); 
            //GraduMaina();
            //SkaitluReizinajums();
            SummaN();
            //formulas();
            //diviSkaitli();
        }

        static void SummaN()
        {
            int i, sum = 0, n;
            Console.Write("Ievadi skaitli: ");
            n = int.Parse(Console.ReadLine());
            for (i = 0; i <= n; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine("Skaitlu summa ir : " + sum);
            Console.ReadLine();        
        }

        static void formulas()
        {
            Console.Write("Ievadi skaitli: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int summa = n*(n+ 1) / 2;

            Console.WriteLine("Summa ir: " + summa);
            Console.ReadLine();
        }

        static void diviSkaitli ()
        {
            Console.WriteLine("Ievadi pirmo skaitli: ");
            int n1= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ievadi otro skaitli: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            int summa = (n2 - n1) * ((n2 - n1) + 1) / 2;

            Console.WriteLine("Summa ir: " + summa);
            Console.ReadLine();

        }

        static void GraduMaina()
        {
            //ievadi gradus
            Console.Write("Ievadi grādus pēc Celsija: ");
            int celsijs = Convert.ToInt32(Console.ReadLine());

            int kelvini = celsijs + 273;
            float farenheiti = celsijs * 1.8f + 32;

            Console.WriteLine("Kelvini = " + kelvini); 
            Console.WriteLine("Fārenheiti = " + farenheiti);
            Console.ReadLine();
        }
       
        static void SkaitluReizinajums()
        {
            Console.Write("Ievadi pirmo skaitli: ");
            int skaitlis1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ievadi otro skaitli: ");
            int skaitlis2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ievadi trešo skaitli: ");
            int skaitlis3 = Convert.ToInt32(Console.ReadLine());

            int reizinajums = skaitlis1 * skaitlis2 * skaitlis3;
            Console.Write("Reizinajums ir " + reizinajums);

            Console.ReadLine();

        }
        //kā saīsināt kodu
        static int SkaitlaIevade(string teksts)
        {
            Console.Write(teksts);
            return Convert.ToInt32(Console.ReadLine());
            //int skaitlis1 = SkaitlaIevade("Ievadi 1.skaitli: ");
        }

        static void SkaitluSumma()
        {
            //paprasa ievadīt 1.skaitli
            Console.Write("Ievadi pirmo skaitli: ");
            int skaitlis1 = Convert.ToInt32(Console.ReadLine());

            //paprasa ievadīt 2.skaitli
            Console.Write("Ievadi otro skaitli: ");
            int skaitlis2 = Convert.ToInt32(Console.ReadLine());

            //izvada skaitļu summu      
            int summa = skaitlis1 + skaitlis2;
            Console.WriteLine("Summa ir" +" " + summa);

            int starpiba = skaitlis1 - skaitlis2;
            Console.WriteLine("Starpība ir" +" " + starpiba);

            int reizinajums = skaitlis1 * skaitlis2;
            Console.WriteLine("Reizinājums ir " +" " + reizinajums);

            if (skaitlis2 == 0)
            {
                Console.WriteLine("Dalit ar nulli nedrikst");
            } else
            {
                float dalijums = (float)skaitlis1 / skaitlis2;
                Console.WriteLine("Dalījums ir " + " " + dalijums);

                int atlikums = skaitlis1 % skaitlis2;
                Console.WriteLine("Atlikums ir " + atlikums);
            }

            //lai logs paliek atvērts
            Console.ReadLine();
        }

        static void VardaIzvade()
        {
            // teksta izvade
            Console.Write("Ievadi vārdu: ");
            // teksta ievade
            string vards = Console.ReadLine();
       
            //uzvarda ievade
            Console.Write("Ievadi uzvārdu: ");
            string uzvards = Console.ReadLine();

            //vecuma ievade
            Console.Write("Ievadi vecumu:");
            int vecums = Convert.ToInt32(Console.ReadLine()); //toint32 lai paraditos skaitlis

            // string vecumsString = Console.ReadLine();
            // int vecums = Convert.ToInt32(vecumsStrings);

            //teksta izvade            
            Console.Write("Tevi sauc " + vards + " " + uzvards + " ");
            Console.Write("un tev ir"+ " " + vecums + " " + "gadi");

            //lai console logs paliek atvērts
            Console.ReadLine();
        }
    }
}
