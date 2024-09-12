namespace _001_Tasks_Exceptions_asyncron_handle
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var task = Task.Run(() => MethodThatThrowsException())
                .ContinueWith(
                faultedTask => Console.WriteLine($"Exception caught :{faultedTask.Exception.Message}"), TaskContinuationOptions.OnlyOnFaulted);
            //task.Wait();

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
