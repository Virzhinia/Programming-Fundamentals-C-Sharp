using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Printing_Triangle
{
    class Program
    {
        static void Triangle (int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i+ " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int line = 1; line <= n; line++)
            {
                Triangle(1, line);
            }
            for (int line2 = n - 1;  line2 >=1 ; line2 --)
            {
                Triangle(1,line2);
            }
        }
    }
}
