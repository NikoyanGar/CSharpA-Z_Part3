namespace Lesson_Exception_Handling_013
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new NullReferenceException("message");
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
