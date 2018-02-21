using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Dragon_Army
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<int>>> dragons = new 
                Dictionary<string, Dictionary<string, List<int>>>();

            int n = int.Parse(Console.ReadLine());

            List<Dragon> dragonss = new List<Dragon>();

            for (int i = 0; i < n; i++)
            {
                string[] commandArgs = Console.ReadLine().Split(new char[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries);

                Dragon dragon = new Dragon();
                dragon.Type = commandArgs[0];
                dragon.Name = commandArgs[1];
                dragon.Demage = int.Parse(commandArgs[2]);
                dragon.Health = int.Parse(commandArgs[3]);
                dragon.Armor = int.Parse(commandArgs[4]);

            }
            

            foreach (var dragon in dragonss.Select(d=>d.Type).Distinct())
            {
                var avarageDemage = dragonss.Where(d=>d.Type==ty)
            Console.WriteLine($"{dragonss.FirstOrDefault(d=> d.Name))}::()");
                foreach (var VARIABLE in dragonss.Where(d=>d.Type==typee))
                {

                }
            }
        }

        public class Dragon
        {
            public string Type { get; set; }

            public string Name { get; set; }

            public int Demage { get; set; }

            public int Health { get; set; }

            public int Armor { get; set; }


        }
    }
}
