using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _03.Phoenix_Grid
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^([^\s_]{3})(\.[^\s_]{3})*$";
            string input = "";

            while (true)
            {
                input = Console.ReadLine();

                if (input == "ReadMe")
                {
                    break;
                }

                var matches = Regex.Match(input, pattern);

                if (matches.Success)
                {
                    if (isPalindrom(input))
                    {
                        Console.WriteLine("YES");
                    }
                    else
                    {
                        Console.WriteLine("NO");
                    }
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
        }

        static bool isPalindrom(string word)
        {
            for (int i = 0; i < word.Length / 2; i++)
            {
                if (word[i] != word[word.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
