using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.Melrah_Shake
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = Console.ReadLine();

            while(pattern.Length>0)
            {
                int firstindex = input.IndexOf(pattern);
                int lastIndex = input.LastIndexOf(pattern);
                if (firstindex >= 0 && lastIndex >= 0 && firstindex != lastIndex)
                {
                    input = input.Remove(lastIndex, pattern.Length);
                    input = input.Remove(firstindex, pattern.Length);
                    Console.WriteLine("Shaked it.");
                }
                else
                {
                    break;
                }

                pattern = pattern.Remove(pattern.Length / 2,1);
            }

                Console.WriteLine("No shake.");
                Console.WriteLine(input);
        }
    }
}
