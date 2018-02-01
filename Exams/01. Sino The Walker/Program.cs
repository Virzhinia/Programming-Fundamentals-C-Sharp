using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Sino_The_Walker
{
    class Program
    {
        static void Main(string[] args)
        {
            string startTimeString = Console.ReadLine();
            int numberOfSteps = int.Parse(Console.ReadLine())%86400;
            int timePerStep = int.Parse(Console.ReadLine())%86400;

            int secondsToGoHome = numberOfSteps * timePerStep;
            TimeSpan starTime = TimeSpan.Parse(startTimeString);
            TimeSpan finishTime = starTime.Add(TimeSpan.FromSeconds(secondsToGoHome));

            Console.WriteLine($"Time Arrival: {finishTime.ToString(@"hh\:mm\:ss")}");
        }
    }
}
