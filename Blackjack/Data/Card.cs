using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Data
{
    public class Card
    {
        //1. īpašība - suit (string) (masts)
        public string Suit;

        //2. īpasība - value (string) (vērtība)
        public string Value;
        
        //3. konstruktors (aizpilda abas īpašības)
        public Card (string suit, string value )
        {
            Suit = suit;
            Value = value;
        }

        //4. int getPoints() - atgriez kārts skaitlisko vērtību
        public int GetPoints()
        {
            switch (Value)
            {
                case "A":
                    return 11; //return aizstāj break
                case "K":
                case "Q":
                case "J":
                    return 10;
                default:
                    //return Convert.ToInt32(Value);
                    return Int32.Parse(Value); // pārvērš no teksta uz skaitli

            }
        }
    }
}
