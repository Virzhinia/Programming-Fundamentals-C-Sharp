using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split(' ').ToArray();
            string[] secondArray = Console.ReadLine().Split(' ').ToArray();
            int shorterArray = Math.Min(firstArray.Length - 1, secondArray.Length - 1);
            int longestEquals = 0;

            for (int i = 0; i <= shorterArray; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    longestEquals++;
                }
                else if (firstArray[i] != secondArray[i])
                {
                    longestEquals = 0;

                    string firstArray1 = string.Join(" ", firstArray.Reverse());
                    string secondArray1 = string.Join(" ", secondArray.Reverse());

                    string[] firstArrayBackwards = firstArray1.Split(' ').ToArray();
                    string[] secondArrayBackwards = secondArray1.Split(' ').ToArray();


                    for (int j = 0; j <= Math.Min(firstArrayBackwards.Length - 1, secondArrayBackwards.Length - 1); j++)
                    {
                        if (firstArrayBackwards[j] == secondArrayBackwards[j])
                        {
                            longestEquals++;
                        }
                    }
                    break;
                }
            }
            Console.WriteLine(longestEquals);
        }
    }
}
