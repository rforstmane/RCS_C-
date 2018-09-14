using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DzerienuAutomats
{
    public class Automats
    {
        public double Summa;

        public Automats()
        {
            Summa = 0;
        }

        public void Iemaksat(double summa)
        {
            Summa += summa; //mazā summa ir tas, kas tiks iemaksāts
        }
        
        public void PirktDzerienu()
        {
            if(Summa < 0.8)
            {
                Console.WriteLine("Nepietiek līdzekļu!");
            }
            else
            {
                Summa -= 0.8;
                Console.WriteLine("Atlikums: " + Summa);
                
               
              
            }
        }

        public void IzdotAtlikumu()
        {
            Console.WriteLine("Tu saņēmi: " + Summa);
            Summa = 0;
        }

        public void Darbibas()
        {
            Console.WriteLine("Izvēlies darbību: ");
            Console.WriteLine("- Iemaksāt (i)");
            Console.WriteLine("- Pirkt (p)");
            Console.WriteLine("- Izdot atlikumu (a)");
            Console.WriteLine("- Beigt darbu (b)");

            while(true)
            {
                Console.Write("Darbība: ");
                string darbiba = Console.ReadLine().ToLower();
                if(darbiba =="b")
                {
                    break;
                }

                switch(darbiba)
                {
                    case "i":
                        Console.Write("Ievadi summu: ");
                        double summa = Convert.ToDouble(Console.ReadLine());
                        Iemaksat(summa);
                        break;
                    case "p":
                        PirktDzerienu();
                        break;
                    case "a":
                        IzdotAtlikumu();
                        break;
                    default:
                        Console.WriteLine("Nezināma darbība");
                        break;

                }
            }
        }

    }

}
