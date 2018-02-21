using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fast_Prime_Checker___Refactor
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            for (int firstNum = 2; firstNum <= input; firstNum++)
            {
                bool isTrue = true;
                for (int secondNum = 2; secondNum <= Math.Sqrt(firstNum); secondNum++)
                {
                    if (firstNum % secondNum == 0)
                    {
                        isTrue = false;
                        break;
                    }
                }
                Console.WriteLine($"{firstNum} -> {isTrue}");
            }
        }
    }
}
