using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _07.Match_Hexadecimal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(0x)*[A-F0-9]+\b";
            var input = Console.ReadLine();
            var hexaNums = Regex.Matches(input, pattern);

            foreach (Match item in hexaNums)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
