using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new char[] { ' ', '.', ',', '!', '?', ':' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            var listOfWords = new List<string>();

            foreach (var item in input)
            {
                var lefthalf = item.Substring(0, item.Length / 2);
                var reversedhalf = new string(item.Reverse().ToArray());
                var righthalf = reversedhalf.Substring(0, item.Length / 2);

                if (lefthalf == righthalf)
                {
                    listOfWords.Add(item);
                }
            }

            Console.WriteLine(string.Join(", ", listOfWords.Distinct().OrderBy(w => w)));
        }
    }
}
