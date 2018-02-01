using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Hornet_Assault
{
    class Program
    {
        static void Main(string[] args)
        {
            var beehives = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var hornets = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> aliveBeehive = new List<int>();

            foreach (var beehive in beehives)
            {
                if(hornets.Count==0)
                {
                    aliveBeehive.Add(beehive);
                    continue;
                }

                var power = hornets.Sum();

                if(power>=beehive)
                {
                    if (power == beehive)
                    {
                        hornets.RemoveAt(0);
                    }
                }
                else
                {
                    aliveBeehive.Add(beehive - power);
                    hornets.RemoveAt(0);
                }
            }


        }
    }
}
