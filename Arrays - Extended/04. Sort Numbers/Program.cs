using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> numList = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(decimal.Parse)
                .ToList();

            numList.Sort();

            Console.WriteLine(string.Join(" <= ",numList));

        }
    }
}
