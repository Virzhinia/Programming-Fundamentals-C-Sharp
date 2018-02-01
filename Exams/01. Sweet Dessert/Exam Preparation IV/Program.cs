using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exam_Preparation_IV
{
    class Program
    {
        static void Main(string[] args)
        {
            double cash = double.Parse(Console.ReadLine());
            int guests = int.Parse(Console.ReadLine());
            double bananaPrice = double.Parse(Console.ReadLine());
            double eggsPrice = double.Parse(Console.ReadLine());
            double berriesPrice = double.Parse(Console.ReadLine());
            int portions = (int)Math.Ceiling(guests / 6.00);

            var neededMoney = portions * (2 * bananaPrice + 4 * eggsPrice + 0.2 * berriesPrice);

            if (cash >= neededMoney)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {neededMoney:F2}lv.");

            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {(neededMoney-cash):F2}lv more.");
            }


        }
    }
}
