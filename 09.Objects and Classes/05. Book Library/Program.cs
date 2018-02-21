namespace _05.Book_Library
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Book
    {
        public string Name { get; set; }
    }
    class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, decimal> moneyMade = new Dictionary<string, decimal>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string nameofAuthor = input[1];
                decimal money = decimal.Parse(input[5]);
                if (!moneyMade.ContainsKey(nameofAuthor))
                {
                    moneyMade.Add(nameofAuthor, 0);
                }
                moneyMade[nameofAuthor] += money;
            }
            foreach (var item in moneyMade.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine(item.Key + " -> " + string.Format("{0:F2}", item.Value));
            }
        }
    }
}
