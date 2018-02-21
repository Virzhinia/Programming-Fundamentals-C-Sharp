using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Smallest_Element_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            int small = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if(small>arr[i])
                {
                    small = arr[i];
                }

            }

            Console.WriteLine(small);
        }
    }
}
