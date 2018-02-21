using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] { ',', '?', '!', '.', ' ' },StringSplitOptions.RemoveEmptyEntries);
            var listOfWords = new List<string>();

            foreach (var word in input)
            {
                var lefthalf = word.Substring(0, word.Length / 2);
                var reversedhalf = new string(word.Reverse().ToArray());
                var righthalf = reversedhalf.Substring(0, word.Length / 2);

                if(lefthalf==righthalf)
                {
                    listOfWords.Add(word);
                }

            }
                Console.WriteLine(string.Join(", ",listOfWords.Distinct().OrderBy(w=>w)));
        }
    }
}
