using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Largest_N_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numList = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int num = int.Parse(Console.ReadLine());

           var decendNums= numList.OrderByDescending(x=>x).ToList();

            for (int i = 0; i < num; i++)
            {
                Console.Write($"{decendNums[i]} ");
            }

            Console.WriteLine();
        }
    }
}
