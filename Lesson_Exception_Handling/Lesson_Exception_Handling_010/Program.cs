namespace Lesson_Exception_Handling_010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Method(1);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally");
            }

            Console.ReadLine();
        }

        static void Method(int i)
        {
            int[] arr = new int[1024 * 1024 * 1024 / 4];// 1,073,741,824 bytes(1 gigabyte).
            Console.WriteLine("Rec " + i);
            Method(++i);
        }
    }
}
