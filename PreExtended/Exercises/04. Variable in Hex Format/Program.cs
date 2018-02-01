using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Variable_in_Hex_Format
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var hexa = Convert.ToInt32(input, 16);

            Console.WriteLine(hexa);
        }
    }
}
