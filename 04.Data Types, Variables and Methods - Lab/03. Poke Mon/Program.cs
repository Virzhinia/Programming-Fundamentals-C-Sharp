using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int count = 0;
            int origN = n;

            while(n>=m)
            {
                count++;
                n = n - m;
                if(origN==n*2 && y>0)
                {
                    n = n / y;
                }
            }

            Console.WriteLine(n);
            Console.WriteLine(count);

        }
    }
}
