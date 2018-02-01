using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader(@"../../input.txt");
            while (!reader.EndOfStream)
            {
                string input = reader.ReadLine();

                int[] arr = new int[input.Length];

                for (int i = 0; i < input.Length; i++)
                {
                    arr[i] = (char)input[i] - 'a';
                }

                for (int i = 0; i < input.Length; i++)
                {
                    File.AppendAllText(@"../../output.txt"
                        , input[i] + " -> " + arr[i]
                        + Environment.NewLine);
                }
            }
            reader.Close();
        }
    }
}
