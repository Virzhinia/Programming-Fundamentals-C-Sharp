using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _03.Raincast
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = "";
            string soursePattern = @"^([Source]+)(:\s)([A-Za-z0-9]+)$";
            string forecastPattern = @"^([Forecast]+)(:\s)([^!.,?]+)$";

            List<string> TypesList = new List<string>();
            List<string> TypesSours = new List<string>();
            List<string> TypesForecast = new List<string>();
            Dictionary<string, Dictionary<string, String>> Dict = new Dictionary<string, Dictionary<string, string>>();

            while (true)
            {
                input = Console.ReadLine();

                if (input == "Davai Emo")
                {
                    break;
                }

                var inputArr = Console.ReadLine()
                 .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string types = inputArr[0];
                string source = "";
                string forecast = "";

                if (types == "Type:")
                {
                    if (types == "Normal" || types == "Warning" || types == "Danger")
                    {
                        Dict.Add(types, new Dictionary<string, string>());
                    }

                    continue;
                }

                if (types == "Source:")
                {
                    var sourseRegex = Regex.Match(input, soursePattern);

                    if (sourseRegex.Success)
                    {
                        source = sourseRegex.Groups[3].ToString();
                        Dict[types].Add(source, forecast);
                    }

                    continue;
                }

                if (types == "Forecast:")
                {
                    var forecastRegex = Regex.Match(input, forecastPattern);

                    if (forecastRegex.Success)
                    {
                        forecast = forecastRegex.Groups[3].ToString();
                        Dict[types][source] = forecast;
                    }

                    continue;
                }

            }

            foreach (var type in Dict)
            {
                Console.WriteLine($"({type.Key}) {type.Value.Keys} ~ {type.Value.Values}");
            }
        }
    }
}
