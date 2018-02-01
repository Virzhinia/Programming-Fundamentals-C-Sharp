namespace _01.Reverse_String
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToArray();
            var reverseInput = input.Reverse().ToArray();

            Console.WriteLine(reverseInput);
        }
    }
}
