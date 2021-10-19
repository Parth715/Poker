using System;
using System.Collections.Generic;
using System.Linq;

namespace PokerLibrary
{
    public class PokerLib
    {
        public static Queue<Cards> NewDeck()
        {
            Queue<Cards> Deck = new Queue<Cards>();
            Deck.Enqueue(new Cards("2 of Hearts", 2));
            Deck.Enqueue(new Cards("2 of Clubs", 2));
            Deck.Enqueue(new Cards("2 of Diamonds", 2));
            Deck.Enqueue(new Cards("2 of Spades", 2));
            Deck.Enqueue(new Cards("3 of Hearts", 3));
            Deck.Enqueue(new Cards("3 of Clubs", 3));
            Deck.Enqueue(new Cards("3 of Diamonds", 3));
            Deck.Enqueue(new Cards("3 of Spades", 3));
            Deck.Enqueue(new Cards("4 of Hearts", 4));
            Deck.Enqueue(new Cards("4 of Clubs", 4));
            Deck.Enqueue(new Cards("4 of Diamonds", 4));
            Deck.Enqueue(new Cards("4 of Spades", 4));
            Deck.Enqueue(new Cards("5 of Hearts", 5));
            Deck.Enqueue(new Cards("5 of Clubs", 5));
            Deck.Enqueue(new Cards("5 of Diamonds", 5));
            Deck.Enqueue(new Cards("5 of Spades", 5));
            Deck.Enqueue(new Cards("6 of Hearts", 6));
            Deck.Enqueue(new Cards("6 of Clubs", 6));
            Deck.Enqueue(new Cards("6 of Diamonds", 6));
            Deck.Enqueue(new Cards("6 of Spades", 6));
            Deck.Enqueue(new Cards("7 of Hearts", 7));
            Deck.Enqueue(new Cards("7 of Clubs", 7));
            Deck.Enqueue(new Cards("7 of Diamonds", 7));
            Deck.Enqueue(new Cards("7 of Spades", 7));
            Deck.Enqueue(new Cards("8 of Hearts", 8));
            Deck.Enqueue(new Cards("8 of Clubs", 8));
            Deck.Enqueue(new Cards("8 of Diamonds", 8));
            Deck.Enqueue(new Cards("8 of Spades", 8));
            Deck.Enqueue(new Cards("9 of Hearts", 9));
            Deck.Enqueue(new Cards("9 of Clubs", 9));
            Deck.Enqueue(new Cards("9 of Diamonds", 9));
            Deck.Enqueue(new Cards("9 of Spades", 9));
            Deck.Enqueue(new Cards("10 of Hearts", 10));
            Deck.Enqueue(new Cards("10 of Clubs", 10));
            Deck.Enqueue(new Cards("10 of Diamonds", 10));
            Deck.Enqueue(new Cards("10 of Spades", 10));
            Deck.Enqueue(new Cards("Jack of Hearts", 11));
            Deck.Enqueue(new Cards("Jack of Clubs", 11));
            Deck.Enqueue(new Cards("Jack of Diamonds", 11));
            Deck.Enqueue(new Cards("Jack of Spades", 11));
            Deck.Enqueue(new Cards("Queen of Hearts", 12));
            Deck.Enqueue(new Cards("Queen of Clubs", 12));
            Deck.Enqueue(new Cards("Queen of Diamonds", 12));
            Deck.Enqueue(new Cards("Queen of Spades", 12));
            Deck.Enqueue(new Cards("King of Hearts", 13));
            Deck.Enqueue(new Cards("King of Clubs", 13));
            Deck.Enqueue(new Cards("King of Diamonds", 13));
            Deck.Enqueue(new Cards("King of Spades", 13));
            Deck.Enqueue(new Cards("Ace of Hearts", 14));
            Deck.Enqueue(new Cards("Ace of Clubs", 14));
            Deck.Enqueue(new Cards("Ace of Diamonds", 14));
            Deck.Enqueue(new Cards("Ace of Spades", 14));
            return Deck;
        }
        public static Queue<Cards> Shuffle()
        {
            Queue<Cards> orddeck = NewDeck();
            var shuffled = new Queue<Cards>();
            var count = orddeck.Count();
            Random rand = new Random();
            while (count > 0)
            {
                int gen = rand.Next(1, 4);
                if (gen >= count)
                {
                    gen = count;
                }
                for (int i = 1; i <= gen; i++)
                {
                    shuffled.Enqueue(orddeck.Dequeue());
                }
                orddeck = new Queue<Cards>(orddeck.Reverse());
                count = orddeck.Count();
            }
            return shuffled;
        }
    }
}
