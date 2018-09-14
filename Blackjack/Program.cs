﻿using Blackjack.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            Table table = new Table();

            while(true)
            {
                table.StartNewGame();
                table.PlayerTurn();
                table.DealerTurn();
                table.ShowResults();

                //pārbaude, vai uzsākt jaunu spēli
                //if (table.PlayAgain() == false)
                if(!table.PlayAgain())
                {
                    break;
                }
            }
            
            // 3. cikliski uzsākt jaunu spēli

            Console.ReadLine();
        }
    }
}
