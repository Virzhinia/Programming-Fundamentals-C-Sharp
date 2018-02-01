using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Extract_Middle_1__2_or_3_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int n = arr.Length;
            if(n==1)
            {
                Console.WriteLine(arr[0]);
            }
            else if(n%2==0)
            {

            }
            else
            {

            }

        }
    }
}
