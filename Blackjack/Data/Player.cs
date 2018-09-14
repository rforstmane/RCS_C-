using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Data
{
    public class Player
    {
        //1. īpašība Cards (List<Cards>)
        public List<Card> Cards;

        //2. konstruktors (bez parametriem)
        //2.1. definē Cards sarakstu
        public Player()
        {
            Cards = new List<Card>();
        }

        //3. int countPoints() - saskaita visu Cards punktus
        public int CountPoint()
        {
            //3.1. foreach()
            //3.2. ->GetPoint()
            int points = 0;
            int aceCount = 0;
            
            foreach(Card c in Cards) // c- ejam cauri visām kārtīm, kas ir spēlētājam uz rokas
            {
                points += c.GetPoints();
                // ja ir dūzis, tad palielinām skaitu
                if (c.Value == "A")
                {
                    aceCount++; 
                }
            }

            //3.3. TODO - apstrādāt dūžus
            // ja punktu skaits pārsniedz 21 un ir kāds dūzis, tad par katru ņemam nost 10 punktus, 
            //kapēr nepārsniedz 21 vai beidzas dūži
            while(points > 21 && aceCount > 0)
            {
                points -= 10;
                aceCount--;
            }

            return points;
        }

        //4. void giveCard(Card card) - pievieno kārti sarakstam

        public virtual void GiverCard(Card card) 
        {
            Cards.Add(card);
            Console.WriteLine("Spēlētājs saņēma " + card.Suit + card.Value);
            Console.WriteLine("Punkti = " + CountPoint());
        }

        //5. bool needCard() - vai nepieciešama vēl kārts?
        public virtual bool NeedCard()
        {
            if (CountPoint() > 21)
            {
                return false;
            }

            Console.Write("Vai nepieciešama vēl kāda kārts(j/n)?");
            string atbilde = Console.ReadLine();

            if (atbilde.ToLower() == "j")
            {
                return true;
            }
            else
            {
                return false;
            }
            //vai:
            // return atbilde.ToLower() == "j";
        }
    }
}
