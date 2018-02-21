using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var CountriesContinents = new Dictionary<string,
                Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var continents = tokens[0];
                var countries = tokens[1];
                var city = tokens[2];

                if (!CountriesContinents.ContainsKey(continents))
                {
                    CountriesContinents[continents] = new Dictionary<string, List<string>>();

                }
                var currentContinent = CountriesContinents[continents];

                if (!CountriesContinents[continents].ContainsKey(countries))
                {
                    currentContinent[countries] = new List<string>();
                }
                var currentCountry = currentContinent[countries];
                currentCountry.Add(city);
            }

            foreach (var continent in CountriesContinents)
            {
                var continentName = continent.Key;
                var countriess = continent.Value;
                Console.WriteLine($"{continent.Key}:");

                foreach (var country in countriess)
                {
                    var countryName = country.Key;
                    var cities = country.Value;
                    Console.WriteLine
                        (" {0} -> {1}", countryName, string.Join(", ", cities));
                }
            }
        }
    }
}

