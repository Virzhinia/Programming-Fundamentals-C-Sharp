using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA_TYPES_AND_VARIABLES
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            decimal num = ;

            for (int i = 0; i < numbers; i++)
            {
                num = decimal.Parse(Console.ReadLine());
                num += num;
            }
            Console.WriteLine(num);
        }
    }
}
