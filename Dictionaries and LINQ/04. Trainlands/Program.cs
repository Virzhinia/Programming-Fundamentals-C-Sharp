using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Trainlands
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            Dictionary<string, Dictionary<string, int>> TrainDict = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                input = Console.ReadLine();

                if (input == "It's Training Men!")
                {
                    break;
                }

                var inputArr = input.Split(' ');

                if (inputArr.Length == 3)
                {
                    string trainOne = inputArr[0];
                    string action = inputArr[1];
                    string trainTwo = inputArr[2];

                    if (action == "->")
                    {
                        if(!TrainDict.ContainsKey(trainOne))
                        {
                            TrainDict.Add(trainOne, new Dictionary<string, int>());
                        }

                        foreach (var wagons in TrainDict[trainTwo])
                        {
                            TrainDict[trainOne].Add(wagons.Key, wagons.Value);
                        }

                        TrainDict.Remove(trainTwo);
                    }

                    if (action == "=")
                    {
                        if (TrainDict.ContainsKey(trainOne))
                        {
                            TrainDict.Remove(trainOne);
                        }
                            if (!TrainDict.ContainsKey(trainOne))
                        {
                            TrainDict.Add(trainOne, new Dictionary<string, int>());
                        }
                        
                        foreach (var wagons in TrainDict[trainTwo])
                        {
                            TrainDict[trainOne].Add(wagons.Key, wagons.Value);
                        }
                    }
                }

                else
                {
                    inputArr = input
                        .Split(new char[] { ' ', '-', ':', '>', '=' }, StringSplitOptions.RemoveEmptyEntries);

                    string trainName = inputArr[0];
                    string wagonName = inputArr[1];
                    int wagonPower = int.Parse(inputArr[2]);

                    if (!TrainDict.ContainsKey(trainName))
                    {
                        TrainDict.Add(trainName, new Dictionary<string, int>());
                    }

                    TrainDict[trainName].Add(wagonName, wagonPower);
                }
            }

            foreach (var train in TrainDict.OrderByDescending(x=>x.Value.Values.Sum()))
            {
                Console.WriteLine($"Train: {train.Key}");

                foreach (var wagons in train.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"###{wagons.Key} - {wagons.Value}");
                }

            }
        }
    }
}
