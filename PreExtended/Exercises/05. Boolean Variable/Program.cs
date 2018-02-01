using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Boolean_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool yesOrno = Convert.ToBoolean(input);

            if (yesOrno) Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }
    }
}
