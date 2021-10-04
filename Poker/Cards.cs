using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    class Cards
    {
        public string Type { get; set; }
        public int Number { get; set; }
        
        public Cards(string a, int b)
        {
            Type = a;
            Number = b;
        }
        public Cards(string a)
        {
            Type = a;
        }

    }
}
