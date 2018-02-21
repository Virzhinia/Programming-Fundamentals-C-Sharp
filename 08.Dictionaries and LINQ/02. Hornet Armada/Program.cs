using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Hornet_Armada
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, long> LegionsActivity = new Dictionary<string, long>();

            Dictionary<string, Dictionary<string, long>> legionsInfo = new Dictionary<string, Dictionary<string, long>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(new char[] { '=', ' ', '>', ':', '-' }, StringSplitOptions.RemoveEmptyEntries);

                long lastActivity = long.Parse(input[0]);
                string legionName = input[1];
                string solderType = input[2];
                long solderCount = long.Parse(input[3]);

                if (!legionsInfo.ContainsKey(legionName))
                {
                    legionsInfo.Add(legionName, new Dictionary<string, long>());
                    LegionsActivity.Add(legionName, lastActivity);
                }

                if (!legionsInfo[legionName].ContainsKey(solderType))
                {
                    legionsInfo[legionName].Add(solderType, solderCount);
                }
                else
                {
                    legionsInfo[legionName][solderType] += solderCount;
                }

                if (LegionsActivity[legionName] < lastActivity)
                {
                    LegionsActivity[legionName] = lastActivity;
                }

            }

            string command = Console.ReadLine();

            if (command.IndexOf('\\') != -1)
            {
                long activity = long.Parse(command.Substring(0, command.IndexOf('\\')));
                string solder = command.Substring(command.IndexOf('\\') + 1);

                foreach (var item in legionsInfo.Where(e => legionsInfo[e.Key].ContainsKey(solder))
                    .OrderByDescending(k => k.Value[solder]))
                {
                    if (LegionsActivity[item.Key] < activity)
                    {
                        Console.WriteLine($"{item.Key} -> {item.Value[solder]}");
                    }
                }
            }
            else
            {
                foreach (var item in LegionsActivity.OrderByDescending(x => x.Value))
                {
                    if (legionsInfo[item.Key].ContainsKey(command))
                    {
                        Console.WriteLine($"{item.Value} : {item.Key}");
                    }
                }
            }
        }
    }
}
