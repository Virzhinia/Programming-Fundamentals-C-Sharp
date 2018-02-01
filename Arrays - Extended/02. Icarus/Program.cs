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
            int[] inputArr = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int startPosition = int.Parse(Console.ReadLine());

            int demage = 1;


            while (true)
            {
                string[] command = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (command[0] == "Supernova")
                {
                    break;
                }

                string direction = command[0];
                int steps = int.Parse(command[1]);

                if (direction == "left")
                {
                    //MoveAndFindLeft(inputArr, steps, startPosition);

                    while (steps-- > 0)
                    {
                        startPosition -= 1;
                        if (startPosition < 0)
                        {
                            startPosition = inputArr.Length - 1;
                            demage++;
                        }

                        inputArr[startPosition] -= demage;

                    }

                }

                else if (direction == "right")
                {
                    //MoveAndFindRight(inputArr, steps, startPosition);

                    while (steps-- > 0)
                    {
                        startPosition += 1;

                        if (startPosition > inputArr.Length - 1)
                        {
                            startPosition = 0;
                            demage++;
                        }

                        inputArr[startPosition] -= demage;
                    }
                }

            }
            Console.WriteLine(string.Join(" ", inputArr));

        }

    }
}
