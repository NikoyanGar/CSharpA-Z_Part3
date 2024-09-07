namespace Lesson_Exception_Handling_006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                try
                {

                }
                catch (Exception)
                {

                }
            }
            catch (Exception ex)
            {
                try
                {
                    try
                    {

                    }
                    catch (Exception ex1)
                    {
                    }
                }
                catch (Exception ex1)
                {
                }
            }
        }
    }
}
