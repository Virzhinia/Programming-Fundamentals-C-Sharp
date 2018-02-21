using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Sum_Reversed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            List<int> reversedNums = new List<int>();

            for (int i = 0; i < input.Count; i++)
            {
                char[] element = input[i].ToCharArray();
                char[] reversed = element.Reverse().ToArray();
                reversedNums.Add(int.Parse(string.Join("", reversed)));
            }

            Console.WriteLine(reversedNums.Sum());
        }
    }
}
