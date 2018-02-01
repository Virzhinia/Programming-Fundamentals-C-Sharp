using System;
using System.Collections.Generic;
using System.Linq;

namespace _13.Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            char input = char.Parse(Console.ReadLine());

            if (input == 'a' || input == 'o' || input == 'u' || input == 'e' ||
                input == 'i' || input == 'y')
            {
                Console.WriteLine("vowel");
            }
            else if (char.IsNumber(input))
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
