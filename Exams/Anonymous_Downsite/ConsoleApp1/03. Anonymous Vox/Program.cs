using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Anonymous_Vox
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> dataDic =
                new Dictionary<string, Dictionary<string, long>>();
            var sum = 0;
            string name = string.Empty;

            string[] input;
            long dataSize = 0;
            string datakey;

            while (true)
            {
                input = Console.ReadLine().Split(new char[] { ' ', '|', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

                if (input[0] == "thetinggoesskrra")
                {
                    break;
                }

                if (input.Length < 3)
                {
                    continue;
                }

                dataSize = long.Parse(input[1]);
                name = input[0];
                datakey = input[2];

              if(!dataDic.ContainsKey(name))
                {
                    dataDic.Add(name, new Dictionary<string, long>());
                    dataDic[name].Add(datakey, dataSize);
                }

              else
                {
                    dataDic[name].Add(datakey, dataSize);
                }
            }

            Console.WriteLine($"Data Set: {dataDic.Key(x=>x.Values)}, Total Size: {dataDic.Values.Sum()}");

            foreach (var item in dataDic[name])
            {
                Console.WriteLine($"$.{item.Key}");
            }

        }

       
    }
}
