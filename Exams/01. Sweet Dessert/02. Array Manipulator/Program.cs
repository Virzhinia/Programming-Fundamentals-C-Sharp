using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.Array_Manipulator
{
    class Program
    {

        static void Main(string[] args)
        {
            var inputArr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();

            string[] commandsArr;

            while (true)
            {
                commandsArr = Console.ReadLine().Split(' ').ToArray();

                var command = commandsArr[0];

                if (command == "end")
                {
                    break;
                }

                else
                {
                    switch (command)
                    {
                        case "exchange":
                            ExchangeArr(commandsArr, inputArr);
                            break;
                        case "max":
                        case "min":
                            FindMaxMinOddEven(commandsArr, inputArr);
                            break;
                        case "first":
                        case "last":
                            FindFirstLastOddEven(commandsArr, inputArr);
                            break;
                    }
                }

            }
        }

        static void FindFirstLastOddEven(string[] commandsArr, int inputArr)
        {
            throw new NotImplementedException();
        }

        static void FindMaxMinOddEven(string[] commandsArr, List<int> inputArr)
        {
            throw new NotImplementedException();
        }

        static void ExchangeArr(string[] commandsArr, int inputArr)
        {
            int commandEx = int.Parse(commandsArr[1]);
            var newArr = inputArr.Take(commandEx + 1).ToList();

            if (commandEx < 0 && commandEx > inputArr.Co)
            {
                Console.WriteLine("Invalid index");
                return;
            }
            
            inputArr.

            Console.WriteLine(string.Join(" ", newArr));

        }
    }
}
