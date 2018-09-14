using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena4
{
    public class kvadrats
    {
        public String krasa; //mainīgie, public nozīmē, ka šīs klases saturu varēs izmantot citas klases
        public int garums; //mainīgie

        public void laukums () //f-ija
        {
            Console.WriteLine("Laukums ir: " + garums * garums);
            
        }
        public void perimetrs()
        {
            Console.WriteLine("Perimetrs ir: " + garums * 4);
        }
        public void krasa1()
        {
            Console.WriteLine("Krāsa ir: " + krasa);
        }
    }
}
