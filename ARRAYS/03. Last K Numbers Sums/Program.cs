using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Last_K_Numbers_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            long k = long.Parse(Console.ReadLine());
            
            long[] arr = new long[n];
            arr [0] = 1;
            for (long i = 0; i < n; i++)
            {
                if (i>=k)
                {
                    for (long j = i-k; j < i; j++)
                    {
                    arr[i] += arr[j];
                    }
                }
                else
                {
                    for (long j = 0; j < i; j++)
                    {
                        arr[i] += arr[j];
                    }
                }
            }
            Console.WriteLine(string.Join(" ", arr));
            Console.WriteLine();
        }
    }
}
