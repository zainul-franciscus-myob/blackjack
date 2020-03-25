using System;
using System.Collections.Generic;
namespace BlackJack
{
    public class BlackJackEngine
    {
        public static int SumTotalOfHand(List<Card> hand)
        {
            int handValue = 0;
            foreach (var card in hand)
            {
                handValue = handValue + card.Value;
            }

            Console.WriteLine("hand value: " + handValue);
            return handValue;
        }
    }
}