using System;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck.CreateDeck();
            var deck = ShuffledDeck(deck);
            Deck.ShuffleDeck(deck);
            Console.WriteLine(deck[0].Value + deck[0].Suit);
            var playersCardList = Player.PlayersCardList();
            // var dealersCardList = Dealer.DealersCardList();
            // Console.WriteLine(playersCardList.Count);
            playersCardList.Add(Deck.DealSingleCard());
            // Console.WriteLine(dealersCardList.Count);
            // playersCardList.Add(Deck.DealSingleCard());
            // Console.WriteLine("player: " + playersCardList.Count);
            // Console.WriteLine("dealer: " + dealersCardList.Count);
            // Console.WriteLine(deck.Count);
            // Console.WriteLine("Hit or stay? (Hit = 1, Stay = 0");
            // var turnChoice = Interface.ProcessPlayersTurnChoice();
            // Console.WriteLine(turnChoice);
            // BlackJackEngine.SumTotalOfHand(playersCardList);
            // playersCardList.Add(Deck.DealSingleCard());
            var totalOfHand = BlackJackEngine.SumTotalOfHand(playersCardList);
            Interface.DisplayPlayersHandAndScore(playersCardList, totalOfHand);
            // BlackJackEngine.SumTotalOfHand(dealersCardList);

        }
    }
}