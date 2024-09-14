namespace _001_Files_Path
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\Public\source.txt";
            var dotIndx = path.IndexOf('.');
            var extension = path.Substring(dotIndx);
            Console.WriteLine("Extension: " + extension);
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Extension: " + Path.GetExtension(path));
            Console.WriteLine("File Name: " + Path.GetFileName(path));
            Console.WriteLine("File Name without Extension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine(Path.GetDirectoryName(path));
        }
    }
}
