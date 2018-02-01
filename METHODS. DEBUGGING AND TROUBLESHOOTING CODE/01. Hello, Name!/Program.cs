using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Hello__Name_
{
    class Program
    {
        static void PrintName (string name)
        {
            Console.WriteLine($"Hello, {name}!");    
        }
        static void Main(string[] args)
        {
            string name1 = Console.ReadLine();
            PrintName(name1);
        }
    }
}
