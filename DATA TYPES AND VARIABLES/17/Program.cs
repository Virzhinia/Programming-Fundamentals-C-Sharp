using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17
{
    class Program
    {
        static void Main(string[] args)
        {
            int startChar= int.Parse(Console.ReadLine());
            int stoptChar = int.Parse(Console.ReadLine());
            for (int i = startChar ; i <= stoptChar; i++)
            {
                Console.Write(Convert.ToChar(i)+" ");
            }
            Console.WriteLine();
        }
    }
}
