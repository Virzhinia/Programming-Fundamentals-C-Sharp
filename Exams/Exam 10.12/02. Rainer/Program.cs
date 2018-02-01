using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Rainer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int index = input[input.Count - 1];
            List<int> secondList = new List<int>();

            for (int i = 0; i < input.Count - 1; i++)
            {
                secondList.Add(input[i]);
            }

            int steps = 0;

            while (true)
            {
                if (secondList[index] == 0 )
                {
                    break;
                }

                for (int i = 0; i < secondList.Count; i++)
                {
                    secondList[i] -= 1;

                    if (secondList[i] == 0 && secondList[i] != secondList[index])
                    {
                        secondList[i] = input[i];
                        break;
                    }

                }

                if (secondList[index] == 0)
                {
                    break;
                }


                index = int.Parse(Console.ReadLine());
                steps++;

            }

            Console.WriteLine(string.Join(" ", secondList));
            Console.WriteLine(steps);
        }
    }
}
