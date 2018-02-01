using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            var fieldSize = int.Parse(Console.ReadLine());
            var field = new int[fieldSize];
            var bugIndexes = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            for (int i = 0; i < field.Length; i++)
            {
                for (int j = 0; j < bugIndexes.Length; j++)
                {
                    if (i == bugIndexes[j])
                    {
                        field[i] = 1;
                    }

                }
            }

            var command = String.Empty;
            while ((command = Console.ReadLine()) != "end")
            {
                var commandArgs = command.Split().ToArray();
                var index = int.Parse(commandArgs[0]);
                var directions = commandArgs[1];
                var flightSpan = int.Parse(commandArgs[2]);

                if (index < 0 || index > field.Length - 1 || field[index] == 0
                    || flightSpan == 0)
                {
                    continue;
                }

                field[index] = 0;
                if (directions == "right")
                {
                    FlyRight(field, index, flightSpan);
                }
                else if (directions == "left")
                {
                    FlyLeft(field, index, flightSpan);
                }

            }
                Console.WriteLine(string.Join(" ",field));
        }

        private static void FlyLeft(int[] field, int index, int flightSpan)
        {
            for (int i = 1; i <= index + 1; i++)
            {
                var flightDistance = i * flightSpan;
                if (index - flightDistance < 0)
                {
                    break;
                }
                if (field[index - flightDistance] == 0)
                {
                    field[index - flightDistance] = 1;
                    break;
                }
            }
        }

        private static void FlyRight(int[] field, int index, int flightSpan)
        {
            for (int i = 0; i < field.Length - index; i++)
            {
                var flightDistance = i * flightSpan;

                if (index + flightDistance > field.Length - 1)
                {
                    break;
                }

                if (field[index + flightDistance] == 0)
                {
                    field[index + flightDistance] = 1;
                    break;
                }
            }
        }
    }
}
