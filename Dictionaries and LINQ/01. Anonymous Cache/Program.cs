using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Anonymous_Cache
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> DataDict = 
                new Dictionary<string, Dictionary<string, long>>();

            List<string> DataList = new List<string>();

            var input ="";

            while (true)
            {
                input = Console.ReadLine();

                if(input== "thetinggoesskrra")
                {
                    break;
                }

                var inputArr = input.Split(new char[] { ' ', '-', '>', '|' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                if(inputArr.Length==1)
                {
                    DataList.Add(input);
                }

                else
                {
                    var dataKey = inputArr[0];
                    var dataSize = long.Parse(inputArr[1]);
                    var dataSet = inputArr[2];

                    if(!DataDict.ContainsKey(dataSet))
                    {
                        DataDict[dataSet] = new Dictionary<string,long>();
                    }
                    DataDict[dataSet][dataKey] = dataSize;
                }
            }

            DataDict.ToList()
                .Where(e => !DataList.Contains(e.Key))
                .ToList()
                .ForEach(e => DataDict.Remove(e.Key));

            if(DataDict.Count>0)
            {
                var result = DataDict
                    .OrderByDescending(x => x.Value.Sum(e => e.Value))
                    .First();

                Console.WriteLine($"Data Set: {result.Key}, Total Size: {result.Value.Sum(e=>e.Value)}");

                foreach (var item in result.Value)
                {
                    Console.WriteLine($"$.{item.Key}");
                }
            }
        }
    }
}
