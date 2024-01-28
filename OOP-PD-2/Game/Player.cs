using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Player
    {
        public int x;
        public int y;
        public char symbol;

        public Player(int initialX, int initialY, char playerSymbol)
        {
            x = initialX;
            y = initialY;
            symbol = playerSymbol;
        }
    }
}
