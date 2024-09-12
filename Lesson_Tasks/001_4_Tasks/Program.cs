using System.Diagnostics;

namespace _001_4_Tasks
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            Task task1 = Task.Run(() => Task1Method());
            Task task2 = Task.Run(() => Task2Method());
            Task task3 = Task.Run(() => Task3Method());

            await Task.WhenAll(task1, task2, task3);

            stopwatch.Stop();
            Console.WriteLine($"All tasks completed. Elapsed time: {stopwatch.ElapsedMilliseconds} ms");
        }

        static void Task1Method()
        {
            Console.WriteLine($"Start Task1Method in ManagedThreadId: {System.Threading.Thread.CurrentThread.ManagedThreadId}");
            System.Threading.Thread.Sleep(3000);
        }

        static void Task2Method()
        {
            Console.WriteLine($"Start Task2Method in ManagedThreadId: {System.Threading.Thread.CurrentThread.ManagedThreadId}");
            System.Threading.Thread.Sleep(3000);
        }

        static void Task3Method()
        {
            Console.WriteLine($"Start Task3Method in ManagedThreadId: {System.Threading.Thread.CurrentThread.ManagedThreadId}");
            System.Threading.Thread.Sleep(3000);
        }
    }
}
