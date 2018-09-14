using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena5
{
    public class Prece
    {
        public string Nosaukums; //ar lielo burtu definētas klases vērtībā
        public double Cena;
        public Prece(string nosaukums, double cena) // ar mazo burtu dzīvo funkcijā //funkcija konstruktors 
        {
            Nosaukums = nosaukums;
            Cena = cena;
        }
    }
}
