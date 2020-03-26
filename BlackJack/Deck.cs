using System;
using System.Collections.Generic;
using System.Linq;

namespace BlackJack
{
    public static class Deck
    {
        public static List<Card> deck = new List<Card>();
        
        public static List<Card> CreateDeck()
        {
            deck.Add(new Card(){Suit = "Hearts", Value = 2, Picture = "Two"});
            deck.Add(new Card(){Suit = "Hearts", Value = 3, Picture = "Three"});
            deck.Add(new Card(){Suit = "Hearts", Value = 4, Picture = "Four"});
            deck.Add(new Card(){Suit = "Hearts", Value = 5, Picture = "Five"});
            deck.Add(new Card(){Suit = "Hearts", Value = 6, Picture = "Six"});
            deck.Add(new Card(){Suit = "Hearts", Value = 7, Picture = "Seven"});
            deck.Add(new Card(){Suit = "Hearts", Value = 8, Picture = "Eight"});
            deck.Add(new Card(){Suit = "Hearts", Value = 9, Picture = "Nine"});
            deck.Add(new Card(){Suit = "Hearts", Value = 10, Picture = "Ten"});
            deck.Add(new Card(){Suit = "Hearts", Value = 10, Picture = "Jack"});
            deck.Add(new Card(){Suit = "Hearts", Value = 10, Picture = "Queen"});
            deck.Add(new Card(){Suit = "Hearts", Value = 10, Picture = "King"});
            deck.Add(new Card(){Suit = "Hearts", Value = 11, Picture = "Ace"});
            deck.Add(new Card(){Suit = "Clubs", Value = 2, Picture = "Two"});
            deck.Add(new Card(){Suit = "Clubs", Value = 3, Picture = "Three"});
            deck.Add(new Card(){Suit = "Clubs", Value = 4, Picture = "Four"});
            deck.Add(new Card(){Suit = "Clubs", Value = 5, Picture = "Five"});
            deck.Add(new Card(){Suit = "Clubs", Value = 6, Picture = "Six"});
            deck.Add(new Card(){Suit = "Clubs", Value = 7, Picture = "Seven"});
            deck.Add(new Card(){Suit = "Clubs", Value = 8, Picture = "Eight"});
            deck.Add(new Card(){Suit = "Clubs", Value = 9, Picture = "Nine"});
            deck.Add(new Card(){Suit = "Clubs", Value = 10, Picture = "Ten"});
            deck.Add(new Card(){Suit = "Clubs", Value = 10, Picture = "Jack"});
            deck.Add(new Card(){Suit = "Clubs", Value = 10, Picture = "Queen"});
            deck.Add(new Card(){Suit = "Clubs", Value = 10, Picture = "King"});
            deck.Add(new Card(){Suit = "Clubs", Value = 11, Picture = "Ace"});
            deck.Add(new Card(){Suit = "Spades", Value = 2, Picture = "Two"});
            deck.Add(new Card(){Suit = "Spades", Value = 3, Picture = "Three"});
            deck.Add(new Card(){Suit = "Spades", Value = 4, Picture = "Four"});
            deck.Add(new Card(){Suit = "Spades", Value = 5, Picture = "Five"});
            deck.Add(new Card(){Suit = "Spades", Value = 6, Picture = "Six"});
            deck.Add(new Card(){Suit = "Spades", Value = 7, Picture = "Seven"});
            deck.Add(new Card(){Suit = "Spades", Value = 8, Picture = "Eight"});
            deck.Add(new Card(){Suit = "Spades", Value = 9, Picture = "Nine"});
            deck.Add(new Card(){Suit = "Spades", Value = 10, Picture = "Ten"});
            deck.Add(new Card(){Suit = "Spades", Value = 10, Picture = "Jack"});
            deck.Add(new Card(){Suit = "Spades", Value = 10, Picture = "Queen"});
            deck.Add(new Card(){Suit = "Spades", Value = 10, Picture = "King"});
            deck.Add(new Card(){Suit = "Spades", Value = 11, Picture = "Ace"});
            deck.Add(new Card(){Suit = "Diamonds", Value = 2, Picture = "Two"});
            deck.Add(new Card(){Suit = "Diamonds", Value = 3, Picture = "Three"});
            deck.Add(new Card(){Suit = "Diamonds", Value = 4, Picture = "Four"});
            deck.Add(new Card(){Suit = "Diamonds", Value = 5, Picture = "Five"});
            deck.Add(new Card(){Suit = "Diamonds", Value = 6, Picture = "Six"});
            deck.Add(new Card(){Suit = "Diamonds", Value = 7, Picture = "Seven"});
            deck.Add(new Card(){Suit = "Diamonds", Value = 8, Picture = "Eight"});
            deck.Add(new Card(){Suit = "Diamonds", Value = 9, Picture = "Nine"});
            deck.Add(new Card(){Suit = "Diamonds", Value = 10, Picture = "Ten"});
            deck.Add(new Card(){Suit = "Diamonds", Value = 10, Picture = "Jack"});
            deck.Add(new Card(){Suit = "Diamonds", Value = 10, Picture = "Queen"});
            deck.Add(new Card(){Suit = "Diamonds", Value = 10, Picture = "King"});
            deck.Add(new Card(){Suit = "Diamonds", Value = 11, Picture = "Ace"});
            deck = ShuffleDeck(deck);
            return deck;
        }

        public static List<Card> ShuffleDeck(List<Card> deck)
        {
            var shuffledDeck = deck.OrderBy(x => Guid.NewGuid()).ToList();
            return shuffledDeck;
        }
        
        public static Card DealSingleCard()
        {
            var card = deck[0];
            deck.Remove(card);
            return card;
        }

        public static List<Card> DealStartingHand()
        {
            // ADD FUNCTION FOR SETTING HOW MANY CARDS TO START WITH? 
            var hand = new List<Card>(); 
            hand.Add(DealSingleCard());
            hand.Add(DealSingleCard());
            return hand;
        }
        

    }
}