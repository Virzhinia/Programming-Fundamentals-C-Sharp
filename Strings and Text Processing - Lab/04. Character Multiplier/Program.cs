using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] {' '});
            var first = input[0];
            var second = input[1];
            var sum = 0;

            Console.WriteLine(GetSumCharacterMultiplier(first, second));

        }

        private static int GetSumCharacterMultiplier(string first, string second)
        {
            var result = 0;
            List<int> firstList = new List<int>();
            List<int> secondList = new List<int>();

            foreach (var ch in first)
            {
                firstList.Add((int)ch);
            }

            foreach (var ch in second)
            {
                secondList.Add((int)ch);
            }

            for (int i = 0; i < Math.Min(firstList.Count,secondList.Count); i++)
            {
                result += firstList[i] * secondList[i];
            }

            if (firstList.Count!=secondList.Count)
            {
                if (firstList.Count > secondList.Count)
                {
                    for (int i = firstList.Count - 1; i >=secondList.Count ; i--)
                    {
                        result += firstList[i];
                    }
                }
                else
                {
                    for (int i = secondList.Count - 1; i >= firstList.Count; i--)
                    {
                        result += secondList[i];
                    }
                }
            }

            return result;
        }
    }
}
