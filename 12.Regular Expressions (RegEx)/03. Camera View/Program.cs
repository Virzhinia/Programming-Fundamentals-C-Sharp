using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _03.Camera_View
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] indices = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int m = indices[0];
            int n = indices[1];

            string pattern = $"\\|\\<(.{{0,{m}}})(.{{0,{n}}})";

            Regex regex = new Regex(pattern);

            string inputLine = Console.ReadLine();

            Match matche = regex.Match(inputLine);

            List<string> results = new List<string>();

            while (inputLine.Length > matche.Index + 2 && matche.Success)
            {

                string matchToAdd = matche.Groups[2].Value;

                if(matchToAdd.Contains("|"))
                {
                    matchToAdd = matchToAdd.Substring(0,
                        matchToAdd.IndexOf("|"));
                }

                if (matchToAdd.Contains("<"))
                {
                    matchToAdd = matchToAdd.Substring(0,
                        matchToAdd.IndexOf("<"));
                }

                results.Add(matchToAdd);

                inputLine = inputLine.Substring(matche.Index + 2);
                matche = regex.Match(inputLine);
            }

            Console.WriteLine(string.Join(", ", results));



            // var array = Console.ReadLine()
            //     .Split(new char[] { ' ' })
            //     .Select(int.Parse)
            //     .ToArray();
            //
            // int elementsToSkip = array[0];
            // int elementsToTake = array[1];
            //
            // var text = Console.ReadLine().Split('|');
            // string pattern = "<";
            //
            // Regex regex = new Regex(pattern);
            //
            // foreach (var ch in text)
            // {
            //     if (regex.IsMatch(ch))
            //     {
            //
            //         var textToEnd=ch.Skip(elementsToSkip + 1).Take(elementsToTake).ToArray();
            //         Console.Write(textToEnd);
            //     }
            // }
            // Console.WriteLine();
        }
    }
}
