using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();

            switch (parameter)
            {
                case "face":FaceCube(side); break;
                case "space": SpaceCube(side); break;
                case "volume": VolumeCube(side); break;
                case "area":AreaCube(side); break;
            }
        }

        static void FaceCube (double side)
        {
            double face = Math.Sqrt(2 * side * side);
            Console.WriteLine($"{face:F2}");
        }
        static void SpaceCube(double side)
        {
            double space = Math.Sqrt(3 * side * side);
            Console.WriteLine($"{space:F2}");
        }
        static void VolumeCube (double side)
        {
            double volume = side * side * side;
            Console.WriteLine($"{volume:F2}");
        }
        static void AreaCube (double side)
        {
            double area = 6 * side * side;
            Console.WriteLine($"{area:F2}");
        }
    }
}
