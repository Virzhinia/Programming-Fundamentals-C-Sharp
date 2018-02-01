using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _01.Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader(@"../../input.txt");
            while (!reader.EndOfStream)
            {
                int[] line = reader.ReadLine().Split(' ').Select(int.Parse).ToArray();

                int count = 0;
                int mostFreq = 0;
                int element = line[line.Length - 1];

                for (int i = line.Length - 1; i >= 0; i--)
                {
                    if (i != line.Length - 1 && element.Equals(line[i]))
                    {
                        continue;
                    }
                    for (int j = i - 1; j >= 0; j--)
                    {
                        if (line[i].Equals(line[j]))
                        {
                            count++;
                        }
                    }
                    if (count >= mostFreq)
                    {
                        mostFreq = count;
                        element = line[i];
                        count = 0;
                    }
                    else
                    {
                        count = 0;
                    }
                }

                File.AppendAllText(@"../../output.txt", element.ToString() + Environment.NewLine);
            }
            reader.Close();
        }
    }
}
