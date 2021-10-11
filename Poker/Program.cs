using System;
using System.Collections.Generic;

namespace Poker
{
    class Program
    {
        static void Main(string[] args)
        {
            var shuffle = new List<Cards> { };
            shuffle.Add(new Cards("Diamond", 2));
            shuffle.Add(new Cards("Heart", 2));
            shuffle.Add(new Cards("Spade", 2));
            shuffle.Add(new Cards("Club", 2));
            shuffle.Add(new Cards("Diamond", 3));
            shuffle.Add(new Cards("Heart", 3));
            shuffle.Add(new Cards("Spade", 3));
            shuffle.Add(new Cards("Club", 3));
            shuffle.Add(new Cards("Diamond", 4));
            shuffle.Add(new Cards("Heart", 4));
            shuffle.Add(new Cards("Spade", 4));
            shuffle.Add(new Cards("Club", 4));
            shuffle.Add(new Cards("Diamond", 5));
            shuffle.Add(new Cards("Heart", 5));
            shuffle.Add(new Cards("Spade", 5));
            shuffle.Add(new Cards("Club", 5));
            shuffle.Add(new Cards("Diamond", 6));
            shuffle.Add(new Cards("Heart", 6));
            shuffle.Add(new Cards("Spade", 6));
            shuffle.Add(new Cards("Club", 6));
            shuffle.Add(new Cards("Diamond", 7));
            shuffle.Add(new Cards("Heart", 7));
            shuffle.Add(new Cards("Spade", 7));
            shuffle.Add(new Cards("Club", 7));
            shuffle.Add(new Cards("Diamond", 8));
            shuffle.Add(new Cards("Heart", 8));
            shuffle.Add(new Cards("Spade", 8));
            shuffle.Add(new Cards("Club", 8));
            shuffle.Add(new Cards("Diamond", 9));
            shuffle.Add(new Cards("Heart", 9));
            shuffle.Add(new Cards("Spade", 9));
            shuffle.Add(new Cards("Club", 9));
            shuffle.Add(new Cards("Diamond", 10));
            shuffle.Add(new Cards("Heart", 10));
            shuffle.Add(new Cards("Spade", 10));
            shuffle.Add(new Cards("Club", 10));
            shuffle.Add(new Cards("Diamond", 11));
            shuffle.Add(new Cards("Heart", 11));
            shuffle.Add(new Cards("Spade", 11));
            shuffle.Add(new Cards("Club", 11));
            shuffle.Add(new Cards("Diamond", 12));
            shuffle.Add(new Cards("Heart", 12));
            shuffle.Add(new Cards("Spade", 12));
            shuffle.Add(new Cards("Club", 12));
            shuffle.Add(new Cards("Diamond", 13));
            shuffle.Add(new Cards("Heart", 13));
            shuffle.Add(new Cards("Spade", 13));
            shuffle.Add(new Cards("Club", 13));
            shuffle.Add(new Cards("Diamond", 14));
            shuffle.Add(new Cards("Heart", 14));
            shuffle.Add(new Cards("Spade", 14));
            shuffle.Add(new Cards("Club", 14));
            Console.WriteLine(shuffle.Number);
        }
    }
}
