using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostFrequentNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText("input.txt", "4 1 1 4 2 3 4 4 1 2 4 9 3");

            var input = File.ReadAllText("input.txt");

            int[] numbers = input.Split(' ').Select(int.Parse).ToArray();
                  

            List<int> currentSequence = new List<int>();
            List<int> bestSequence = new List<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];
                for (int j = i; j < numbers.Length; j++)
                {
                    int numberToCheck = numbers[j];
                    if (currentNumber == numberToCheck)
                    {

                        currentSequence.Add(numberToCheck);

                    }
                }
                if (currentSequence.Count > bestSequence.Count)
                {
                    bestSequence.Clear();
                    bestSequence = new List<int>();
                    bestSequence.AddRange(currentSequence);


                }
                currentSequence.Clear();
            }
            int theMostFrequentNumber = bestSequence[0];
            var output = new StringBuilder();
            File.WriteAllText("output.txt", theMostFrequentNumber.ToString());
        }
    }
}
