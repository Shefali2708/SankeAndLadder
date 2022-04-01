using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadder
{
    class SLGameUC2
    {
        //UC2
        public static void Start_Game()
        {
            int Player_Position = 0;
            // Snake and Ladder game played with single player at start position 0

            Random randomNumber = new Random();
            int DiceRolled = randomNumber.Next(1, 7);
            Console.WriteLine("DiceRolled : {0} ", DiceRolled);
            Player_Position = Player_Position + DiceRolled;

            Console.WriteLine(" Player Position: {0} ", Player_Position);
        }
    }
}
