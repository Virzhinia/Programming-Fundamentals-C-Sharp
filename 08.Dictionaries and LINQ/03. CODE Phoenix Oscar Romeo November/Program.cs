using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CODE_Phoenix_Oscar_Romeo_November
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, HashSet<string>> Creatures = new Dictionary<string, HashSet<string>>();

            List<string> check = new List<string>();
            string input = Console.ReadLine();

            while (input != "Blaze it!")
            {
                var data = input.Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

                string creature = data[0];
                string squadMate = data[1];
                check.Add(squadMate + "" + creature);

                if (!Creatures.ContainsKey(creature))
                {
                    Creatures.Add(creature, new HashSet<string>());
                }

                if (creature == squadMate || check.Contains(creature + "" + squadMate))
                {
                    Creatures[squadMate].Remove(creature);
                    input = Console.ReadLine();
                    continue;
                }

                Creatures[creature].Add(squadMate);

                input = Console.ReadLine();
            }

            foreach (var item in Creatures.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{item.Key} : {item.Value.Count}");
            }



          //  var data = new Dictionary<string, HashSet<string>>();
          //
          //  string input = Console.ReadLine();
          //
          //  while (input != "Blaze it!")
          //  {
          //      string[] myArr = input
          //          .Split(new string[] { " -> " }, StringSplitOptions.None);
          //
          //      string creature = myArr[0];
          //      string squadMate = myArr[1];
          //
          //      if (!data.ContainsKey(creature))
          //      {
          //          data.Add(creature, new HashSet<string>());
          //      }
          //
          //      if (creature != squadMate)
          //      {
          //          data[creature].Add(squadMate);
          //      }
          //
          //      input = Console.ReadLine();
          //  }
          //
          //  var result = new Dictionary<string, List<string>>();
          //
          //  foreach (var item in data)
          //  {
          //      result.Add(item.Key, new List<string>());
          //
          //      foreach (var mate in item.Value)
          //      {
          //          if (data.ContainsKey(mate) && data[mate].Contains(item.Key))
          //          {
          //              continue;
          //          }
          //
          //          else
          //          {
          //              result[item.Key].Add(mate);
          //          }
          //      }
          //  }
          //
          //  foreach (var item in result.OrderByDescending(c => c.Value.Count))
          //  {
          //      Console.WriteLine($"{item.Key} : {item.Value.Count}");
          //  }
        }
    }
}
