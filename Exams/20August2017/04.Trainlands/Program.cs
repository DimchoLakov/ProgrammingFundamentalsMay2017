using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Trainlands
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> trainData = new Dictionary<string, Dictionary<string, int>>();

            string input = Console.ReadLine();

            while (input != "It's Training Men!")
            {
                string[] tokensTrainWagonPower =
                    input.Split(new string[] {" -> ", " : "}, StringSplitOptions.RemoveEmptyEntries);
                
                string[] tokensEqualOtherTrain =
                    input.Split(new string[] {" = "}, StringSplitOptions.RemoveEmptyEntries);

                if (tokensTrainWagonPower.Length == 3)
                {
                    string locoName = tokensTrainWagonPower[0];
                    string wagonName = tokensTrainWagonPower[1];
                    int wagonPower = int.Parse(tokensTrainWagonPower[2]);

                    if (! trainData.ContainsKey(locoName))
                    {
                        trainData.Add(locoName, new Dictionary<string, int>());
                    }
                    trainData[locoName].Add(wagonName, wagonPower);

                }
                else if (tokensTrainWagonPower.Length == 2)
                {
                    string[] tokensGreaterOtherTrain = 
                        input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

                    string firstTrain = tokensGreaterOtherTrain[0];
                    string otherTrain = tokensGreaterOtherTrain[1];

                    if (! trainData.ContainsKey(firstTrain))
                    {
                        trainData.Add(firstTrain, new Dictionary<string, int>());
                        foreach (var wagonPowerPair in trainData[otherTrain])
                        {
                            trainData[firstTrain].Add(wagonPowerPair.Key, wagonPowerPair.Value);
                        }
                        trainData.Remove(otherTrain);
                    }
                    else
                    {
                        foreach (var wagonPowerPair in trainData[otherTrain])
                        {
                            trainData[firstTrain].Add(wagonPowerPair.Key, wagonPowerPair.Value);
                        }
                        trainData.Remove(otherTrain);
                    }

                }
                else if (tokensEqualOtherTrain.Length == 2)
                {
                    string firstTrain = tokensEqualOtherTrain[0];
                    string otherTrain = tokensEqualOtherTrain[1];

                    if (! trainData.ContainsKey(firstTrain))
                    {
                        trainData.Add(firstTrain, new Dictionary<string, int>());
                        foreach (var wagonPowerPair in trainData[otherTrain])
                        {
                            trainData[firstTrain].Add(wagonPowerPair.Key, wagonPowerPair.Value);
                        }
                    }
                    else
                    {
                        trainData[firstTrain].Clear();
                        foreach (var wagonPowerPair in trainData[otherTrain])
                        {
                            trainData[firstTrain].Add(wagonPowerPair.Key, wagonPowerPair.Value);
                        }
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var trains in trainData.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Value.Count))
            {
                Console.WriteLine($"Train: {trains.Key}");
                foreach (var wagons in trains.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"###{wagons.Key} - {wagons.Value}");
                }
            }

        }
    }
}
