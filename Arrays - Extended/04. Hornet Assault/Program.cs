using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hornet_Assault
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> inputList = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToList();

            List<long> hornetList = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToList();

            for (int i = 0; i < inputList.Count; i++)
            {
                if (hornetList.Count == 0)
                {
                    break;
                }

                long summedPower = hornetList.Sum();

                if (inputList[i] < summedPower)
                {
                    inputList[i] = 0;
                }

                else
                {
                    inputList[i] -= summedPower;
                    hornetList.RemoveAt(0);
                }


            }

            inputList.RemoveAll(x => x == 0);

            if (inputList.Count > 0)
            {
                Console.WriteLine(string.Join(" ", inputList));
            }

            else
            {
                Console.WriteLine(string.Join(" ", hornetList));
            }
        }
    }
}
