namespace _06.User_Logs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var inpit = Console.ReadLine();
            var dictionaryIp = new SortedDictionary<string, Dictionary<string, int>>();
            var count = 0;

            while (inpit != "end")
            {
                var users = inpit.Split(new char[] { ' ', '=' });
                var ip = users[1];
                var message = users[3];
                var name = users[5];

                if (!dictionaryIp.ContainsKey(name))
                {
                    dictionaryIp[name] = new Dictionary<string, int>();
                }

                if (!dictionaryIp[name].ContainsKey(ip))
                {
                    dictionaryIp[name][ip] = 0;
                    count = 1;
                }

                dictionaryIp[name][ip] += count;
                inpit = Console.ReadLine();

            }
            foreach (var ipAdress in dictionaryIp)
            {
                var name = ipAdress.Key;

                Console.WriteLine($"{name}:");

                var ip = ipAdress.Value;
                bool first = true;

                foreach (var item in ip)
                {
                    if (!first)
                        Console.Write(", ");

                    Console.Write($"{item.Key} => {item.Value}");
                    first = false;

                }
                Console.Write(".");
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
