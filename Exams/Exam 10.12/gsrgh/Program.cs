using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace gsrgh
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, String>> Dict = new Dictionary<string, Dictionary<string, string>>();
            List<string> Types = new List<string>();
            List<string> SourceList = new List<string>();
            List<string> ForecastList = new List<string>();

            string soursePattern = @"^([Source]+)(:\s)([A-Za-z0-9]+)$";
            string forecastPattern = @"^([Forecast]+)(:\s)([^!.,?]+)$";
            string input = "";

            while (true)
            {
                input = Console.ReadLine();
                if (input == "Davai Emo")
                {
                    break;
                }

                var inputArr = input.Split();

                string group = inputArr[0];

                if (group == "Type:")
                {
                    string type = inputArr[1];

                    if (type == "Normal" || type == "Warning" || type == "Danger")
                    {
                        Types.Add(type);
                    }

                    continue;
                }

                if (group == "Source:")
                {
                    var sourseRegex = Regex.Match(input, soursePattern);

                    if (sourseRegex.Success)
                    {
                        var source = sourseRegex.Groups[3].ToString();
                        SourceList.Add(source);
                    }

                    continue;
                }

                if (group == "Forecast")
                {
                    var forecastRegex = Regex.Match(input, forecastPattern);

                    if (forecastRegex.Success)
                    {
                        var forecast = forecastRegex.Groups[3].ToString();
                        ForecastList.Add(forecast);
                    }

                    continue;
                }

            }

            foreach (var item in Types)
            {
                Console.WriteLine($"({item}) ~ ");

            }
            foreach (var source in SourceList)
            {
                Console.Write($"{source}");
            }
        }

    }
}

