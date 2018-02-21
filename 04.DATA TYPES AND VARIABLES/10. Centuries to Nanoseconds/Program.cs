using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Centuries_to_Nanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            int years = (int)centuries * 100;
            double days = (int)(years * 365.2422);
            int hours = (int)days * 24;
            decimal minutes = hours * 60M;
            decimal seconds = minutes * 60M;
            decimal milliSeconds = seconds * 1000;
            decimal microSeconds = milliSeconds * 1000;
            decimal nanoSeconds = microSeconds * 1000;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days " +
                $"= {hours} hours = {minutes} minutes = {seconds} seconds = {milliSeconds} " +
                $"milliseconds = {microSeconds} microseconds = {nanoSeconds} nanoseconds");

        }
    }
}
