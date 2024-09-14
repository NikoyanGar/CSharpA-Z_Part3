namespace _001_Files
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var filePath = @"C:\Users\Public\source.txt";
            var filePath2 = "C:\\Users\\Public\\destination.txt";
            File.Copy("source.txt", "destination.txt", true);
            File.Delete("destination.txt");
            if (File.Exists(filePath))
            {
                var content = File.ReadAllText(filePath);
                Console.WriteLine(content);
            }
            else
            {
                Console.WriteLine("File does not exist");
            }
            if (File.Exists(filePath))
            {
                var content = File.ReadAllBytes(filePath);
                Console.WriteLine(content);
            }
            else
            {
                Console.WriteLine("File does not exist");
            }
            File.WriteAllText(filePath, "Hello World");
            File.AppendAllText(filePath, "Hello World");
            File.WriteAllLines(filePath, new[] { "Hello", "World" });
            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }
        }
    }
}
