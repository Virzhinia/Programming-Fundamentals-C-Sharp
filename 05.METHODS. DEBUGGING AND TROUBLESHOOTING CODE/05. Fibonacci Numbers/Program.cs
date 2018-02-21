using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Fibonacci_Numbers
{

class Program
    {
        public static int Fibonacci(int n)
        {
            int a = 0;
            int b = 1;

            for (int i = 0; i <= n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(Fibonacci(n));
        }
        }
    }