using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Sum__Min__Max__Average
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var list = new List<int>();

            for (int i = 0; i < n; i++)
            {
                list.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine($"Sum = {list.Sum()}");
            Console.WriteLine($"Min = {list.Min()}");
            Console.WriteLine($"Max = {list.Max()}");
            Console.WriteLine($"Average = {list.Average()}");

        }
    }
}
