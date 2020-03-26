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
            return handValue;
        }

        public static void ExecutePlayersAction(bool turnDecision, List<Card> hand)
        {
            if (turnDecision == true)
            {
                hand.Add(Deck.DealSingleCard());
            }
        }
        
        // Check if hand is blackjack (Ace and 10 value)
        public static bool CheckForBlackJack(List<Card> hand)
        {
            if ((hand[0].Value == 11 && hand[1].Value == 10) || hand[0].Value == 10 && hand[1].Value == 11)
            {
                return true; 
            }
            return false;
        }

        // check if hand is bust && if so check if Ace is used and can be 1. 
        public static bool CheckIfBust(int totalOfHand)
        {
            var bust = totalOfHand > 21;
            return bust;
        }

        // check which hand is higher if not bust
        public static bool CheckIfPlayerBeatsDealer(int playersTotal, int dealersTotal)
        {
            var playerWins = playersTotal > dealersTotal;
            return playerWins;
        }

        // if blackjack, that player wins or both then draw

        // if either player busts other player wins

        // 
    }
}