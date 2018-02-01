using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _08.Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b([0-9]{2})([\/\.-])([A-Z][a-z]{2})(\2)([0-9]{4})\b";
            var dateString = Console.ReadLine();
            MatchCollection dates = Regex.Matches(dateString, pattern);

            foreach (Match item in dates)
            {
                Console.WriteLine($"Day: {item.Groups[1]}, " +
                    $"Month: {item.Groups[3]}, Year: {item.Groups[5]}");
            }
        }
    }
}
