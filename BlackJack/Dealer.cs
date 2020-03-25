using System.Collections.Generic;

namespace BlackJack
{
    public class Dealer
    {
        public static List<Card> DealersCardList()
        {
            var dealersHand = Deck.DealStartingHand();
            return dealersHand;
        }
    }
}