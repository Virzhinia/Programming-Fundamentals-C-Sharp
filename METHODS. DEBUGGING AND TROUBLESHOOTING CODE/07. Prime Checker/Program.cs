using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Prime_Checker
{
    class Program
    {
       static bool isPrime (int num)
        {
            bool isPrime = true;
            if (num<=1)
            {
                isPrime = false;
            }

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if(num%i==0 || num <= 1)
                {
                    isPrime = false;
                }
            }
            return isPrime;
        }

        private static List <int> FindPrimesInRange (int startNum, int stopNum)
        {
            var primes = new List<int>();
            for (int currentNum = startNum; currentNum <= stopNum; currentNum++)
            {
                if(isPrime(currentNum))
                {
                    primes.Add(currentNum);
                }
            }
            return primes;
        }

        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int stopNum = int.Parse(Console.ReadLine());
            var primes = FindPrimesInRange(startNum, stopNum);
            Console.WriteLine(string.Join(", ", primes));

        }
    }
}
