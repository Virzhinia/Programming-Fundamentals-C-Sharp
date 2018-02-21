using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Objects_and_Classes
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            DateTime myDate = DateTime.ParseExact(input, "d-m-yyyy",
                CultureInfo.InvariantCulture);

            Console.WriteLine(myDate.DayOfWeek);

        }
    }
}
