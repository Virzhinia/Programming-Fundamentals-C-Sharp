using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());
            var count = 0;
            var orign = n;

            var targetpoke = n % m;
            var targetCount = n / m;

            while(n>=m)
            {
                n -= m;
                count++;

                if(2*n==orign && y>0)
                {
                    n /= y;
                }

            }

            Console.WriteLine(n);
            Console.WriteLine(count);


        }
    }
}
