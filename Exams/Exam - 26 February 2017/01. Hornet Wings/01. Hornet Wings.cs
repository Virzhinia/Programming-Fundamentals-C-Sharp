using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exam___26_February_2017
{
    class Program
    {
        static void Main(string[] args)
        {
            int wingFlapsN = int.Parse(Console.ReadLine());
            decimal distanceMetersM = decimal.Parse(Console.ReadLine());
            //for 1000 wing flaps
            int enduranceP = int.Parse(Console.ReadLine());
            //how many wing flaps he can make, 
            //before he stops to take a break and rest.
            //A hornet rests for 5 seconds.
            decimal metersTraveled = 0.00M;
            int secondsPassed = 0;//100 wing flaps per second

            metersTraveled = (wingFlapsN / 1000) * distanceMetersM;
            var secondFlaps = wingFlapsN / 100;
            secondsPassed = (wingFlapsN /enduranceP) * 5 + secondFlaps;

            Console.WriteLine($"{metersTraveled:F2} m.");
            Console.WriteLine($"{secondsPassed} s.");

        }
    }
}
