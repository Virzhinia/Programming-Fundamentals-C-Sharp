using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _01.Convert_from_base_10_to_base_N
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = Console.ReadLine();
            List<BigInteger> nums = data.Split().Select(BigInteger.Parse).ToList();
            List<BigInteger> res = new List<BigInteger>();
            var BigIntegerbaseNum = nums[0];
            var BigIntegernumber = nums[1];
            while (BigIntegernumber != 0)
            {
                var result = BigIntegernumber % BigIntegerbaseNum;
                res.Add(result);
                BigIntegernumber = BigIntegernumber / BigIntegerbaseNum;
            }
            var revRes = string.Join("", res);
            revRes = new string(revRes.Reverse().ToArray());
            Console.WriteLine(revRes);
        }
    }
}
