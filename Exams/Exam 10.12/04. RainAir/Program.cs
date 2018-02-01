using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.RainAir
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = "";

            Dictionary<string, List<int>> CustomerDic = new Dictionary<string, List<int>>();

            while (true)
            {
                input = Console.ReadLine();

                if (input == "I believe I can fly!")
                {
                    break;
                }

                var inputArr = input
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (inputArr[1] == "=" && inputArr.Length == 3)
                {
                    string first = inputArr[0];
                    var secondName = inputArr[2];

                    CustomerDic.Remove(first);
                    CustomerDic.Add(first, new List<int>());

                    foreach (var secondItem in CustomerDic[secondName])
                    {
                        CustomerDic[first].Add(secondItem);
                    }
                }

                else
                {
                    string customer = inputArr[0];

                    if (!CustomerDic.ContainsKey(customer))
                    {
                        CustomerDic.Add(customer, new List<int>());
                    }

                    for (int i = 1; i < inputArr.Length; i++)
                    {
                        CustomerDic[customer].Add(int.Parse(inputArr[i]));
                    }
                }

            }

            foreach (var customer in CustomerDic.OrderByDescending(f => f.Value.Count).ThenBy(c=>c.Key))
            {

                Console.WriteLine($"#{customer.Key} ::: {string.Join(", ", customer.Value.OrderBy(f => f))}");

            }
        }
    }
}
