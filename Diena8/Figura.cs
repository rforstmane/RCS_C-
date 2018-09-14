using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena8
{
    public interface Figura
    {
        void Laukums(); //metode, kas nosaka, ka jebkurai figūrai mēs varēsim aprēķināt gan laukumu, gan perimetru

        double Perimetrs();
    }
}
