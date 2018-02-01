using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            var emailBook = new Dictionary<string, string>();
            bool continueRead = true;

            while (continueRead)
            {
                string material = Console.ReadLine();

                if (material == "stop")
                {
                    continueRead = false;
                    foreach (var item in emailBook)
                    {
                        Console.WriteLine($"{item.Key} -> {item.Value}");
                    }
                }
                else
                {
                    string valueMaterial = Console.ReadLine();

                    if (emailBook.ContainsKey(material))
                    {
                        emailBook[material] += valueMaterial;
                    }
                    else
                    {
                        emailBook.Add(material, valueMaterial);
                    }

                }
            }


        }
    }
}