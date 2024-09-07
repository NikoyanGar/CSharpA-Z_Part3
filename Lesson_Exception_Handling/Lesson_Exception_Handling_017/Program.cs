namespace Lesson_Exception_Handling_017
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DivideByZero();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An exception occurred:");
                Console.WriteLine(ex.StackTrace);
            }
        }

        static void DivideByZero()
        {
            int numerator = 10;
            int denominator = 0;
            int result = numerator / denominator;
        }
    }
}
