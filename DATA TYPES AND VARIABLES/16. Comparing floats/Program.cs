using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Comparing_floats
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            bool deference = true;

            if (Math.Abs(a-b)<= 0.000001)
            {
                Console.WriteLine(deference);
            }
            else
            {
                deference = false;
                Console.WriteLine(deference);
            }

        }
    }
}
