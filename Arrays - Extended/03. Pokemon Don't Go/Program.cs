using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int removedElement = 0;

            int sumRemovedElements = 0;

            while (inputList.Count != 0)
            {
                int removedIndex = int.Parse(Console.ReadLine());

                if (removedIndex < 0)
                {
                    removedElement = inputList[0];
                    inputList[0] = inputList[inputList.Count - 1];
                }

                else if (removedIndex > inputList.Count - 1)
                {
                    removedElement = inputList[inputList.Count - 1];
                    inputList[inputList.Count - 1] = inputList[0];
                }

                else
                {
                    removedElement = inputList[removedIndex];
                    inputList.RemoveAt(removedIndex);
                }

                for (int i = 0; i < inputList.Count; i++)
                {
                    if (inputList[i] <= removedElement)
                    {
                        inputList[i] += removedElement;
                    }

                    else
                    {
                        inputList[i] -= removedElement;
                    }
                }

                sumRemovedElements += removedElement;
            }

            Console.WriteLine(sumRemovedElements);
        }
    }
}
