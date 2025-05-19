using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_MaxSequenceOfEqualElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText("input.txt", "3 4 4 5 5 5 2 2");

            var input = File.ReadAllText("input.txt");

            int[] numbers = input
                .Split(' ')
                .Select(n => int.Parse(n))
                .ToArray();

            List<int> currentSequence = new List<int>();
            List<int> bestSequence = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];
                for (int j = i;  j < numbers.Length; j++)
                {
                    int numberToCompare = numbers[j];
                    if (currentNumber == numberToCompare)
                    {
                       currentSequence.Add(numberToCompare);
                    }
                }
                if(currentSequence.Count > bestSequence.Count)
                {
                    bestSequence.Clear();
                    bestSequence = new List<int>();
                    bestSequence.AddRange(currentSequence);
                }
                currentSequence.Clear();
            }
            string outputLine = (string.Join(" ", bestSequence.ToString()));
            var output = new StringBuilder();

            File.WriteAllText("output.txt",outputLine);
        }
    }
}
