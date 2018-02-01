using System;
using System.Collections.Generic;
using System.Linq;

namespace Preparations
{
    class Program
    {
        static void Main(string[] args)
        {
            long days = long.Parse(Console.ReadLine());
            long runners = long.Parse(Console.ReadLine());
            long laps = long.Parse(Console.ReadLine());
            long laplenth = long.Parse(Console.ReadLine());
            long trackCapacity = long.Parse(Console.ReadLine());
            decimal moneyPerKm = decimal.Parse(Console.ReadLine());

            var capacity = trackCapacity * days;

            if (capacity >= runners)
            {
                long totalKmeters = (runners * laps * laplenth) / 1000;
                decimal raisedMoney = totalKmeters * moneyPerKm;
                Console.WriteLine($"Money raised: {raisedMoney:F2}");
            }

            else if (capacity < runners)
            {
                long totalKmeters = (capacity * laps * laplenth) / 1000;
                decimal raisedMoney = totalKmeters * moneyPerKm;
                Console.WriteLine($"Money raised: {raisedMoney:F2}");
            }
        }
    }
}
