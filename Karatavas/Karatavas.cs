using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karatavas
{
    class Karatavas
    {
        List<String> Vardi;
        char[] MinamaisVards;
        char[] AtminetaisVards;
        int atlikusiesMeginajumi;

        public Karatavas()
        {
            Vardi = new List<string>()
            {
                "APPLE",
                "ICE",
                "SUN",
                "CODING"
            };     
        }

        public void StartNewGame()
        {
            Random rnd = new Random();
            Vardi = Vardi.OrderBy(var => rnd.Next()).ToList();

            string vards = Vardi[0]; // izvēlamies pirmo vārdu no vārdu saraksta
            MinamaisVards = new char[vards.Length];
            AtminetaisVards = new char[vards.Length];
            atlikusiesMeginajumi = 5;

            for ( int i = 0; i < vards.Length; i++)
            {
                MinamaisVards[i] = vards[i];
                AtminetaisVards[i] = '_'; 
            }
            Console.WriteLine(String.Join(" ", AtminetaisVards));
        }

        public void MinetBurtu(char burts)
        {
            bool vaiIrVarda = false;
            for (int i = 0; i < MinamaisVards.Length; i++)
            {
                if (Char.ToUpper(MinamaisVards[i]) == Char.ToUpper(burts))
                {
                    if(AtminetaisVards[i] != burts)
                    {
                        AtminetaisVards[i] = burts;
                        vaiIrVarda = true;
                    }
                    else
                    {
                        Console.WriteLine("Šis burts jau ir atminēts!");
                        break;
                    }
                }
            }

            if (vaiIrVarda)
            {
                Console.WriteLine(String.Join(" ", AtminetaisVards)); // apvieno saraksta vērtības ar atdalītāja vērtībām, atdalītājs ir pēdiņas
            }
            else
            {
                Console.WriteLine("Burts nav šājā vārdā");
                atlikusiesMeginajumi--;
                Console.WriteLine("Atlikušie mēģinājumi " + atlikusiesMeginajumi);
            }
        }

        public string Vards()
        {
            return new string(MinamaisVards);
        }

        public bool VaiIrMeginajumi()
        {
            return atlikusiesMeginajumi > 0;
        }

        //vai vārds ir atminēts
        public bool VaiIrAtminets()
        {
            bool irAtminets = true;
            // vai 'atminētais vārds' satur '_' */
            foreach(char burts in AtminetaisVards)
            {
                if (burts == '_')
                {
                    irAtminets = false;
                    break;
                }
            }

            return irAtminets;
        }

        /*// ĪPAŠĪBAS
        // 1. vārdu saraksts (List<string>)

        // 2. minamais vārds (char[]), piemēram, AKA
        char[] MinamaisVards;
        // 3. atminētais vārds (char[], piemēram, _K_
        char[] AtminetaisVards;

        // KONSTRUKTORS
        // 1. Aizpilda vārdu sarakstu

        // METODES
        // 1. uzsākt jaunu spēli
        // 1.1. random jāizvēlas vārds no saraksta
        // 1.2. aizpildīt 'minamais vārds' ar vārda burtiem
        // 1.3. aizpildīt 'atminētais vārds' ar '_'
        // 1.4. lietotājam izvada 'atminētais vārds' saturu

        // 2. minēt burtu, saņemt vienu parametru - burtu
        // 2.1. pārbaudīt, vai burts ir "minamais vārds' masīvā
        // 2.2. ja ir, tad aizstāj 'atminētais vārds' svītriņu tajā pašā pozīcijā ar burtu - for cikls
        public void MinetBurtu(char burts)
        {
            for (int i = 0; i < MinamaisVards.Lenght; i++)
            {
                if(MinamaisVards[i] == burts)
                {
                    AtminetaisVards[i] = burts;
                }
            }
        }

        // 3. vai vārds ir atminēts
        // 3.1. vai 'atminētais vārds' satur '_' */


    }
}
