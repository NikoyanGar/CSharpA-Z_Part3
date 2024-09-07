namespace Lesson_Exception_Handling_003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object obj = null;
            try
            {
                if (obj == null)
                    throw new Exception("message!!!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }

        static int GetMax(int[] arr)
        {
            if (arr == null)
                throw new Exception("Array is null");

            return arr.Max();
        }
    }
}
