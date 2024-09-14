namespace _002_Files
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sourceFilePath = @"C:\Users\Public\source.txt";
            var destinationFilePath = @"C:\Users\Public\destination.txt";

            FileInfo sourceFile = new FileInfo(sourceFilePath);
            FileInfo destinationFile = new FileInfo(destinationFilePath);

            sourceFile.CopyTo(destinationFilePath, true);
            destinationFile.Delete();

            if (sourceFile.Exists)
            {
                var content = sourceFile.OpenRead();//file stream
                Console.WriteLine(content);
            }
            else
            {
                Console.WriteLine("File does not exist");
            }

            if (sourceFile.Exists)
            {
                var content = sourceFile.OpenText();//stream reader
                Console.WriteLine(content);
            }
            else
            {
                Console.WriteLine("File does not exist");
            }
            var stream = sourceFile.OpenWrite();

            stream.Write(new byte[] { 1, 2, 3 }, 0, 3);
            stream.Close();
        }
    }
}
