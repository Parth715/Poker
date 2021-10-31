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
            var player1 = new Player("Player 1");
            var AI = new Player("Player2");
            Console.ForegroundColor = ConsoleColor.Cyan;
            AI.Balance -= 10;
            player1.Balance -= 10;
            var deck = PokerLib.Shuffle(PokerLib.Split1(), PokerLib.Split2());
            List<Cards> User = new List<Cards>();
            var pot = 20;
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + ("----Your Hand----".Length / 2)) + "}", "----Your Hand----"));
            for (var i = 0; i < 2; i++){User.Add(deck.Dequeue());}//adds 2 cards to the users hand
            foreach(var i in User){Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (i.Name.Length / 2)) + "}" , i.Name));}//tells you what cards were dealt to you
            Console.WriteLine(""+"\n");
            Queue<Cards> Ai = new Queue<Cards>();
            for (var i = 0; i < 2; i++){Ai.Enqueue(deck.Dequeue());}//gives the Ai 2 cards
            var reply = "";
            List<Cards> tablecards = new List<Cards>();
            var combination = new List<Cards>();
            do{
                reply = Action(reply);
                if (reply == "fold")
                {
                    Fold();
                }
                if (reply == "call")
                {
                    combination = Check(tablecards, User);
                    Call(tablecards, deck, reply);
                }
                if (reply == "raise")
                {
                    var amt = 0;
                    pot = Pot(amt, player1, pot, AI);
                    Call(tablecards, deck, reply);
                }
                if (reply == "all in")
                {
                    AllIn(pot, player1, AI);
       
                        Call(tablecards, deck, reply);
                }
            } while ((reply == "call" || reply == "raise") && combination.Count < 7);

        }
        private static void Fold()
        {
            Console.WriteLine("Dealer wins this round");
        }
        private static List<Cards> Call(List<Cards> table, Queue<Cards> deck, string reply)
        {
            var repeat = 1;
            if (table.Count == 5)
            if (reply == "all in")
            {
                repeat = 5 - table.Count ;
            }
            for(var i = 0; i < repeat; i++)
            { 
                table.Add(deck.Dequeue());
                while(table.Count < 3)
                {
                    table.Add(deck.Dequeue());
                }
                    if (table.Count == 5)
                    {
                        reply = "";
                    }
            }
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + ("----Table Hand----".Length / 2)) + "}", "----Table Hand----"));
            foreach (var i in table)
            {
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (i.Name.Length / 2)) + "}", i.Name));
            }
            Console.WriteLine("");
            return table;
        }
        private static int Pot(int amt, Player player1, int pot, Player AI)
        {
            Console.WriteLine("How much would you like to raise by?");
            Console.WriteLine($"Your balance is {player1.Balance}");
            var amount = "";
            var ans = false;
            do
            {
                amount = Console.ReadLine();
                try
                {
                    amt = int.Parse(amount);
                    if (amt <= player1.Balance)
                    {
                        ans = true;
                    }
                    if (amt > player1.Balance || amt < 0)
                    {
                        Console.WriteLine("That is an invalid amount enter an amount that you haveall");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter a numerical value");
                    ans = false;
                }
            } while (!ans);
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + ("Player 2 called".Length / 2)) + "}", "Player 2 called"));
            pot = Raise(amt, player1, AI, pot);
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + ($"Your balance is: {player1.Balance}".Length / 2)) + "}", $"Your balance is: {player1.Balance}"));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + ($"There is ${pot} on the table".Length / 2)) + "}", $"There is ${pot} on the table\n"));
            return pot;
        }
        private static int AllIn(int pot, Player player1, Player AI)
        {
            var allin = player1.Balance;
            player1.Balance -= allin;
            AI.Balance -= allin;
            pot += allin * 2;
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + ("Player 2 also went all in".Length / 2)) + "}", "Player 2 also went all in"));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + ($"Your balance is: {player1.Balance}".Length / 2)) + "}", $"Your balance is: {player1.Balance}"));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + ($"There is ${pot} on the table".Length / 2)) + "}", $"There is ${pot} on the table\n"));
            return pot;
        }
        private static int Raise(int amt, Player player1, Player AI, int pot)
        {
                player1.Balance -= amt;
                AI.Balance -= amt;
                return pot += amt * 2;
        }
        private static string Action(string reply)
        {
            do
            {
                Console.WriteLine("What would you like to do:  Fold | Call | Raise | All In");
                reply = Console.ReadLine();
            } while (reply.ToLower() != "fold" && reply.ToLower() != "call" && reply.ToLower() != "raise" && reply.ToLower() != "all in");
            return reply;
        }
        private static List<Cards> Check(List<Cards>tablecards, List<Cards> User)
        {
            var final = new List<Cards>(tablecards);
            if(tablecards.Count == 5)
            {
                foreach (var i in User)
                {
                    final.Add(i);
                }
            }
            return final;     
        }
    }
}
