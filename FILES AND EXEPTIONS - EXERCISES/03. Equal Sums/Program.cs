using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader(@"../../input.txt");
            while (!reader.EndOfStream)
            {
                int[] input = reader.ReadLine().Split().Select(int.Parse).ToArray();

                int index = -1;

                for (int i = 0; i < input.Length; i++)
                {
                    if (input.Take(i).Sum().Equals(input.Skip(i + 1).Take(input.Length - i).Sum()))
                    {
                        index = i;
                    }
                }

                if (index != -1)
                {
                    File.AppendAllText(@"../../output.txt", index + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(@"../../output.txt", "no" + Environment.NewLine);
                }
            }
            reader.Close();
        }
    }
}
