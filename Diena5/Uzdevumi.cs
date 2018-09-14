using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena5
{
    public class Uzdevumi
    {
        public static void Uzdevums24()
        {
            // 1. definē jaunu masīvu
            // 2. aizpildi ar vērtībām [0, 10, 20, 30, 40, 50]
            // 3. paprasa lietotājam ievadīt skaitli
            // 4. ar ciklu pārbauda, vai skaitlis atrodas masīvā
            // 5. izvada pozīciju, kur skaitlis atrodas masīvā

            int[] skaitli = { 0, 10, 20, 30, 40, 50 };
            Console.Write("Ievadi skaitli");
            int skaitlis = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < skaitli.Length; i++)
            {
                if (skaitlis == skaitli[i])
                {
                    Console.Write("Skaitlis atrasts pozīcijā" + i);
                    return; //pārtrauc ciklu un turpmākās funkcijas pārbaudi
                }
            }

            Console.Write("Skaitlis nav atrasts!");
        }

        public static void Uzdevums25()
        {

            List<int> saraksts = new List<int>();
            while(true)
            {
                Console.Write("Ievadi skaitli vai 0, lai pārtrauktu: ");
                int skaitlis = Convert.ToInt32(Console.ReadLine());
                if(skaitlis == 0)
                {
                    break;  //pārtrauc while ciklu
                }
                saraksts.Add(skaitlis); //pievieno lietotāja ievadīto skaitli sarakstam līdz ievada skaitli
                
                for (int i = saraksts.Count - 1; i >= 0; i--) //count skaita, cik ir elementu
                {
                    Console.WriteLine(saraksts[i]);
                }
            }
        }

        public static void Uzdevums26()
        {
            // Izvade
            List<int> saraksts = new List<int>();
            while (true)
            {
                Console.Write("Ievadi skaitli vai 0, lai pārtrauktu: ");
                int skaitlis = Convert.ToInt32(Console.ReadLine());
                if (skaitlis == 0)
                {
                    break;  //pārtrauc while ciklu
                }
                saraksts.Add(skaitlis); //pievieno lietotāja ievadīto skaitli sarakstam līdz ievada skaitli
            }

            int skaits = 0;
            foreach(int skaitlis in saraksts)
            {
                if(skaitlis == 5)
                {
                    skaits++;
                }
                    
            }

            Console.Write("Atrasti " + skaits + " piecinieki");
        }

        public static void Uzdevums27()
        {
            List<int> saraksts = new List<int>();
            while (true)
            {
                Console.Write("Ievadi skaitli vai 0, lai pārtrauktu: ");
                int skaitlis = Convert.ToInt32(Console.ReadLine());
                if (skaitlis == 0)
                {
                    break;  //pārtrauc while ciklu
                }
                saraksts.Add(skaitlis); //pievieno lietotāja ievadīto skaitli sarakstam līdz ievada skaitli
            }

            // Izvade min un max

            //int min = saraksts.Min(); pieejams tikai listam
            //int max = saraksts.Max(); pieejams tikai listam

            int min = saraksts[0];
            int max = saraksts[0]; 
            foreach(int skaitlis in saraksts)
            {
               if(skaitlis<min)
               {
                    min = skaitlis;
               }
               else if(skaitlis > max)
               {
                    max = skaitlis;
               }
            }
            Console.WriteLine("Maksimālā vērtība ir " + max + " un minimālā vērtībā ir " + min);
        }

        public static void Uzdevums28()
        {
            List<Prece> saraksts = new List<Prece>();
            saraksts.Add(new Prece("Dators", 900));
            saraksts.Add(new Prece("Bikses", 50));
            saraksts.Add(new Prece("Auto", 10000));
            saraksts.Add(new Prece("Mobilais", 200));
            saraksts.Add(new Prece("TV", 550));
            saraksts.Add(new Prece("Koferis", 100));
            saraksts.Add(new Prece("Cimdi", 20));
            saraksts.Add(new Prece("Cepure", 10));


            //1.jāizvada viss katalogs - foreach ()
            Console.WriteLine("Pieejamās preces");
            foreach(Prece p in saraksts) //Preces vietā var likt arī "var", kas tiek lietots arī vairumā
            {
                Console.WriteLine(p.Nosaukums + " $" + p.Cena);
            }

            //2. lietotājs ievada preces nosaukums
            // ievadi pārtrauc ar '0' - if() un while() priekš lietotāja ievades
            double summa = 0;
            while (true)
            {
                Console.WriteLine("Ievadi preci vai 0 lai pārtrauktu: ");
                string nosaukums = Console.ReadLine();
                if(nosaukums == "0")
                {
                    break;
                }
                //2.1. jāatrod ievadītā prece katalogā (pēc nosaukuma) - foreach()
                // 2.2. paņem atrastās preces cenu un pieskaitāt kopsumā, kopsuma definēta kā nulle pašā sākumā
                foreach(var pr in saraksts)
                {
                    if(pr.Nosaukums.Equals(nosaukums, StringComparison.OrdinalIgnoreCase))
                    {
                        summa += pr.Cena;
                        break;
                    }
                }
            }

            //3. izvada kopsummu
            Console.Write("Summa = $" + summa);
            Console.ReadLine();


        }
    }
}
