using System;
using System.Collections.Generic;
using PokerLibrary;

namespace Poker
{
    class Program
    {
        static void Main(string[] args)
        {
            var playAgain = "";
            do
            {
                PokerLib.NewGame();
                
                Console.WriteLine("Play again? (Y/N)");
                playAgain = Console.ReadLine();
            } while (playAgain == "Y" || playAgain == "y");
            Console.WriteLine("You have entered an invalid input or entered no");
        }
    }
}
