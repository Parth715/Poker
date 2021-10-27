using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerLibrary
{
    public class Player
    {
        public string Name { get; set; }
        public int Balance { get; set; } = 10000;
        public Queue<Cards> Hand { get; set; }

        public Player(string name)
        {
            Name = name;
        }

        
    }
}
