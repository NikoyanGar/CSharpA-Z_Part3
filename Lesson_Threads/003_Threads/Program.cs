namespace _003_Threads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var thread1 = new Thread(() => ThreadFunc("."));
            var thread2 = new Thread(() => ThreadFunc("$"));
            var thread3 = new Thread(() => ThreadFunc("-"));

            thread1.Start();
            thread2.Start();
            thread3.Start();
            //thread1.Join();
            // Display the memory usage
            long memoryUsage = GC.GetTotalMemory(false);
            Console.WriteLine("memory usage: is {0} bytes", memoryUsage);
            Console.ReadLine();
        }

        private static void ThreadFunc(string symbol)
        {
            Console.WriteLine("Secondary thread id: {0}", Thread.CurrentThread.ManagedThreadId);
            Struct_512KB a512 = new Struct_512KB();
            Struct_512KB a512_1 = new Struct_512KB();
            //Struct_512KB a5122 = new Struct_512KB();
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(20);
                Console.Write(symbol);
            }
            // Display the current  memory usage
            //long memoryUsage = GC.GetTotalMemory(false);
            //Console.WriteLine("Current thread memory usage: from thread {0} is {1} bytes", Thread.CurrentThread.ManagedThreadId, memoryUsage);
        }
    }
}
