namespace _06.Book_Library_Modification
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Globalization;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] books = Console.ReadLine().Split().ToArray();
                string nameofAuthor = books[1];
                decimal money = decimal.Parse(books[6]);
                DateTime date = DateTime.ParseExact(books[4], "dd.MM.yyyy", CultureInfo.InvariantCulture); ; 
            }

            DateTime startDate = DateTime.ParseExact(Console.ReadLine(), 
                "dd.MM.yyyy", CultureInfo.InvariantCulture);

            Dictionary<string, DateTime> filteredBooks = new Dictionary<string, DateTime>();
            for (int book = 0; book < books.Count; book++)
            {
                if (!filteredBooks.ContainsKey(myLibrary.books[book].title))
                {
                    filteredBooks.Add(myLibrary.books[book].title, myLibrary.books[book].releaseDate);
                }
                else filteredBooks[myLibrary.books[book].title] = myLibrary.books[book].releaseDate;
            }


            foreach (var book in filteredBooks.Where(x => x.Value > startDate).OrderBy(x => x.Value).ThenBy(x => x.Key))
            {
                string date = book.Value.ToString("dd.MM.yyyy");
                Console.WriteLine("{0:f2} -> {1:f2}", book.Key, date);
            }
        }
    }
}
