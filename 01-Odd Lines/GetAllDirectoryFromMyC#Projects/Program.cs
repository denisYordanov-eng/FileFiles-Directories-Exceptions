
namespace GetAllDirectoryFromC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListFile(@"C:\Users\Laptop\Desktop\C#");
        }

        private static void ListFile(string path)
        {
            var getFiles = Directory.GetFiles(path);

            foreach (var file in getFiles)
            {
                Console.WriteLine(file);
            }
            var subdirs = Directory.GetDirectories(path);
            foreach (var d in subdirs)
            {
                ListFile(d);
            }
        }
    }
}
