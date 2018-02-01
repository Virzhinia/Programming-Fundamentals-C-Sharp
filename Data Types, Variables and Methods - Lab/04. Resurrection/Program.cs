using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Resurrection
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            while (n>0)
            {
                n--;

                int bodyLength = int.Parse(Console.ReadLine());
                decimal bodywidth = decimal.Parse(Console.ReadLine());
                int wingLength = int.Parse(Console.ReadLine());

                var totalYears = (decimal)Math.Pow(bodyLength, 2) * (bodywidth + 2 * wingLength);

                Console.WriteLine(totalYears);
            }
        }
    }
}
