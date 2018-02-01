using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _11_Sept
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^([^ _]{3}\.+)+([^ _]{3})$";

            string input;

            while (true)
            {
                input = Console.ReadLine();
                if (input == "ReadMe")
                {
                    break;
                }
                Match match = Regex.Match(input, pattern);

                if (Regex.Match(input, pattern).Success)
                {
                    List<string> matchList = match.ToString().Split('.').ToList();
                    StringBuilder matchBuilder = new StringBuilder();

                    foreach (var item in matchList)
                    {
                        matchBuilder.Append(item);
                    }

                    string matchLine = matchBuilder.ToString();

                    var lefthalf = matchLine.Substring(0, matchLine.Length / 2);
                    var reversedhalf = new string(matchLine.Reverse().ToArray());
                    var righthalf = reversedhalf.Substring(0, matchLine.Length / 2);

                    if (lefthalf == righthalf && !matchLine.Contains("_") && !matchLine.Contains(" "))
                    {
                        Console.WriteLine("YES");
                    }
                    else
                    {
                        Console.WriteLine("NO");
                    }
                }

                else if (input.Length == 3 && input[0] == input[2])
                {
                    Console.WriteLine("YES");
                }

                else
                {

                    Console.WriteLine("NO");

                }

            }

        }
    }
}
