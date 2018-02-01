using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.CODE_Phoenix_Oscar_Romeo_November
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> creaturesMate = new Dictionary<string, List<string>>();
            string input;

            while (true)
            {
                input = Console.ReadLine();

                if (input == "Blaze it!")
                {
                    break;
                }

                var inputTokens = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                var creatures = inputTokens[0];
                var squadMates = inputTokens[1];

                if (!creaturesMate.ContainsKey(creatures))
                {
                    creaturesMate.Add(creatures, new List<string>());
                }

                if (creaturesMate[creatures].Contains(squadMates) || squadMates == creatures)
                {
                    continue;
                }

                creaturesMate[creatures].Add(squadMates);


            }

            foreach (var item in creaturesMate)
            {
                Console.WriteLine($"{item.Key} : {item.Value.Count}");
            }
        }
    }
}
