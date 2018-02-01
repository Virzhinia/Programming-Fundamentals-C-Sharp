using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                double x1 = double.Parse(Console.ReadLine());
                double y1 = double.Parse(Console.ReadLine());
                double x2 = double.Parse(Console.ReadLine());
                double y2 = double.Parse(Console.ReadLine());
                double x3 = double.Parse(Console.ReadLine());
                double y3 = double.Parse(Console.ReadLine());
                double x4 = double.Parse(Console.ReadLine());
                double y4 = double.Parse(Console.ReadLine());
                double firstPairPointDistance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
                double secondPairPointDistance = Math.Sqrt(Math.Pow((x4 - x3), 2) + Math.Pow((y4 - y3), 2));
                if (!IsFirstPairLineLonger(firstPairPointDistance, secondPairPointDistance))
                {
                    x1 = x3;
                    y1 = y3;
                    x2 = x4;
                    y2 = y4;
                }
                PrintClosestPointCoordinatesFirst(x1, y1, x2, y2);
            }
        }

       static bool IsFirstPairLineLonger(double firstPairPointDistance, double secondPairPointDistance)
            {
                if (firstPairPointDistance >= secondPairPointDistance)
                {
                    return true;
                }
                return false;
            }

            static void PrintClosestPointCoordinatesFirst(double x1, double y1, double x2, double y2)
            {
                double firstPointDistance = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
                double secondPointDistance = Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2));
                if (firstPointDistance <= secondPointDistance)
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
                else
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }
            }
        }
    }
