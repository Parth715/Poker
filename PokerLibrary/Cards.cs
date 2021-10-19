using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerLibrary
{
    public class Cards
    {
        static int CardId { get; set; } = 1;
        public int Id { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }


        public Cards(string name, int value )
        {
            Id = CardId;
            CardId += CardId + 1;
            Name = name;
            Value = value;
        }
    }
}
