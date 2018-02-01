using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Types__Variables_and_Methods___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstnum = int.Parse(Console.ReadLine());
            uint secondnum = uint.Parse(Console.ReadLine());
            int thirdnum = int.Parse(Console.ReadLine());
            long forthnum = long.Parse(Console.ReadLine());

            Console.WriteLine($"{firstnum} {secondnum} {thirdnum} {forthnum}");
        }
    }
}
