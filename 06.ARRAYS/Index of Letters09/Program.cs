using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Index_of_Letters09
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[26];
            char[] input = Console.ReadLine().ToLower().ToCharArray();

            for (char i = 'a'; i <= 'z'; i++)
            {
                alphabet[i- 'a'] = i;
            }

            for (int i = 0; i < input.Length; i++)
            {
            Console.WriteLine($"{input[i]} -> {Array.IndexOf(alphabet, input[i])}");
            }
        }
    }
}
