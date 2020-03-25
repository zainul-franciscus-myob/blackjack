using System.Collections.Generic;
namespace BlackJack
{
    public class Player
    {
        public static List<Card> PlayersCardList()
        {
            var playersHand = Deck.DealStartingHand();
            return playersHand;
        }
        
    }
}