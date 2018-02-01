using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Exam_Preparation_III
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //the count of orders the shop will receive

            decimal totalPrice = 0;

            for (int i = 0; i < n; i++)
            {
                decimal price = ReadOrderAndCalculatePrice();
                totalPrice += price;
            }

            Console.WriteLine($"Total: ${totalPrice:F2}");
        }

         static decimal ReadOrderAndCalculatePrice()
        {
            decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
            string dateStr = Console.ReadLine();
            DateTime data = DateTime.ParseExact(dateStr, "d/M/yyyy", CultureInfo.InvariantCulture);
            decimal daysInMonth = DateTime.DaysInMonth(data.Year, data.Month);

            decimal capsule = decimal.Parse(Console.ReadLine());

            decimal price = (daysInMonth*capsule)*pricePerCapsule;

            Console.WriteLine($"The price for the coffee is: ${price:F2}");

            return price;
        }
    }
}
