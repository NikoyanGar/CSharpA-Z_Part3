namespace Lesson_Exception_Handling_011
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new Exception();
            }
            catch (Exception ex)
            {
                throw new Exception("Exception from Catch.");

                //while(true)
                //    Console.WriteLine("Catch.");
            }
            finally
            {
                Console.WriteLine("Finally.");
            }

        }
    }
}
