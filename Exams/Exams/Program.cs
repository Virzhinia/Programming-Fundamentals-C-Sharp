using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exams
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            while (n-- > 0)
            {
                int round = 0;
                double lengthOfBody = double.Parse(Console.ReadLine());
                double widthOfBody = double.Parse(Console.ReadLine());
                double lengthOfwing = double.Parse(Console.ReadLine());
                double yearsReincarnate = Math.Pow(lengthOfBody, 2) * (widthOfBody + 2 * lengthOfwing);
                double width2 = widthOfBody;

                while (width2 % 10 != 0)
                {
                    round++;
                    width2 = width2 * 10;
                }
                if (round == 0)
                {
                    Console.WriteLine($"{yearsReincarnate}");
                }
                else
                {
                    Console.WriteLine($"{Math.Round(yearsReincarnate, round)}");

                }
            }
        }
    }
}
