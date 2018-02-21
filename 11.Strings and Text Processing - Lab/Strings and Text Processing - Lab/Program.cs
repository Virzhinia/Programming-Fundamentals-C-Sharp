using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_and_Text_Processing___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            var badWords = Console.ReadLine().Split(',', ' ')
                .Where(w => w.Length > 0).ToArray();

            var text = Console.ReadLine();

            foreach (var Badword in badWords)
            {
                var replacement = new string('*',Badword.Length);
                text = text.Replace(Badword, replacement);
            }

            Console.WriteLine(text);
        }
    }
}
