namespace _04_MergeFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText("input1.txt",
                "1\r\n" +
                "3\r\n" +
                "5\r\n");
            File.WriteAllText("input2.txt", 
                "2\r\n" +
                "4\r\n" +
                "6\r\n");

            string[] firstFile = File.ReadAllLines("input1.txt");
            string[] secondFile = File.ReadAllLines("input2.txt");

            int maxLines = Math.Max(firstFile.Length, secondFile.Length);
            using (StreamWriter writer = new StreamWriter("output.txt")) 
            for (int i = 0; i < maxLines; i++)
            {
                if(i < firstFile.Length)
                {
                    writer.WriteLine(firstFile[i]);
                }
                if(i < secondFile.Length)
                    {
                        writer.WriteLine(secondFile[i]);
                    }
            }
        }
    }
}