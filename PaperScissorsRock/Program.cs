using System;
using System.Collections.Generic;

namespace PaperScissorsRock
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] moves = new string[] {"paper", "scissors", "rock"};

            Random rnd = new Random();
            
            int rounds1 = 0;
            int rounds2 = 0;

            List<bool> logGame = new List<bool>();

            while (rounds1 < 2 && rounds2 < 2)
            {
                int turns1 = 0;
                int turns2 = 0;

                List<bool> logRound = new List<bool>();

                while (turns1 < 2 && turns2 < 2)
                {
                    Console.WriteLine("Paper, Scissors, Rock!!!");
                    int movePlayer = GetMove();
                    int moveComp = rnd.Next(3);
                    switch (WhoWins(movePlayer, moveComp))
                    {
                        case 0:
                            Console.WriteLine("Your {0} drew with the computer's {1}", moves[movePlayer], moves[moveComp]);
                            Console.WriteLine();
                            break;
                        case 1:
                            Console.WriteLine("Your {0} won to the computer's {1}", moves[movePlayer], moves[moveComp]);
                            Console.WriteLine();
                            turns1 += 1;
                            logRound.Add(true);
                            break;
                        case 2:
                            Console.WriteLine("Your {0} lost to the computer's {1}", moves[movePlayer], moves[moveComp]);
                            Console.WriteLine();
                            turns2 += 1;
                            logRound.Add(false);
                            break;
                    }
                }

                if (turns1 > turns2)
                {
                    rounds1 += 1;
                    logGame.Add(true);
                } else
                {
                    rounds2 += 1;
                    logGame.Add(false);
                }
            }

            Console.WriteLine("How did the rounds go?");

            foreach (bool result in logGame)
            {
                Console.WriteLine("Round: {0}", result ? "Won" : "Lost");
            }

            Console.WriteLine();

            if (logGame[logGame.Count - 1])
            {
                Console.WriteLine("Congrats you beat the computer at bad game");
            } else
            {
                Console.WriteLine("How did you lose so spectacularly my dude???!???/");
            }

            while (true)
            {
                Console.ReadKey(true);
            }
        }

        static int GetMove()
        {
            while (true)
            {
                string input = Console.ReadLine();
                switch (input.ToLower())
                {
                    case "paper":
                        return 0;
                    case "scissors":
                        return 1;
                    case "rock":
                        return 2;
                    default:
                        Console.WriteLine("Please try again with one of: Paper, Scissors or Rock (case insensitive)");
                        break;
                }
            }
        }

        static int WhoWins(int movePlayer, int moveComp)
        {
            if (movePlayer == moveComp) { return 0; }
            if (movePlayer - moveComp == 1 || moveComp - movePlayer == 2) { return 1; }
            return 2;
        }
    }
}