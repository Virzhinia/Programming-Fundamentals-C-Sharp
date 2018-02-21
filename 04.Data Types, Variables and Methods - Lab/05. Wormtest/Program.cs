using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Wormtest
{
    class Program
    {
        static void Main(string[] args)
        {
            int lengthmeters = int.Parse(Console.ReadLine());
            double widthCent = double.Parse(Console.ReadLine());
            double lengthCent = lengthmeters * 100;
            double reminder = lengthCent % widthCent;

            if(reminder==0 || widthCent==0 || lengthCent==0)
            {
                Console.WriteLine($"{(lengthCent*widthCent):F2}");
            }

            else
            {
                double devide = (lengthCent / widthCent) * 100;
                Console.WriteLine($"{devide:F2}%");
            }
        }
    }
}
