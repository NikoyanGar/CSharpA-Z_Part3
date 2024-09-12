using System.Diagnostics;

namespace _001_AsyncAwait
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //synchronously
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            var result = CalculateLength("Hello, World!");
            Print(result);
            Console.WriteLine("Process finished");
            stopwatch.Stop();

            //asynchronously
            var task = Task.Run(() => CalculateLength("Hello, World!"))
                .ContinueWith(completedtask => Print(completedtask.Result))
                .ContinueWith(previuscontiuation => Console.WriteLine("Process finished"));

            //it doesn't need calculate length and print 
            string userInput;
            do
            {
                Console.WriteLine("Enter command: ");
                userInput = Console.ReadLine();
            } while (userInput != "exit");

            Console.WriteLine($"All tasks completed. Elapsed time: {stopwatch.ElapsedMilliseconds} ms");
            Console.WriteLine("Main finished");
            Console.ReadKey();

        }
        static int CalculateLength(string? text)
        {
            if (text == null)
            {
                return 0;
            }
            Console.WriteLine($"Start CalculateLength in ManagedThreadId: {Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(3000);
            return text.Length;
        }
        static void Print(int length)
        {
            Console.WriteLine($"Start Print in ManagedThreadId: {Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(3000);
            Console.WriteLine($"Length: {length}");
        }
    }

}
