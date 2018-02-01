using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            if (type == "int")
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                int max = GetMax(first, second);
                Console.WriteLine(max);
            }

            else if (type == "char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());
                char max = NewMethod(first, second);
                Console.WriteLine(max);
            }

            else if (type == "string")
            {
                var first = Console.ReadLine();
                var second = Console.ReadLine();
                string max = GetMax(first, second);
                Console.WriteLine(max);

            }
        }

         static string GetMax(string first, string second)
        {
            if (first.CompareTo(second)>=0)
            {
                return first;
            }
            else
            {
                return second;
            }
        }

        static char NewMethod(char first, char second)
        {
            if(first>=second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }

        static int GetMax(int first, int second)
        {
            if (first>=second)
            {
                return (first);
            }
            else
            {
                return (second);
            }
        }
    }
}
