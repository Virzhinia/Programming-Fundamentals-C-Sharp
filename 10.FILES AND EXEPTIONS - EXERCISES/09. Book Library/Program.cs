using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Book_Library
{
    class LIbrary
    {
        public string Name { get; set; }
        public Book Books { get; set; }
    }
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ISBN { get; set; }
        public double Price { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader(@"../../input.txt");

            int n = int.Parse(reader.ReadLine());

            Dictionary<string, double> record = new Dictionary<string, double>();

            for (int i = 0; i < n; i++)
            {
                string[] tokens = reader.ReadLine().Split();

                string title = tokens[0];
                string author = tokens[1];
                string publisher = tokens[2];
                DateTime releaseDate = DateTime.ParseExact(tokens[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                string isbn = tokens[4];
                double price = double.Parse(tokens[5]);

                Book currentBook = new Book()
                {
                    Title = title,
                    Author = author,
                    Publisher = publisher,
                    ReleaseDate = releaseDate,
                    ISBN = isbn,
                    Price = price
                };

                LIbrary currentLib = new LIbrary()
                {
                    Name = author,
                    Books = currentBook
                };

                if (!record.ContainsKey(currentLib.Name))
                {
                    record.Add(currentLib.Name, 0);
                }
                record[currentLib.Name] += currentLib.Books.Price;
            }

            foreach (KeyValuePair<string, double> book in
                record.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                File.AppendAllText(@"../../output.txt", book.Key + " -> " + string.Format("{0:f2}", book.Value) + Environment.NewLine);
            }
        }
    }
}
