using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadder
{
    class SLGameUC1
    {
        public int Player_Position = 0;
        public void Start_Game()
        {
            // Snake and Ladder game played with single player at start position 0

            Console.WriteLine("      Game Started ");
            Console.WriteLine("Number of Player is Single Player");
            Console.WriteLine(" Player Position: {0} ", Player_Position);
        }
      
    }
}
