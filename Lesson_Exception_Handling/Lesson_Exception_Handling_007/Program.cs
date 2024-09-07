namespace Lesson_Exception_Handling_007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 2;
            try
            {
                int a = 10 / (n - 2);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally");
            }
        }
    }
}
