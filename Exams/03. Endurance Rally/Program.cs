using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Endurance_Rally
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> players = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            List<double> layout = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();
            List<int> checkPoints = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            foreach (var player in players)
            {
                double fuel = (double)player[0];

                int i = 0;
                int reachedPoint = 0;
                while (i < layout.Count && fuel > 0)
                {
                    if(checkPoints.Contains(i))
                    {
                        fuel += layout[i];
                    }
                    else
                    {
                        fuel -= layout[i];
                    }
                    reachedPoint = i;
                    i++;
                }

                if(fuel>0)
                {
                    Console.WriteLine($"{player} - fuel left {fuel:F2}");
                }
                else
                {
                    Console.WriteLine($"{player} - reached {reachedPoint}");
                }
            }
        }
    }
}
