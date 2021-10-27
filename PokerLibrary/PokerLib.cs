using System;
using System.Collections.Generic;
using System.Linq;

namespace PokerLibrary
{
    public class PokerLib
    {
        public static List<Cards> Split1()
        {
            List<Cards> Deck = new List<Cards>();
            Deck.Add(new Cards("2 of Hearts", 1));
            Deck.Add(new Cards("2 of Clubs", 2));
            Deck.Add(new Cards("2 of Diamonds", 3));
            Deck.Add(new Cards("2 of Spades", 4));
            Deck.Add(new Cards("3 of Hearts", 5));
            Deck.Add(new Cards("3 of Clubs", 6));
            Deck.Add(new Cards("3 of Diamonds", 7));
            Deck.Add(new Cards("3 of Spades", 8));
            Deck.Add(new Cards("4 of Hearts", 9));
            Deck.Add(new Cards("4 of Clubs", 10));
            Deck.Add(new Cards("4 of Diamonds", 11));
            Deck.Add(new Cards("4 of Spades", 12));
            Deck.Add(new Cards("5 of Hearts", 13));
            Deck.Add(new Cards("5 of Clubs", 14));
            Deck.Add(new Cards("5 of Diamonds", 15));
            Deck.Add(new Cards("5 of Spades", 16));
            Deck.Add(new Cards("6 of Hearts", 17));
            Deck.Add(new Cards("6 of Clubs", 18));
            Deck.Add(new Cards("6 of Diamonds", 19));
            Deck.Add(new Cards("6 of Spades", 20));
            Deck.Add(new Cards("7 of Hearts", 21));
            Deck.Add(new Cards("7 of Clubs", 22));
            Deck.Add(new Cards("7 of Diamonds", 23));
            Deck.Add(new Cards("7 of Spades", 24));
            Deck.Add(new Cards("8 of Hearts", 25));
            Deck.Add(new Cards("8 of Clubs", 26));
            return Deck;
        }
        public static List<Cards> Split2() {
            List<Cards> Deck = new List<Cards>();
            Deck.Add(new Cards("8 of Diamonds", 27));
            Deck.Add(new Cards("8 of Spades", 28));
            Deck.Add(new Cards("9 of Hearts", 29));
            Deck.Add(new Cards("9 of Clubs", 30));
            Deck.Add(new Cards("9 of Diamonds", 31));
            Deck.Add(new Cards("9 of Spades", 32));
            Deck.Add(new Cards("10 of Hearts", 33));
            Deck.Add(new Cards("10 of Clubs", 34));
            Deck.Add(new Cards("10 of Diamonds", 35));
            Deck.Add(new Cards("10 of Spades", 36));
            Deck.Add(new Cards("Jack of Hearts", 37));
            Deck.Add(new Cards("Jack of Clubs", 38));
            Deck.Add(new Cards("Jack of Diamonds", 39));
            Deck.Add(new Cards("Jack of Spades", 40));
            Deck.Add(new Cards("Queen of Hearts", 41));
            Deck.Add(new Cards("Queen of Clubs", 42));
            Deck.Add(new Cards("Queen of Diamonds", 43));
            Deck.Add(new Cards("Queen of Spades", 44));
            Deck.Add(new Cards("King of Hearts", 45));
            Deck.Add(new Cards("King of Clubs", 46));
            Deck.Add(new Cards("King of Diamonds", 47));
            Deck.Add(new Cards("King of Spades", 48));
            Deck.Add(new Cards("Ace of Hearts", 49));
            Deck.Add(new Cards("Ace of Clubs", 50));
            Deck.Add(new Cards("Ace of Diamonds", 51));
            Deck.Add(new Cards("Ace of Spades", 52));
            return Deck;
        }
        public static Queue<Cards> Shuffle(List<Cards> deck, List<Cards> deck2)
        {
            List<Cards> split1 = Split1();
            List<Cards> split2 = Split2();
            List<Cards> shuffle = new List<Cards>();
            Random rand = new Random();
            for (var idx = 0; idx < 26; idx++)
            {
                shuffle.Add(split1[idx]);
                shuffle.Add(split2[idx]);
            }

            Queue<Cards> newshuffle = new Queue<Cards>();
            foreach (var i in shuffle)
            {
                newshuffle.Enqueue(i);
            }
            var count = newshuffle.Count();
            Queue<Cards> newshuffle2 = new Queue<Cards>();
            while (count > 0)
            {
                int gen = rand.Next(1, 4);
                if (gen >= count)
                {
                    gen = count;
                }
                for (int i = 1; i <= gen; i++)
                {
                    newshuffle2.Enqueue(newshuffle.Dequeue());
                }
                newshuffle = new Queue<Cards>(newshuffle.Reverse());
                count = newshuffle.Count();
            }
            for (var idx = 0; idx < rand.Next(5, 40); idx++)
            {
                newshuffle2.Enqueue(newshuffle2.Dequeue());
            }
            return newshuffle2;
        }

        public static void NewGame()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Enter your name");
            var username = Console.ReadLine();
            var player1 = new Player(username);
            var deck = PokerLib.Shuffle(PokerLib.Split1(), PokerLib.Split2());
            Queue<Cards> User = new Queue<Cards>();
            Console.WriteLine("Your Hand"+"\n");
            for (var i = 0; i < 2; i++)
            {
                User.Enqueue(deck.Dequeue());
            }
            foreach(var i in User)
            {
                Console.WriteLine(i.Name );
            }
            Console.WriteLine(""+"\n");
        }
        
    }
}
