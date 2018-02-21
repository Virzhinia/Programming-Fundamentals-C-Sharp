using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Count_of_Odd_Numbers_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int oddCount = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i]%2!=0)
                {
                    oddCount++;
                }
            }

            Console.WriteLine(oddCount);
        }
    }
}
