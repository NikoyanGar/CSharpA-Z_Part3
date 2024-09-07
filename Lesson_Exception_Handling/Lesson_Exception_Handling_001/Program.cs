namespace Lesson_Exception_Handling_001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string filePath = @"C:\Users\Asus\OneDrive - HighWay CJSC\Desktop\pg.txt";
                string content = File.ReadAllText(filePath);
                Console.WriteLine(content);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"File not found: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Execution completed.");
            }
        }
    }
}
