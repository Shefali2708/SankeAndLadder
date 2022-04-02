using System;

namespace SnakeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Hello to Snake And Ladder Game !");

            SLGameUC1 GameUC1 = new SLGameUC1();
            GameUC1.Start_Game();

            SLGameUC2.Start_Game();

            SLGameUC3.Start_Game();

            SLGameUC4.Start_Game();

            SLGameUC5.Start_Game();
            
        }
    }
}
