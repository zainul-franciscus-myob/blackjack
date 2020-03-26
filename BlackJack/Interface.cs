using System;
using System.Collections.Generic;

namespace BlackJack
{
    public class Interface
    {
        public static bool ProcessPlayersTurnChoice()
        {
            
            int playerDecision = Convert.ToInt32(Console.ReadLine());
            
            if (playerDecision == 1)
            {
                return true;
            }
            else if (playerDecision == 0)
            {
                return false;
            }
            else
            {
                Console.WriteLine("That's not a valid response, please try again.");
                return false;
            }
        }

        public static void DisplayPlayersHandAndScore(List<Card> hand, int handValue)
        {
            Console.WriteLine($"You are currently sitting at {handValue}");
            Console.Write($"With a hand of ");
            foreach (var card in hand)
            {
                Console.Write($"[{card.Value} {card.Suit}] ");
            }

            Console.WriteLine("");
        }
    }
}