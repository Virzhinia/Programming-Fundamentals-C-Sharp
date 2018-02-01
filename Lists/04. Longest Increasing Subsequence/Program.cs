using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Longest_Increasing_Subsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var firstNum = numbers[0];
            var currentNum = 0;
            if (numbers.Count==1)
            {
                Console.WriteLine($"{numbers[0]}");
            }

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i]>firstNum)
                {
                    currentNum = numbers[i];
                }
                firstNum = numbers[i];
            }
        }
    }
}
