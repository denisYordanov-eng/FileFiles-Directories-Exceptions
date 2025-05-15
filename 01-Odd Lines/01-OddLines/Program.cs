namespace _01_OddLines
{
    internal class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText("input.txt", "Two households, both alike in dignity,\r\n" +
                "In fair Verona, where we lay our scene,\r\n" +
                "From ancient grudge break to new mutiny,\r\n" +
                "Where civil blood makes civil hands unclean.\r\n" +
                "From forth the fatal loins of these two foes\r\n" +
                "A pair of star-cross'd lovers take their life;\r\n" +
                "Whose misadventured piteous overthrows\r\n" +
                "Do with their death bury their parents' strife.\r\n");

           var lines = File.ReadAllLines("input.txt");
            var oddLines =
                lines.Where((line,index) => index % 2 != 0);
            File.WriteAllLines("oddLines.txt", oddLines);
        }
    }
}
