namespace _001_Tasks_multiple_continuatins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var task = new Task<int>(() => Divide(5, 2));

            task.ContinueWith(t => Console.WriteLine($"Result: {t.Result}"),
                TaskContinuationOptions.OnlyOnRanToCompletion);

            task.ContinueWith(t => Multiply(5, t.Result),
               TaskContinuationOptions.OnlyOnRanToCompletion);

            task.ContinueWith(t => Console.WriteLine($"Faulted: {t.Exception.InnerException.Message}"),
                TaskContinuationOptions.OnlyOnFaulted);


            task.Start();

            Thread.Sleep(1000);
            Console.WriteLine("Main finished");
            Console.ReadKey();
        }

        static int Multiply(int a, int b)
        {
            Console.WriteLine(a * b);
            return a * b;
        }

        static int Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("b cannot be zero");
            }
            return a / b;
        }
    }
}
