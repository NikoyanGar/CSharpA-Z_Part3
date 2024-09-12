namespace _001_Tasks_Exceptions_agregate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var task = Task.Run(() => Divide(10, 0))
                 .ContinueWith(
                 faultedTask => Console.WriteLine($"Exception caught :{faultedTask.Exception.Message}"), TaskContinuationOptions.OnlyOnFaulted);
            var task1 = Task.Run(() => Divide(10, null))
                .ContinueWith(
                faultedTask => Console.WriteLine($"Exception caught :{faultedTask.Exception.Message}"), TaskContinuationOptions.OnlyOnFaulted);

            var task2 = Task.Run(() => Divide(10, 2))
                .ContinueWith(
                faultedTask =>
                {
                    Console.WriteLine($"Exception caught :{faultedTask.Exception.Message}");
                    Console.WriteLine($"Inner exception :{faultedTask.Exception.InnerException.Message}");
                    faultedTask.Exception.Handle(ex =>
                    {
                        if (ex is ArgumentNullException)
                        {
                            Console.WriteLine("ArgumentNullException handled");
                            return true;//return true if exception is handled
                        }
                        if (ex is DivideByZeroException)
                        {
                            Console.WriteLine("ArgumentNullException handled");
                            return true;//return true if exception is handled
                        }
                        return false;//return false if exception is not handled
                    });
                },
                TaskContinuationOptions.OnlyOnFaulted);

            Thread.Sleep(1000);
            Console.WriteLine("Main finished");
            Console.ReadKey();
        }
        static float Divide(int? a, int? b)
        {
            if (a == null || b == null)
            {
                throw new ArgumentNullException("arguments cannot be null");
            }
            if (b == 0)
            {
                throw new DivideByZeroException("b cannot be zero");
            }
            return a.Value / b.Value;
        }
    }

}
