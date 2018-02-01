using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_10._12
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double density = double.Parse(Console.ReadLine());
            double regionalCoefficient = 0.0;

            while (n-->0)
            {
                double[] regionInfo = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .ToArray();

                double rainDropsCount = regionInfo[0];
                double squareMeters = regionInfo[1];

                regionalCoefficient += rainDropsCount / squareMeters;

            }

            if(density==0)
            {
                Console.WriteLine($"{regionalCoefficient:F3}");

            }
            else
            {
                double result = regionalCoefficient / density;
               
                Console.WriteLine($"{result:F3}");
            }
        }
    }
}
