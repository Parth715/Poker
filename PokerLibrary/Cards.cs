using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerLibrary
{
    public class Cards
    {
        public string Name { get; set; }
        public int Value { get; set; }
        public int Num { get; set; }

        public Cards(string name, int value, int num )
        {
            Name = name;
            Value = value;
            Num = num;
        }
    }
}
