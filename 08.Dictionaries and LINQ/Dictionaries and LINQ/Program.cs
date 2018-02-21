using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries_and_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToLower().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> words = new Dictionary<string, int>();

            foreach (var item in input)
            {
                if (words.ContainsKey(item))
                {
                    words[item]++;
                }
                else
                {
                    words[item] = 1;
                }
            }

            var oddCount = new List<string>();
            foreach (var pair in words)
            {
                if (pair.Value % 2 == 1)
                {
                    oddCount.Add(pair.Key);
                }
            }

            Console.WriteLine(string.Join(", ",oddCount));
        }
    }
}
