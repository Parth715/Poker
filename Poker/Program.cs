using System;
using System.Collections.Generic;
using PokerLibrary;

namespace Poker
{
    class Program
    {
        static void Main(string[] args)
        {
            var deck = PokerLib.Shuffle(PokerLib.Split1(), PokerLib.Split2());
            
            foreach (var i in deck)
            {
                Console.WriteLine($"{i.Name} | {i.Value}");
            }
        }
    }
}
