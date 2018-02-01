using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Largest_3_Nums
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            nums = nums.OrderByDescending(n => n).ToList();
            if (nums.Count >= 3)
            {
                Console.WriteLine(string.Join(" ",nums.Take(3)));
              // for (int i = 0; i < 3; i++)
              // {
              //     Console.Write($"{nums[i]} ");
              // }
            }
            else
            {
                Console.Write(string.Join(" ",nums));
            }
            Console.WriteLine();
        }
    }
}
