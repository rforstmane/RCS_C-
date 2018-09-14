using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Data
{
    public class Table

    {
        private Deck deck;
        private Dealer dealer;
        private Player player;


        // 1. void StartNewGame()
        public void StartNewGame()
        {
            // 1.1. paņem jaunu kārš kavu
            deck = new Deck();
            dealer = new Dealer();
            player = new Player();
            // 1.2. samaisa kārtis
            deck.Shuffle();
            // 1.3. spēlētājam piešķir 2 kārtis
            player.GiverCard(deck.GetCard());
            player.GiverCard(deck.GetCard());
            // 1.4. dīlerim piešķir 2 kārtis
            dealer.GiverCard(deck.GetCard());
            dealer.GiverCard(deck.GetCard());
        }

        // 2. bool PlayAgain()
        public bool PlayAgain()
        {
            // 2.1. vaicá lietotájam vai uzsákt jaunu spēli
            Console.WriteLine("Vai uzsākt jaunu spēli (j/n)? ");
            string answer = Console.ReadLine();
            return answer.ToLower() == "j";
        }

        // 3. void ShowResults()
        public void ShowResults()
        {
            // 3.1. izvada Rezultātu - kurš uzvarēja
            int playerPoints = player.CountPoint();
            int dealerPoints = dealer.CountPoint();
            Console.WriteLine("Dīlera punkti: " + dealerPoints);
            Console.WriteLine("Spēlētāja punkti: " + playerPoints);

            if (playerPoints > 21)
            {
                Console.WriteLine("Tu zaudēji!");
            }
            else if (dealerPoints > 21)
            {
                Console.WriteLine("Tu uzvarēji!");
            }
            else if (playerPoints == dealerPoints)
            {
                Console.WriteLine("Neizšķirts");
            }
            else if (playerPoints > dealerPoints)
            {
                Console.WriteLine("Tu uzvarēji");
            }
            else
            {
                Console.WriteLine("Tu zaudēji!");
            }

        }

        // 4. void PlayerTurn()
        public void PlayerTurn()
        {
            // 4.1. dod kārtis spēlētājam tik ilgi, kamēr vēlas
            while(player.NeedCard())
            {
                player.GiverCard(deck.GetCard());
            }
        }


        // 5. void DealerTurn()
        public void DealerTurn()
        {
            // 5.1. dod kārtis dīlerim tik ilgi, kamēŗ nepieciešams
            while (dealer.NeedCard())
            {
                dealer.GiverCard(deck.GetCard());
            }
        }


    }
}
