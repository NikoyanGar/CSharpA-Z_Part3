namespace Lesson_Exception_Handling_018
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Method2SomeException();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An exception occurred:");
                Console.WriteLine(ex.StackTrace);
            }
        }

        static void Method1SomeException()
        {
            throw new Exception("Exception from Method1SomeException.");
        }
        static void Method2SomeException()
        {
            try
            {
                Method1SomeException();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                throw ex;// stack trace is reset
            }

        }
    }
}
