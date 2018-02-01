using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Entertrain
{
    class Program
    {
        static void Main(string[] args)
        {
            int locomotivePower = int.Parse(Console.ReadLine());
            List<int> weightList = new List<int>();
            var input = "";
            int sumWeights = 0;
            var average = 0;

            while (true)
            {
                input = Console.ReadLine();

                if (input == "All ofboard!")
                {
                    break;
                }

                input.Split(' ').Select(int.Parse);

                weightList.Add(input[0]);
            }

                sumWeights += weightList[i];
                if (sumWeights > locomotivePower)
                {

                    average = sumWeights / i;
                    break;
                }


            foreach (var item in weightList)
            {
                if (item == average)
                {
                    weightList.Remove(item);
                }
            }
            weightList.Add(locomotivePower);

            Console.WriteLine(string.Join(" ", weightList.OrderByDescending(x => x)));
        }
    }
}
