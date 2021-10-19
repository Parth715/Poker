using System;
using System.Collections.Generic;
using PokerLibrary;

namespace Poker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HI");
            var deck = PokerLib.Shuffle();
            foreach (var i in deck)
            {
                Console.WriteLine($"{i.Name} | {i.Id}");
            }
        }
    }
}
