using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.Centuries_to_Nanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int years = num * 100;
            int days = (int)(365.2422 * years);
            int hours = days * 24;
            long minutes = hours * 60;
            double seconds = minutes * 60;
            double miliseconds = seconds * 1000;
            decimal microSec =(decimal)miliseconds * 1000;
            decimal nanoSec = microSec * 1000;

            Console.WriteLine($"{num} centuries = {years} years = {days} days = {hours} " +
                $"hours = {minutes} minutes = {seconds} seconds = {miliseconds} " +
                $"milliseconds = {microSec} " +
                $"microseconds = {nanoSec} nanoseconds");
        }
    }
}
