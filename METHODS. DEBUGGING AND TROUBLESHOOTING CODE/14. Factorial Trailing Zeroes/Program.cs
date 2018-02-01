using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _14.Factorial_Trailing_Zeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            BigInteger factorial = 1;
            int zeros = 0;

            for (int i = 1; i <= n; i++)
            {
                factorial = factorial * i;
            }

            for (int i = 1; i <= factorial; i++)
            {
                if (factorial % 10 == 0)
                {
                    zeros++;
                factorial = factorial / 10;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(zeros);
        }
    }
}
