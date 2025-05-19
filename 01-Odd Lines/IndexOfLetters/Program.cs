using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace IndexOfLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText("input.txt", "softuni");
            var inputWord = File.ReadAllText("input.txt");
           
            for (int i = 0; i < inputWord.Length; i++)
            {
                char letter = inputWord[i];

                int index = Math.Abs(letter - 97);
                File.AppendAllText("output.txt", $"{letter} -> {index}\r\n");
            }

        }
    }
}
