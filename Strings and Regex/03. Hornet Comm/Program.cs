using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _03.Hornet_Comm
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            string privateMessage = @"^([0-9]+) <-> ([A-Za-z0-9]+)$";
            string broadcast = @"^([^0-9]+) <-> ([A-Za-z0-9]+)$";

            List<string> privateMesageList = new List<string>();
            List<string> broadcastList = new List<string>();


            while (input != "Hornet is Green")
            {
                var privateMessageMatch = Regex.Match(input, privateMessage);
                var broadcastMatch = Regex.Match(input, broadcast);

                if (privateMessageMatch.Success)
                {
                    string recipientCode = privateMessageMatch.Groups[1].ToString();
                    recipientCode = string.Join("", recipientCode.ToCharArray().Reverse().ToArray());
                    privateMesageList.Add(recipientCode + " -> " + privateMessageMatch.Groups[2].ToString());
                }

                if (broadcastMatch.Success)
                {
                    string frequency = broadcastMatch.Groups[2].ToString();
                    string frequencyResult = "";

                    for (int i = 0; i < frequency.Length; i++)
                    {
                        if (char.IsLower(frequency[i]))
                        {
                            frequencyResult += frequency[i].ToString().ToUpper();
                        }
                        else if (char.IsUpper(frequency[i]))
                        {
                            frequencyResult += frequency[i].ToString().ToLower();
                        }
                        else
                        {
                            frequencyResult += frequency[i].ToString();
                        }
                    }
                    broadcastList.Add(frequencyResult + " -> " + broadcastMatch.Groups[1]);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Broadcasts:");
            if (broadcastList.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                broadcastList.ForEach(e => Console.WriteLine(e));
            }

            Console.WriteLine("Messages:");
            if (privateMesageList.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                privateMesageList.ForEach(e => Console.WriteLine(e));
            }
        }
    }
}
