using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] text = Console.ReadLine();
            Random rnd = new Random();
            for (int i = 0; i < text.Length; i++)
            {
                int index = rnd.Next(0, text.Length);
                string rem = text[index];
                text[index] = text[];
            }

        }
    }
}
