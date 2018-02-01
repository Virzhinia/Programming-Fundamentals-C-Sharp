using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Temperature_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            var fahrentheit = double.Parse(Console.ReadLine());
            var celsius = FahrentheitToCelsius(fahrentheit);
            Console.WriteLine("{0:F2}", celsius);
        }

        static double FahrentheitToCelsius(double fahrentheit)
        {
            return (fahrentheit-32)*5/9;
        }
    }
}
