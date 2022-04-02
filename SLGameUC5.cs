﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadder
{
    class SLGameUC5
    {
                // UC 5
        public const int No_Play = 0;
        public const int Ladder = 1;
        public const int Snake = 2;

        public static void Start_Game()
        {
            int Player_Position = 0;

            while (Player_Position != 100)

            {
                Random random = new Random();
                int DieRolled = random.Next(1, 7);
                Console.WriteLine(" Dice Rolled : {0} ", DieRolled);

                int NumberChoice = random.Next(0, 3);
                Console.WriteLine(" Dice Value : " + NumberChoice);

                switch (NumberChoice)
                {
                    case No_Play:
                        Console.WriteLine(" No Play");
                        break;
                    case Ladder:
                        Player_Position += DieRolled;
                        Console.WriteLine(" Player Got Ladder! Congrats! : " + Player_Position);
                        
                        if (Player_Position > 100)
                        {
                            Player_Position = Player_Position - Player_Position; //more than 100 it come back to prev pos
                        }
                        break;
                    case Snake:
                        Player_Position -= DieRolled;
                        Console.WriteLine(" Snake Attacks Player! Oops..Better Luck Next Time!" + Player_Position);
                        if (Player_Position < 0)
                        {
                            Player_Position = 0;

                        }
                        break;
                    default:
                        Console.WriteLine("Oohh NoO..Invalid Option..");
                        break;
                }
            }
            Console.WriteLine("Wowww... YOU WON!");
        }
    }
}
