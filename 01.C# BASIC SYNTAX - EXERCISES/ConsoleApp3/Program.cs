using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            var volume = double.Parse(Console.ReadLine());
            var energyPer100ml = double.Parse(Console.ReadLine());
            var sugarPer100ml = double.Parse(Console.ReadLine());

            var kcal = Math.Round((volume * energyPer100ml)/100,2);
            var sugars = Math.Round((sugarPer100ml*volume)/ 100,2);

            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{kcal}kcal, {sugars}g sugars");
        }
    }
}
