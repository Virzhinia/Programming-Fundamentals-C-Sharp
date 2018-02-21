using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Hornet_Wings
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //wing flaps
            decimal m = decimal.Parse(Console.ReadLine());//distance for 1000 wing flaps
            int p = int.Parse(Console.ReadLine());//endurance of the hornet
            decimal distance = (decimal)(n / 1000) * m;
            int hornetPlaps = (n / p) * 5;
            var secper100 = n / 100;
            int seconds = hornetPlaps + secper100;

            Console.WriteLine($"{distance:F2} m.");
            Console.WriteLine($"{seconds} s.");

        }
    }
}
