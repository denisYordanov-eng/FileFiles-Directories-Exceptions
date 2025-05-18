namespace _05_FolderSize
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory("TestFolder");

            File.WriteAllText("TestFolder/file1.txt",
               new string("a"));
            File.WriteAllText("TestFolder/file2.txt",
                new string("b"));

            string[] files = Directory.GetFiles("testFolder");
            double sum = 0;
            foreach(string file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                sum += fileInfo.Length;
            }
            sum = sum / 1024 / 1024;
            File.WriteAllText("output.txt", sum.ToString());

            //File.WriteAllText("TestFolder/file1.txt", 
            //    new string('a', 1024 * 1024));
            //File.WriteAllText("TestFolder/file2.txt",
            //    new string('b', 1024 * 1024));
        }
    }
}
