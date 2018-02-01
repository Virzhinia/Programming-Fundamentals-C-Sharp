using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            int distanceMeters = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            float totalSec = hours * 3600 + minutes * 60 + seconds;
            float totalHours = (float)totalSec / 3600;
            float distanceKm = (float)distanceMeters / 1000;
            float distanceMiles = (float)distanceMeters / 1609;
            float metesrSec = (float)distanceMeters / totalSec;
            float kmHours = distanceKm / totalHours;
            float milesHours = distanceMiles / totalHours;

            Console.WriteLine(metesrSec);
            Console.WriteLine(kmHours);
            Console.WriteLine(milesHours);
        }
    }
}
