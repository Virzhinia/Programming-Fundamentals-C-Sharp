using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.CODE_Phoenix_Oscar_Romeo_November
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            Dictionary<string, HashSet<string>> creatures = new Dictionary<string, HashSet<string>>();
            List<string> check = new List<string>();

            while (true)
            {
                input = Console.ReadLine();

                if (input == "Blaze it!")
                {
                    break;
                }

                var inputArr = input
                    .Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                string creature = inputArr[0];
                string squadmate = inputArr[1];
                check.Add(squadmate + "" + creature);

                if (!creatures.ContainsKey(creature))
                {
                    creatures.Add(creature, new HashSet<string>());
                }

                if (creature == squadmate || check.Contains(creature + "" + squadmate))
                {
                    creatures[squadmate].Remove(creature);
                    continue;
                }

                creatures[creature].Add(squadmate);

            }

            foreach (var item in creatures.OrderByDescending(x=>x.Value.Count))
            {
                Console.WriteLine($"{item.Key} : {item.Value.Count}");
            }
        }
    }
}
