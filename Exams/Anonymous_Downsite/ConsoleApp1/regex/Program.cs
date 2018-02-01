using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace regex
{
    class Program
    {
        static void Main(string[] args)
        {
            string input=Console.ReadLine();

            string[] placeholders = Console.ReadLine().Split(new char[] {'{', '}'});

            string pattern = @"^(<startKey>[a-zA-Z]+)(<insideKey>\w+)(\1)$";

            var keyMatch = Regex.Match(input, pattern);

            if (keyMatch.Success)
            {
                StringBuilder matchBuilder = new StringBuilder();
                var startKey = keyMatch.Groups["startKey"].Value;
                var insideKey = keyMatch.Groups["insideKey"].Value;

                var textPattern = $@"{startKey}{insideKey}{startKey}";
                var matches = Regex.Matches(input, textPattern);

                var result = new StringBuilder();

                foreach (Match match in matches)
                {
                    result.Append(match);
                }

                Console.WriteLine(result.ToString());
            }

        }
    }
}
