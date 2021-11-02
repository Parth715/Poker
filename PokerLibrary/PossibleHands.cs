using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerLibrary
{
    public class PossibleHands
    {
        public static bool RoyalFlush(List<Cards> combination)
        {
            List<Cards> strflushS = new List<Cards>(5)
            {
                new Cards("Ace of Spades", 52, 14),
                new Cards("King of Spades", 48, 13),
                new Cards("Queen of Spades", 44, 12),
                new Cards("Jack of Spades", 40, 11),
                new Cards("10 of Spades", 36, 10)
            };
            List<Cards> strflushD = new List<Cards>(5)
            {
                new Cards("Ace of Diamonds", 51, 14),
                new Cards("King of Diamonds", 47, 13),
                new Cards("Queen of Diamonds", 43, 12),
                new Cards("Jack of Diamonds", 39, 11),
                new Cards("10 of Diamonds", 35, 10)
            };
            List<Cards> strflushC = new List<Cards>(5)
            {
                new Cards("Ace of Clubs", 50, 14),
                new Cards("King of Clubs", 46, 13),
                new Cards("Queen of Clubs", 42, 12),
                new Cards("Jack of Clubs", 38, 11),
                new Cards("10 of Clubs", 34, 10)
            };
            List<Cards> strflushH = new List<Cards>(5)
            {
                new Cards("Ace of Hearts", 49, 14),
                new Cards("King of Hearts", 45, 13),
                new Cards("Queen of Hearts", 41, 12),
                new Cards("Jack of Hearts", 37, 11),
                new Cards("10 of Hearts", 33, 10)
            };
            if ((strflushC.Intersect(combination).Any()) || (strflushD.Intersect(combination).Any()) || (strflushH.Intersect(combination).Any()) || (strflushS.Intersect(combination).Any()))
            {
                return true;
            }
            return false;
        }
        public static bool StraightFlush(List<Cards> tablecards)
        {

            return true;
        }
        public static void FourOfKind()
        {

        }
        public static void FullHouse()
        {

        }
        public static void Flush()
        {

        }
        public static void Straight()
        {

        }
        public static void ThreeOfKind()
        {

        }
        public static void TwoPair()
        {

        }
        public static void OnePair()
        {

        }
        public static int HighCard(List<Cards> combination)
        {
            var max = 0;
            foreach (var i in combination)
            {
                if (i.Num > max)
                {
                    max = i.Num;
                }
            }
            return max;
        }
    }
}
