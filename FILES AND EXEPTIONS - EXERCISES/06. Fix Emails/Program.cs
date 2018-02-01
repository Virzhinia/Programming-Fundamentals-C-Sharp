using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> record = new Dictionary<string, string>();

            StreamReader reader = new StreamReader(@"../../input.txt");

            string name = reader.ReadLine();
            string email;

            while (!name.Equals("stop"))
            {
                email = reader.ReadLine();
                if (!record.ContainsKey(name))
                {
                    record.Add(name, string.Empty);
                }
                record[name] = email;

                name = reader.ReadLine();
            }

            foreach (KeyValuePair<string, string> person in record)
            {
                if (person.Value.EndsWith("uk") || person.Value.EndsWith("us"))
                {
                    continue;
                }
                File.AppendAllText(@"../../output.txt", person.Key + " -> " + person.Value + Environment.NewLine);
            }

            reader.Close();
        }
    }
}
