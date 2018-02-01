using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _09.Match_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";
            var numbers = Console.ReadLine();
            var isNumber = Regex.Matches(numbers, pattern);

            foreach (Match item in isNumber)
            {
                Console.Write(item.Value+" ");
            }
            Console.WriteLine();
        }
    }
}
