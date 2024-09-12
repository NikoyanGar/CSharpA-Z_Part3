namespace _001_Tasks_Exceptions_in_other_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var task = Task.Run(() => MethodThatThrowsException());
                //task.Wait();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.GetType());
            }
            Thread.Sleep(1000);
            Console.WriteLine("Main finished");
            Console.ReadKey();
        }

        static void MethodThatThrowsException()
        {
            Console.WriteLine("start MethodThatThrowsException");
            throw new Exception("Exception in MethodThatThrowsException");
        }
    }
}
