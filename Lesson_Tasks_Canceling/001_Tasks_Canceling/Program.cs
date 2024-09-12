namespace _001_Tasks_Canceling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main start");
            var cancellationTokenSource = new CancellationTokenSource();
            var task = Task.Run(() => NeverEndingTask(),
                cancellationTokenSource.Token);

            var task1 = Task.Run(() => NeverEndingTask(cancellationTokenSource),
                cancellationTokenSource.Token);

            Console.WriteLine("Main finished");
            cancellationTokenSource.Cancel();
            Console.ReadKey();
        }
        static void NeverEndingTask()
        {
            while (true)
            {
                Console.WriteLine("NeverEndingTask working");
                Thread.Sleep(1000);
            }
        }
        static void NeverEndingTask(CancellationTokenSource cancellationTokenSource)
        {
            while (true)
            {
                if (cancellationTokenSource.IsCancellationRequested)//cancellationTokenSource.Token.IsCancellationRequested
                {
                    Console.WriteLine("NeverEndingTask canceled");
                    break;//return;
                }
                Console.WriteLine("NeverEndingTask working");
                Thread.Sleep(1000);
            }
        }
    }
}
