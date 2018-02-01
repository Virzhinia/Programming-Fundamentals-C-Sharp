using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();
            var splitLine = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var arr = splitLine.Select(int.Parse).ToList();
            var sum = 0;

            while (arr.Count != 0)
            {
                int index = int.Parse(Console.ReadLine());
                int num = 0;
                if (index < 0)
                {
                    num = arr[0];
                    arr[0] = arr.Last();
                }
                else if(index>arr.Count-1)
                {
                    num = arr[arr.Count - 1];
                    arr[arr.Count - 1] = arr[0];
                }
                else
                {
                    num = arr[index];
                    arr.RemoveAt(index);
                }

                for (int i = 0; i < arr.Count; i++)
                {
                    if (arr[i] > num)
                    {
                        arr[i] -= num;
                    }

                    else
                    {
                        arr[i] += num;

                    }

                }
                sum += num;
            }
            Console.WriteLine(sum);
        }

    }
}

