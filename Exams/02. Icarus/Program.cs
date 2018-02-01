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
            string commands = "";
            int demage = 1;

            while (true)
            {
                commands = Console.ReadLine();

                if (commands == "Supernova")
                {
                    break;
                }

                var comandsArr = commands
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var direction = comandsArr[0];
                var steps = int.Parse(comandsArr[1]);

                if (direction == "left")
                {
                    while (steps-- > 0)
                    {
                        startPosition -= 1;
                        if(startPosition<0)
                        {
                            startPosition = inputArr.Length - 1;
                            demage++;
                        }
                        inputArr[startPosition] -= demage;
                    }
                }

                else if(direction=="right")
                {
                    while(steps-->0)
                    {
                        startPosition += 1;
                        if(startPosition>inputArr.Length-1)
                        {
                            startPosition = 0;
                            demage++;
                        }
                        inputArr[startPosition] -= demage;
                    }
                }
            }
            Console.WriteLine(string.Join(" ",inputArr));
        }
    }
}
