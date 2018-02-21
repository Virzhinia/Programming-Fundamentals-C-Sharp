using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _06.Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = @"\+359(\s*-*)2(\1)([0-9]){3}(\1)([0-9]){4}\b";

            var phones = Console.ReadLine();

            var phoneMatches = Regex.Matches(phones, regex);

            // foreach (Match phone in phoneMatches)
            // {
            //     Console.Write(phone.Value + ", ");
            // }
            //
            // Console.WriteLine();

            var matchedPhones = phoneMatches
                .Cast<Match>()
                .Select(a => a.Value.Trim())
                .ToArray();

            Console.WriteLine(string.Join(", ", matchedPhones));
        }
    }
}
