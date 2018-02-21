using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Center_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());

            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double dX1Y1 = Math.Sqrt(Math.Pow(x1,2)+Math.Pow(y1,2));
            double dX2Y2 = Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2));

            if (ClosetPoint(dX1Y1,dX2Y2))
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }

        static bool ClosetPoint (double dX1Y1, double dX2Y2)
        {
            if (dX1Y1 <= dX2Y2)
            {
                return true;
            }
            else return false;
        }
    }
}
