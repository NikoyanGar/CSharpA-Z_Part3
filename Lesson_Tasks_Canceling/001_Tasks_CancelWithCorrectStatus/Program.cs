namespace _001_Tasks_CancelWithCorrectStatus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main start");


            var cancellationTokenSource = new CancellationTokenSource();

            var task1 = Task.Run(() => NeverEndingTask(cancellationTokenSource),
                cancellationTokenSource.Token);
            Thread.Sleep(1000);
            cancellationTokenSource.Cancel();
            Thread.Sleep(1000);
            Console.WriteLine("Main finished");
            Console.ReadKey();
        }

        static void NeverEndingTask(CancellationTokenSource cancellationTokenSource)
        {
            while (true)
            {
                //cancellationTokenSource.Token.ThrowIfCancellationRequested();
                if (cancellationTokenSource.IsCancellationRequested)
                {
                    throw new OperationCanceledException(cancellationTokenSource.Token);
                }
                Console.WriteLine("NeverEndingTask working");
                Thread.Sleep(1000);
            }
        }
    }
}
