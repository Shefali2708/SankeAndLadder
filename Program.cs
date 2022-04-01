using System;

namespace SnakeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Hello to Snake And Ladder Game !");

            // Snake and Ladder game played with single player at start position 0

            SLGameUC1 GameUC1 = new SLGameUC1();
            GameUC1.Start_Game();

            SLGameUC2.Start_Game();


        }
    }
}
