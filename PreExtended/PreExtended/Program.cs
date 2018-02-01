namespace PreExtended
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(new string('-', 2 *n));
            for (int i = 0; i < n-2; i++)
            {
            PrintMiddleRow(n);
            }
            Console.WriteLine(new string('-', 2 * n));

        }

        public static void PrintMiddleRow(int n)
        {
            Console.Write('-');

            for (int i = 1; i < n; i++)
            {
                Console.Write("\\/");
            }
            Console.Write('-');
            Console.WriteLine();
        }
    }
}
