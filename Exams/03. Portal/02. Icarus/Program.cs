using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Icarus
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int startPosition = int.Parse(Console.ReadLine());

            string[] command;

            while (true)
            {
                command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "Supernova")
                {
                    break;
                }

                var directions = command[0];
                var steps = int.Parse(command[1]);

                if (directions == "left")
                {
                    //MoveLeft(inputLine, steps, startPosition);

                    if (startPosition - steps >= 0)
                    {
                        for (int i = startPosition - 1; i >= 0; i--)
                        {
                            inputLine[i] -= 1;
                        }
                        startPosition -= steps;
                    }
                    else
                    {
                        var stepsInArray = 0;
                        for (int i = startPosition - 1; i >=0; i--)
                        {
                            inputLine[i] -= 1;
                            stepsInArray++;
                        }
                        var stepsFromEnd = steps - stepsInArray;

                        for (int i = inputLine.Length-1; i > stepsFromEnd; i--)
                        {
                            inputLine[i] -= 1;
                        }
                        startPosition = stepsFromEnd + 1;
                    }
                }

                else
                {
                    // MoveRight(inputLine, steps, startPosition);
                    if (startPosition + steps < inputLine.Length)
                    {
                        for (int i = startPosition + 1; i <= startPosition + steps; i++)
                        {
                            inputLine[i] -= 1;
                        }
                        startPosition += steps;
                    }
                    else
                    {
                        var stepsInArray = 0;
                        for (int i = startPosition + 1; i < inputLine.Length; i++)
                        {
                            inputLine[i] -= 1;
                            stepsInArray++;
                        }
                        var stepsFromBegining = steps - stepsInArray;

                        for (int i = 0; i < stepsFromBegining; i++)
                        {
                            inputLine[i] -= 1;
                        }
                        startPosition = stepsFromBegining - 1;

                    }

                }
            }

            Console.WriteLine(string.Join(" ", inputLine));
        }

        // public static int MoveRight(int[] inputLine, int steps, int startPosition)
        // {
        //     if (startPosition + steps < inputLine.Length)
        //     {
        //         for (int i = startPosition; i <= startPosition + steps; i++)
        //         {
        //             inputLine[i] -= 1;
        //         }
        //         startPosition += steps;
        //     }
        //     else
        //     {
        //
        //     }
        //     return startPosition;
        // }
        //
        // public static int MoveLeft(int[] inputLine, int steps, int startPosition)
        // {
        //     if (startPosition + steps > 0)
        //     {
        //         for (int i = startPosition; i >= startPosition - steps; i--)
        //         {
        //             inputLine[i] -= 1;
        //         }
        //         startPosition -= steps;
        //     }
        //     else
        //     {
        //
        //     }
        //
        //     return startPosition;
        // }
    }
}
