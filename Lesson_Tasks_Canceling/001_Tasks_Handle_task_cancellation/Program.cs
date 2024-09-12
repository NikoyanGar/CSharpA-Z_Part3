namespace _001_Tasks_Handle_task_cancellation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main start");
            var cancellationTokenSource = new CancellationTokenSource();
            var task = Task.Run(() => NeverEndingTask(cancellationTokenSource),
                cancellationTokenSource.Token)
                .ContinueWith(canceledTask => Console.WriteLine("Task with Id:{canceledTask.Id}was cancelled"),
                TaskContinuationOptions.OnlyOnCanceled);

            Thread.Sleep(5000);
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