using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                bool playAgain = true;
                while (playAgain)
                {
                    int PlayerScore = 0;
                    int CpuScore = 0;

                    Console.WriteLine("############################################");
                    Console.WriteLine("#                 WELCOME                  #");
                    Console.WriteLine("#                    TO                    #");
                    Console.WriteLine("#                  GAME!!                  #");
                    Console.WriteLine("############################################ \n");

                    while (PlayerScore < 3 && CpuScore < 3)
                    {
                        Console.Write("Choose between Rock, Scissor, Pensil, Paper:   ");
                        string player = Console.ReadLine().ToLower();

                        Random _random = new Random();
                        int RandomInt = _random.Next(1, 5);

                        string CpuInput = string.Empty;
                        switch (RandomInt)
                        {
                            case 1:
                                CpuInput = "paper";
                                Console.WriteLine($"Computer choose {CpuInput}");
                                if (player == CpuInput)
                                {
                                    Console.WriteLine("Draw! \n\n");
                                }
                                else if (player == "scissor")
                                {
                                    Console.WriteLine("Player won! \n\n");
                                    ++PlayerScore;
                                }
                                else if (player == "pensil")
                                {
                                    Console.WriteLine("Player won! \n\n");
                                    ++PlayerScore;
                                }
                                else if (player == "rock")
                                {
                                    Console.WriteLine("Player won! \n\n");
                                    ++PlayerScore;
                                }
                                break;
                            case 2:
                                CpuInput = "scissor";
                                Console.WriteLine($"Computer choose {CpuInput}");
                                if (player == CpuInput)
                                {
                                    Console.WriteLine("Draw! \n\n");
                                }
                                else if (player == "paper")
                                {
                                    Console.WriteLine("Computer won! \n\n");
                                    ++CpuScore;
                                }
                                else if (player == "pensil")
                                {
                                    Console.WriteLine("Computer won! \n\n");
                                    ++CpuScore;
                                }
                                else if (player == "rock")
                                {
                                    Console.WriteLine("Player won! \n\n");
                                    ++PlayerScore;
                                }
                                break;
                            case 3:
                                CpuInput = "rock";
                                Console.WriteLine($"Computer choose {CpuInput}");
                                if (player == CpuInput)
                                {
                                    Console.WriteLine("Draw! \n\n");
                                }
                                else if (player == "scissor")
                                {
                                    Console.WriteLine("Computer won! \n\n");
                                    ++CpuScore;
                                }
                                else if (player == "pensil")
                                {
                                    Console.WriteLine("Computer won! \n\n");
                                    ++CpuScore;
                                }
                                else if (player == "paper")
                                {
                                    Console.WriteLine("Player won! \n\n");
                                    ++PlayerScore;
                                }
                                break;
                            case 4:
                                CpuInput = "pensil";
                                Console.WriteLine($"Computer choose {CpuInput}");
                                if (player == CpuInput)
                                {
                                    Console.WriteLine("Draw! \n\n");
                                }
                                else if (player == "scissor")
                                {
                                    Console.WriteLine("player won! \n\n");
                                    ++PlayerScore;
                                }
                                else if (player == "rock")
                                {
                                    Console.WriteLine("Player won! \n\n");
                                    ++PlayerScore;
                                }
                                else if (player == "paper")
                                {
                                    Console.WriteLine("Computer won! \n\n");
                                    ++CpuScore;
                                }
                                break;
                            default:

                                break;
                        }

                        Console.WriteLine($"\n\nSCORES:\tPLAYER:\t{PlayerScore}\tCPU:\t{CpuScore}");
                    }

                    if (PlayerScore == 3)
                    {
                        Console.WriteLine("Player won!!");
                    }
                    else if (CpuScore == 3)
                    {
                        Console.WriteLine("Computer won!!");
                    }
                    else
                    {
                        // nothing
                    }

                    Console.WriteLine("Do you want to play again? (y/n)");
                    string answer = Console.ReadLine();
                    if (answer == "y")
                    {
                        playAgain = true;
                        Console.Clear();
                    }
                    else if (answer == "n")
                    {
                        playAgain = false;
                    }
                    else
                    {
                        // nothing
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
