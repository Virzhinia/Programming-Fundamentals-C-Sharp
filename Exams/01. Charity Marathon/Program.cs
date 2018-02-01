using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Charity_Marathon
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            var numberOfRunners = int.Parse(Console.ReadLine());
            var averageOfLaps = int.Parse(Console.ReadLine());
            var lengthTrack = int.Parse(Console.ReadLine());
            var capacityTrack = int.Parse(Console.ReadLine());
            var amountMoneyDonatedPerKilometer = double.Parse(Console.ReadLine());

            var maximumRunners = capacityTrack * days;

            if(numberOfRunners>maximumRunners)
            {
                numberOfRunners = maximumRunners;
            }

            var totalMeters = numberOfRunners * averageOfLaps * (double)lengthTrack;
            var totalKm = totalMeters / 1000;
            var earnedMoney = totalKm * amountMoneyDonatedPerKilometer;

            Console.WriteLine($"Money raised: {earnedMoney:F2}");
        }
    }
}
