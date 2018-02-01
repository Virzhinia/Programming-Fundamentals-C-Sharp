using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                  .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                  .Select(int.Parse)
                  .ToArray();

            if (numbers.Length < 1)
            {
                return;
            }
            else if (numbers.Length == 1)
            {
                Console.WriteLine(numbers[0]);
                return;
            }

            int length = 1;
            int maxLength = 1;
            int endIndex = 0;
            int maxEndIndex = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] + 1 <= numbers[i + 1])
                {
                    length++;
                    endIndex = i + 1;
                }
                else
                {
                    if (length > maxLength)
                    {
                        maxEndIndex = i;
                        maxLength = length;
                    }

                    length = 1;
                }
            }

            if (length > maxLength)
            {
                maxEndIndex = endIndex;
                maxLength = length;
            }

            for (int i = maxEndIndex - maxLength + 1; i <= maxEndIndex; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
