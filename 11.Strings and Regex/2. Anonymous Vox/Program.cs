using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _2.Anonymous_Vox
{
    class Program
    {
        static void Main(string[] args)
        {
            string encodedText = Console.ReadLine();
            var placeholders = Console.ReadLine()
                .Split(new char[] { '{', '}', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string pattern = @"([A-Za-z]+)(.*)(\1)";
            var matches = Regex.Matches(encodedText, pattern);
            int count = 0;

            foreach (Match item in matches)
            {
                string newValue = item.Groups[1] + placeholders[count++] + item.Groups[3];
                encodedText = encodedText.Replace(item.Value, newValue);
            }

            Console.WriteLine(encodedText);
        }
    }
}
