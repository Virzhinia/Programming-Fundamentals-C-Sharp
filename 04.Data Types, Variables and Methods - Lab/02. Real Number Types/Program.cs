using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Real_Number_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n < 16)
            {
                double num = double.Parse(Console.ReadLine());
                Console.WriteLine(num);
            }
            else if(n<29)
            {
                decimal num = decimal.Parse(Console.ReadLine());
                Console.WriteLine(num);
            }
        }
    }
}
