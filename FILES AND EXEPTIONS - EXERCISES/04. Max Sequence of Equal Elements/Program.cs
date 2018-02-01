using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader(@"../../input.txt");
            while (!reader.EndOfStream)
            {
                int[] input = reader.ReadLine().Split().Select(int.Parse).ToArray();

                int start = 0;
                int counter = 0;
                int max = 0;

                for (int i = 0; i < input.Length - 1; i++)
                {
                    if (input[i].Equals(input[i + 1]))
                    {
                        counter++;
                        if (counter > max)
                        {
                            start = i - counter;
                            max = counter;
                        }
                    }
                    else
                    {
                        counter = 0;
                    }
                }
                for (int i = start + 1; i < start + max + 2; i++)
                {
                    File.AppendAllText(@"../../output.txt", input[i] + " ");
                }
                File.AppendAllText(@"../../output.txt", Environment.NewLine);
            }
            reader.Close();
        }
    }
}
