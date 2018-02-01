using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_and_Regex
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] inputch = input.ToCharArray();

            Console.WriteLine(String.Join("",inputch.Reverse()));
        }
    }
}
