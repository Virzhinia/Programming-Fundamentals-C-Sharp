using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sum_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int largegLength = Math.Max(arr1.Length, arr2.Length);

            for (int i = 0; i < largegLength; i++)
            {
                int firstValue = arr1[i % arr1.Length];
                int secondValue = arr2[i % arr2.Length];
                Console.Write("{0} ", firstValue + secondValue);
            }
        }
    }
}
