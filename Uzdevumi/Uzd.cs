using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzdevumi
{
    public class Uzd
    {
        public void Name()
        {
            Console.WriteLine("Hello, ");
            Console.WriteLine("Renda Forstmane");
        }

        public void Sum()
        {
            Console.WriteLine("Write first number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write second number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int Summa = num1 + num2;
            Console.WriteLine("Skaitļu summa ir " + Summa);

        }

        public void Maina()
        {
            int num1, num2, temp;
            Console.Write("Ievadi pirmo skaitli: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ievadi otro skaitli: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine("Pēc ciparu maiņas: ");
            Console.WriteLine("Pirmais skaitlis ir: " + num1);
            Console.WriteLine("Otrais skaitlis ir: " + num2);

        }

        public void Reiz()
        {
            int num1, num2, num3;
            Console.Write("Ievadi pirmo skaitli: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ievadi otro skaitli: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ievadi trešo skaitli: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            int reizinajums = num1 * num2 * num3;

            Console.WriteLine("Rezultāts: " + num1 + "*" + num2 + "*" + num3 + "=" + reizinajums);
        }

        public void Uzd8()
        {
            int num, i;
            Console.Write("Ievadi skaitli: ");
            num = Convert.ToInt32(Console.ReadLine());
            for ( i = 0; i <= 10; i++)
            {
                Console.WriteLine(num + "*" + i + "=" + i * num);
            }

        }

        public void Uzd12()
        {
            int n, i, j;
            Console.Write("Ievadi skaitli: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(n);
                }
                Console.WriteLine();
            }
        }

        public void Uzd15()
        {
            Console.WriteLine("Ievadi vārdu");
            string vards = Console.ReadLine();
            StringBuilder jaunais = new StringBuilder(vards);
            Console.WriteLine("Izvēlies kuru vārda burtu izņemt: ");
            int burts = Convert.ToInt32(Console.ReadLine());
            jaunais.Remove(burts, 1);

            Console.WriteLine(jaunais);
        }

        public void Uzd26()
        {
            int Summa = 0;
            Console.Write("Ievadi skaitli: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)

            {
                Summa += i;
                
            }
            Console.WriteLine("Summa ir: " + Summa);
        }

        public void 
    }
}
