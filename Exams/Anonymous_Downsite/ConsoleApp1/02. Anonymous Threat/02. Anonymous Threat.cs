using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> commandsList = new List<string>();

            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < input.Length; i++)
            {
                commandsList.Add(input[i]);
            }

            string[] command;

            while (true)
            {
                command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "3:1")
                {
                    break;
                }

                if (command[0] == "merge")
                {
                    var statrIdex = int.Parse(command[1]);
                    var endIndex = int.Parse(command[2]);
                    //MergeIndexes(statrIdex, endIndex, commandsList);

                    commandsList[statrIdex] = commandsList;
                    for (int j = statrIdex; j <= endIndex; j++)
                    {
                        commandsList[statrIdex] += input[j + 1];
                        commandsList.RemoveAt(j + 1);
                    }

                    foreach (var item in commandsList)
                    {
                        Console.WriteLine(string.Join(" ", item));
                    }
                }
                if (command[0] == "divide")
                {
                    var index = int.Parse(command[1]);
                    var partitions = int.Parse(command[2]);
                    DivideIndexes(index, partitions, commandsList);
                }
            }
        }

        public static void DivideIndexes(int index, int partitions, List<string> commandsList)
        {

        }

        public static void MergeIndexes(int statrIdex, int endIndex, List<string> commandsList)
        {
            

            for (int j = statrIdex; j < endIndex; j++)
            {
                commandsList[statrIdex] += input[j+1];
                commandsList.RemoveAt(j+1);

            }

            foreach (var item in commandsList)
            {
                Console.WriteLine(string.Join(" ", item));
            }

        }
    }
}
