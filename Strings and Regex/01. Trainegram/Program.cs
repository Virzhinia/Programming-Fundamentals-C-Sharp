using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _01.Trainegram
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^(<\[[^A-Za-z0-9\n]*]\.)(\.\[[A-Za-z0-9]*]\.)*$";

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Traincode!")
                {
                    break;
                }

                if (Regex.IsMatch(input,pattern))
                { 
                    Console.WriteLine(input);
                }
            }
        }
    }
}
