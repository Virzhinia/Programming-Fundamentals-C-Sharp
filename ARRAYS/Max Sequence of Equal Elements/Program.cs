using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int count = 1;
            int maxCount = 0;
            int numbers = 0;

            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                if(inputArray[i+1]== inputArray[i])
                {
                    count++;
                    if(count>maxCount)
                    {
                        maxCount = count;
                        numbers = inputArray[i];
                    }
                }
                else
                {
                    count = 1;
                }
            }

            if (maxCount==0)
            {
                Console.WriteLine(inputArray[0]);
            }
            else
            {
                for (int i = 0; i < maxCount; i++)
                {
                    Console.Write($"{numbers} ");
                }
            }
            Console.WriteLine();
        }
    }
}
