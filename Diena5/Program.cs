using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena5
{
    class Program
    {
        static void Main(string[] args)
        {
            //IedzivotajsAdrese();
            //MasivaPiemers();
            //Uzdevumi.Uzdevums24();
            //Uzdevumi.Uzdevums25();
            //Uzdevumi.Uzdevums26(); //while, tad for each 
            //Uzdevumi.Uzdevums27();
            //Uzdevumi.Uzdevums28();

            Console.ReadLine();
        }

        static void SarakstaPiemers()
        {
            List<int> saraksts = new List<int>();
            saraksts.Add(5);
            saraksts.Add(10);
            saraksts.Add(17);

            foreach(int sk in saraksts)
            {
                Console.WriteLine(sk);
            }

            for (int i = 0; i < saraksts.Count; i++) //count ir tas pats kas add
            {
                Console.WriteLine(saraksts[i]);
            }
        }

        static void MasivaPiemers()
        {
            //int skaitlis1 = 5;
            //int skaitlis2 = 10;
            int[] saraksts = new int[3];
            saraksts[0] = 5;
            saraksts[1] = 10;
            saraksts[2] = 19;
            //saraksts[3] <- izmestu kļūdu

            int[] saraksts2 = { 5, 10, 19 };
            int skaitsMasiva = saraksts2.Length; // 3

            // izvadīs 5 10 19
            for (int i = 0; i < saraksts.Length; i++)
            {
                //izvada skaitli pozīcijā "i"
                Console.WriteLine(saraksts[i]);
            }

            // izvadīs 5 10 19
            foreach (int skaitlis in saraksts)
            {
                Console.WriteLine(skaitlis);
            }
        }

        static void IedzivotajsAdrese()
        {
            Iedzivotajs iedz = new Iedzivotajs();
            iedz.Vards = "Andris";
            iedz.Uzvards = "Bērziņš";
            iedz.Dzivesvieta = new Adrese();
            iedz.Dzivesvieta.Valsts = "Latvija";
            iedz.Dzivesvieta.Pilseta = "Rīga";
            iedz.Dzivesvieta.Iela = "Brīvības gatve";
            iedz.Dzivesvieta.MajasNr = "100";
            iedz.Dzivesvieta.DzivoklaNr = 5;

            iedz.Apraksts();
        }
    }
}
