namespace _003_Files_Directory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory(@"C:\Users\Public\NewFolder");
            // *.* means all files
            //*.sln means all files with .sln extension
            var filePats = Directory.GetFiles(@"C:\Users\Public\NewFolder", "*.*", SearchOption.AllDirectories);
            foreach (var file in filePats)
            {
                Console.WriteLine(file);
            }
            var directories = Directory.GetDirectories(@"C:\Users\Public\NewFolder", "*.*", SearchOption.AllDirectories);
            foreach (var directory in directories)
            {
                Console.WriteLine(directory);
            }
            Directory.Exists(@"C:\Users\Public\NewFolder");


            var directoryInfo = new DirectoryInfo(@"C:\Users\Public\NewFolder");
            directoryInfo.Create();
        }
    }
}
