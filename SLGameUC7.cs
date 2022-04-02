using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadder
{
    class SLGameUC7
    {
        public const int No_Play = 0;
        public const int Ladder = 1;
        public const int Snake = 2;
        public const int Winning_Position = 100;
        public static int Position_check = 0;
        public static int Start_Position = 0;
        //var
        int Player1DieCount = 0;
        int Player2DieCount = 0;
        int Player1position = 0;
        int Player2position = 0;

        public void Start_Game()
        {
            int Player_Position = 0;

            Random random = new Random();
            int DieRolled = random.Next(1, 7);
            Console.WriteLine(" Dice Rolled : {0} ", DieRolled);

            int NumberChoice = random.Next(0, 3);
            Console.WriteLine(" Dice Value : " + NumberChoice);

            {
                Console.WriteLine("Welcome to SnakeAndLadder program");
                Boolean player1IsPlaying = true;
                int Player1position = Start_Position, Player2position = Start_Position, dieRolledTimes = 0;

                while (Player1position != Winning_Position && Player2position != Winning_Position)
                {
                    DieRolled = random.Next(6) + 1;
                    dieRolledTimes++;
                    NumberChoice = random.Next(3) + 1;

                    switch (NumberChoice)
                    {
                        case 1:
                            if (player1IsPlaying)
                            {
                                Player1position += 0;
                                player1IsPlaying = false;
                            }
                            else
                            {
                                Player2position
                                += 0;
                                player1IsPlaying = true;
                            }
                            break;

                        case 2:
                            if (player1IsPlaying)
                            {

                                if (Player1position + DieRolled <= Winning_Position)
                                {

                                    Player1position += DieRolled;
                                    Console.WriteLine("Player 1 landed on a ladder");

                                }

                            }
                            else
                            {

                                if (Player2position + DieRolled <= Winning_Position)
                                {

                                    Player2position += DieRolled;
                                    Console.WriteLine("Player 2 landed on a ladder");

                                }

                            }

                            break;

                        case 3:
                            if (player1IsPlaying)
                            {

                                Player1position -= DieRolled;
                                player1IsPlaying = false;

                                if (Player1position < 0)
                                {

                                    Player1position = 0;

                                }

                                Console.WriteLine("Player 1 landed on a snake");

                            }
                            else
                            {

                                Player2position -= DieRolled;
                                player1IsPlaying = true;

                                if (Player2position < 0)
                                {

                                    Player2position = 0;

                                }

                                Console.WriteLine("Player 2 landed on a snake");

                            }
                            break;
                        default:
                            Console.WriteLine("Enter proper value");
                            break;

                    }
                    Console.WriteLine("Player 1 position  = " + Player1position);
                    Console.WriteLine("Player 2 position  = " + Player2position);

                }

                if (Player1position == 100)
                {

                    Console.WriteLine("Player 1 won the game!");

                }
                else
                {

                    Console.WriteLine("Player 2 won the game!");

                }
                Console.WriteLine("Dice was rolled " + dieRolledTimes + " to win the game");
            }

        }
    }
}