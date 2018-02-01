using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            string dataSet = Console.ReadLine();
            string newDataSet=string.Empty;
            string[] input;
            long dataSize = 0;
            Dictionary<string, long> dataDic = new Dictionary<string, long>();
            Dictionary<string, long> otherDataDic = new Dictionary<string, long>();

            while (true)
            {
                input = Console.ReadLine().Split(new char[] { ' ', '|', '-', '>' },StringSplitOptions.RemoveEmptyEntries);

                if(input[0]== "thetinggoesskrra")
                {
                    break;
                }

                if (input.Length<3)
                {
                    continue;
                }

                dataSize = long.Parse(input[1]);

                if(input.Length==3 && input[2]==dataSet)
                {
                    dataDic.Add(input[0], dataSize);
                }

                if(input[2]!=dataSet || )
                {
                    otherDataDic.Add(input[0], dataSize);
                    newDataSet = input[2];
                }

            }

            if (dataDic.Values.Sum() > otherDataDic.Values.Sum())
            {

                Console.WriteLine($"Data Set: {dataSet}, Total Size: {dataDic.Values.Sum()}");

                foreach (var item in dataDic)
                {
                    Console.WriteLine($"$.{item.Key}");
                }
            }
            else
            {
               
                Console.WriteLine($"Data Set: {newDataSet}, Total Size: {otherDataDic.Values.Sum()}");

                foreach (var item in otherDataDic)
                {
                    Console.WriteLine($"$.{item.Key}");
                }

            }
        }
    }
}
