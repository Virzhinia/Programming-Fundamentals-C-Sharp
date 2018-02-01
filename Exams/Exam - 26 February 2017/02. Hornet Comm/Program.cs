using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.Hornet_Comm
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> messages = new List<string>();
            List<string> broadcasts = new List<string>();

            string messageRegex = "^([\\d]+) <-> ([0-9a-zA-Z]+)$";
            string broadcastRegex = "^([\\D]+) <-> ([0-9a-zA-Z]+)$";

            Regex message = new Regex(messageRegex);
            Regex broadcast = new Regex(broadcastRegex);

            string input;

            while((input=Console.ReadLine()) !="Hornet is Green")
            {
                var inputArgs = input.Split(new string[] { " <->" },
                    StringSplitOptions.RemoveEmptyEntries);

                if (message.IsMatch(input))
                {
                    messages.Add(input);
                    messages[0].Reverse();
                }
                else if(broadcast.IsMatch(input))
                {
                    broadcasts.Add(input);
                    foreach (var ch in broadcasts)
                    {
                        
                    }

                }
            }
        }
    }
}
