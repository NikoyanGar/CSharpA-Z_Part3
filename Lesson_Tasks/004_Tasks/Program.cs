using System.Threading;

namespace _004_Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task task = Task.Run(() => ThreadFunc(ConsoleColor.Yellow));
            Task task1 = Task.Run(() => ThreadFunc1(ConsoleColor.Red));

            Console.WriteLine("Main thread id: {0} \n", Thread.CurrentThread.ManagedThreadId);

            Task.WaitAll(task,task1);

            Console.ForegroundColor = ConsoleColor.Green;

            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(100);
                Console.Write("_");
            }

            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("\nMain thread ended.");

            Console.ReadLine();
        }

        private static void ThreadFunc(ConsoleColor color)
        {
            Console.WriteLine("ThreadFunc method from task id: {0}, ThreadId:{1} start work", Task.CurrentId, Thread.CurrentThread.ManagedThreadId);
            Console.ForegroundColor = color;

            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(20);
                Console.Write(".");
            }

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();
            Console.WriteLine("ThreadFunc method from task id: {0}, ThreadId:{1} end work", Task.CurrentId, Thread.CurrentThread.ManagedThreadId);
        }

        private static void ThreadFunc1(ConsoleColor color)
        {
            Console.WriteLine("ThreadFunc1 method from task id: {0}, ThreadId:{1} start work", Task.CurrentId, Thread.CurrentThread.ManagedThreadId);
            Console.ForegroundColor = color;

            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(20);
                Console.Write("+");
            }

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();
            Console.WriteLine("ThreadFunc1 method from task id: {0}, ThreadId:{1} end work", Task.CurrentId, Thread.CurrentThread.ManagedThreadId);
        }
    }
}
