using System;
using System.Collections.Generic;
using System.Linq;


namespace _08.Logs_Aggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var inputUsers = new SortedDictionary<string, SortedDictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                var users = Console.ReadLine().Split().ToArray(); // <IP> <user> <duration>
                var ip = users[0];
                var name = users[1];
                var duration = int.Parse(users[2]);

                if (!inputUsers.ContainsKey(name))
                {
                    inputUsers.Add(name, new SortedDictionary<string, int>());
                }
                if (!inputUsers[name].ContainsKey(ip))
                {
                    inputUsers[name].Add(ip, duration);
                }
                else
                {
                    inputUsers[name][ip] += duration;
                }
            }

            foreach (var user in inputUsers)
            {
                var totalDurationOfUser = inputUsers[user.Key].Values.Sum();
                var listOfIps = user.Value.Keys.ToList();
                Console.WriteLine($"{user.Key}: {totalDurationOfUser} [{string.Join(", ", listOfIps)}]");
            }
        }
    }
}
    
