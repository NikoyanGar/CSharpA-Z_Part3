using System;
using System.Threading;

namespace _003_Threads
{
    internal class Program
    {
        private static readonly object ConsoleLock = new();

        static void Main(string[] args)
        {
            var thread1 = new Thread(() => ThreadFunc("."));
            var thread2 = new Thread(() => ThreadFunc("$"));
            var thread3 = new Thread(() => ThreadFunc("-"));

            thread1.Start();
            thread2.Start();
            thread3.Start();

            thread1.Join();
            thread2.Join();
            thread3.Join();

            // Process-wide managed heap size snapshot (not per-thread)
            long memoryUsage = GC.GetTotalMemory(false);
            Console.WriteLine("memory usage: is {0} bytes", memoryUsage);

            Console.ReadLine();
        }

        private static void ThreadFunc(string symbol)
        {
            Console.WriteLine("Secondary thread id: {0}", Thread.CurrentThread.ManagedThreadId);

            // Baseline this thread's allocations
            long baseline = GC.GetAllocatedBytesForCurrentThread();

            Struct_512KB a512 = new Struct_512KB();
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(20);
                Console.Write(symbol);

                if ((i + 1) % 25 == 0)
                {
                    long soFar = GC.GetAllocatedBytesForCurrentThread() - baseline;
                    lock (ConsoleLock)
                    {
                        Console.WriteLine("  | T{0} allocated so far: ~{1:N0} bytes", 
                            Thread.CurrentThread.ManagedThreadId, soFar);
                        Console.Out.Flush();
                    }
                }
            }

            long total = GC.GetAllocatedBytesForCurrentThread() - baseline;
            lock (ConsoleLock)
            {
                Console.WriteLine("\nThread {0} total allocated: ~{1:N0} bytes",
                    Thread.CurrentThread.ManagedThreadId, total);
            }
        }
    }
}
