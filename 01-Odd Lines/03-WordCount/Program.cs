namespace _03_WordCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
          File.WriteAllText("input.txt",
                "-I was quick to judge him, but it wasn't his fault.\r\n" +
                "-Is this some kind of joke?! Is it?\r\n" +
                "-Quick, hide here…It is safer.\r\n");
            File.WriteAllText("words.txt", "quick is fault");

            string[] words = File.ReadAllText("words.txt").ToLower().Split();
            string[] text = File.ReadAllText("input.txt").ToLower()
                .Split(new[] { '\r', '\n', ',', '.', ' ', '!', '?', '-' },
                StringSplitOptions.RemoveEmptyEntries);

            var wordCount = new Dictionary<string, int>();
            foreach (string word in words)
            {
                wordCount[word] = 0;
            }
            
            foreach (string word in text)
            {
                if (wordCount.ContainsKey(word))
                {
                    wordCount[word]++;
                }
            }
            var sortedWordIndex = wordCount.OrderByDescending(i => i.Value)
                .ThenBy(a => a.Key).ToDictionary();

            var outputLines = sortedWordIndex
                .Where(kvp => kvp.Value > 0)
                .Select(kvp => $"{kvp.Key} - {kvp.Value}");

            File.WriteAllLines("output.txt", outputLines);
        }
    }
}
