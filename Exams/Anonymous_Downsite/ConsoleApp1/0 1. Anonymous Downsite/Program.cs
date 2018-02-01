using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _0_1.Anonymous_Downsite
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine()); //count of affected websites.
            BigInteger securityKey = BigInteger.Parse(Console.ReadLine());
            decimal siteLoss = 0.0M;
            string[] input;
            List<string> emails = new List<string>();
            BigInteger siteVisits = 0;
            decimal siteCommercialPricePerVisit = 0.0M;
            BigInteger securityToken = 1;

            for (int i = 0; i < n; i++)
            {
                securityToken *= securityKey;
            }

            if (n == 0)
            {
                securityToken = 1;
            }
            for (long i = 0; i < n; i++)
            {
                input = Console.ReadLine().Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (!emails.Contains(input[0]) && input[0] != " ")
                {
                    emails.Add(input[0]);
                    siteVisits = ulong.Parse(input[1]);
                    siteCommercialPricePerVisit = decimal.Parse(input[2]);
                }


                siteLoss += (ulong)siteVisits * siteCommercialPricePerVisit;
            }

            foreach (var item in emails)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Total Loss: {siteLoss:F20}");
            Console.WriteLine($"Security Token: {securityToken}");

        }
    }
}