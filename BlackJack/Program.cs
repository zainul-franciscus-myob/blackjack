using System;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            //START GAME
            var deck = Deck.CreateDeck();
            var playersCardList = Player.PlayersCardList();
            var dealersCardList = Dealer.DealersCardList();
            Console.WriteLine("player blackjack: " + BlackJackEngine.CheckForBlackJack(playersCardList));
            Console.WriteLine("dealer blackjack: " + BlackJackEngine.CheckForBlackJack(dealersCardList));

            // DISPLAY PLAYERS SCORE
            var totalOfHand = BlackJackEngine.SumTotalOfHand(playersCardList);
            Interface.DisplayPlayersHandAndScore(playersCardList, totalOfHand);
            
            // CHECK IF PLAYER WANTS TO CONTINUE
            Console.WriteLine("Hit or stay? (Hit = 1, Stay = 0)");
            var turnChoice = Interface.ProcessPlayersTurnChoice();
            Console.WriteLine(turnChoice);
            
            // ADD CARD TO DECK OR STOP TURN
            BlackJackEngine.ExecutePlayersAction(turnChoice, playersCardList);
            
            // DISPLAY PLAYERS SCORE
            totalOfHand = BlackJackEngine.SumTotalOfHand(playersCardList);
            Interface.DisplayPlayersHandAndScore(playersCardList, totalOfHand);
            Console.WriteLine("Bust? " + BlackJackEngine.CheckIfBust(totalOfHand));

        }
    }
}