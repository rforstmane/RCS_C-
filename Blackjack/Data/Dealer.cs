using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Data
{
    class Dealer : Player //dīleris manto playera īpašības
    {
        public override void GiverCard(Card card)
        {
            Cards.Add(card); //pievienojam kārtis //klases parasti ar lieloburtu rakstam, fjas parametrus ar mazo
        }

        public override bool NeedCard()
        {
            //ja nav sasneigti 17 punkti, tad ir nepieciešama kārts
            return CountPoint() < 17; 
        }
    }
}
