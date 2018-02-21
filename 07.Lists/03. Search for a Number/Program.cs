using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Search_for_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> number = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] items = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            if(YesNo(number,items))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
        static bool YesNo (List <int> number, int [] items)
        {
            bool yesNo = false;
            var result = number.Take(items[0]).ToList();
            result.RemoveRange(0,items[1]);

            foreach (var num in result)
            {
                if (num == items[2])
                    yesNo = true;
            }
            return yesNo;

        }
    }
}
