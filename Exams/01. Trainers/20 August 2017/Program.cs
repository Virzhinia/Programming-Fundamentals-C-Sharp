using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20_August_2017
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            long distanceTravelMiles = 0;
            double cargoTones = 0.0;
            string team;
            string winner = string.Empty;
            double MostEarnedMoney = 0.0;
            // 1 mile = 1600 meters and 1 ton = 1000 kilogram.

            for (long i = 0; i < n; i++)
            {
                distanceTravelMiles = long.Parse(Console.ReadLine());
                cargoTones = double.Parse(Console.ReadLine());
                team = Console.ReadLine();

                double fuelExpenses = distanceTravelMiles * 1600 * 0.7 * 2.5;
                double cargoIncome = cargoTones * 1000;
                double earnedMoney = cargoIncome * 1.5 - fuelExpenses;

                if (earnedMoney > MostEarnedMoney && winner!=team)
                {
                    MostEarnedMoney = earnedMoney;
                    winner = team;
                }
                else if(earnedMoney > MostEarnedMoney && winner= team)
                {
                    MostEarnedMoney += earnedMoney;
                }
            }

            Console.WriteLine($"The {winner} Trainers win with ${MostEarnedMoney:F3}.");

        }
    }
}
