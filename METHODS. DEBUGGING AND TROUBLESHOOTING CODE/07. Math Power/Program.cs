using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Math_Power
{
    class Program
    {
        static double RaiseToPower (double num, int power)
        {
            double result =Math.Pow(num, power);
            return result;
        }
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            double result = RaiseToPower(num,power);
            Console.WriteLine(result);
        }
    }
}
