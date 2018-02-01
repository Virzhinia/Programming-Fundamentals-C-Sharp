using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            var ignore = Console.ReadLine().Split(new char[] { ',', ' ' },StringSplitOptions.RemoveEmptyEntries);
            string inputText = Console.ReadLine();

            foreach (var i in ignore)
            {
                string newWord = new string('*', i.Length);
                inputText= inputText.Replace(i,newWord);
            }

            Console.WriteLine(inputText);
        }
    }
}
