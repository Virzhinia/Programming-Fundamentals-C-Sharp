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
            Dictionary<string, long> record = new Dictionary<string, long>();

            StreamReader reader = new StreamReader(@"../../input.txt");

                string input = reader.ReadLine();
                int n = 1;
                string key = string.Empty;

                while (!reader.EndOfStream)
                {
                    if (n % 2 != 0)
                    {
                        key = input;
                        if (!record.ContainsKey(key))
                        {
                            record.Add(key, 0L);
                        }
                    }
                    else
                    {
                        record[key] += long.Parse(input);
                    }

                    input = reader.ReadLine();
                    n++;
                }

                foreach (KeyValuePair<string, long> line in record)
                {
                    File.AppendAllText(@"../../output.txt", 
                        line.Key + " -> " + line.Value + Environment.NewLine);
                }
            
            reader.Close();
        }
    }
}
