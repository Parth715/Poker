using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    public class Cards
    {
        private int CardId { get; set; } = 1;
        public string Type { get; set; }
        public int Number { get; set; }
        public string Face { get; set; }


        public Cards(string a, int b)
        {
            Type = a;
            Number = b;
            this.CardId++;
        }
        
        public int Shuffle()
        {
            var shuffled = new List<Cards>();
            var rand = new Random();
            var rdm = rand.Next(1, 4);
            return rdm;
        }

    }
}
