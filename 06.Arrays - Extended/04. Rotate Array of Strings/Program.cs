using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Rotate_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            string[] secondArr = new string[arr.Length];
            secondArr[0] = arr[arr.Length-1];

            for (int i = 1; i <secondArr.Length; i++)
            {
                secondArr[i] = arr[i - 1];
            }
         
                Console.Write(string.Join(" ",secondArr));
            
        }
    }
}
