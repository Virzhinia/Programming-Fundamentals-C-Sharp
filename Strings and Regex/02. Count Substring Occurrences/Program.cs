using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Count_Substring_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            string word = Console.ReadLine().ToLower();
            int pos = text.IndexOf(word);
            int count = 0;

            while (pos!=-1)
            {
                count++;
                pos = text.IndexOf(word, pos + 1);

            }
            Console.WriteLine(count);
        }
    }
}
