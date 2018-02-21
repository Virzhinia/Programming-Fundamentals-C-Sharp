namespace Regular_Expressions__RegEx_
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"(\s[a-zA-Z0-9][\w.-]*\@[a-zA-Z-]+)(\.[a-zA-Z-]+)+";

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(text);

            foreach (var emailMatch in matches)
            {
                string email = emailMatch.ToString();
                if (!email.StartsWith(".") || email.StartsWith("-") || email.StartsWith("_")
                    || email.EndsWith(".") || email.EndsWith("-") || email.EndsWith("_"))
                {
                    Console.WriteLine(email);
                }
            }
        }
    }
}
