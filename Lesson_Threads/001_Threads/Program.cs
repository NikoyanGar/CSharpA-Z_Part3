namespace _001_Threads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a new thread and specify the method to be executed
            Thread t = new Thread(WorkerMethod);
            Console.WriteLine($"IsAlive: {t.IsAlive}");
            Console.WriteLine($"IsBackground {t.IsBackground}");
            Console.WriteLine($"ID of thread: {t.ManagedThreadId}");
            Console.WriteLine($"before start: {t.ThreadState}");

            // Start the thread
            t.Start();

            Console.WriteLine($"after start before join: {t.ThreadState}");


            // Wait for the worker thread to complete
            t.Join();
            Console.WriteLine($"after join: {t.ThreadState}");
            // Continue with the main thread
            Console.WriteLine("Hello, World!");
        }

        static void WorkerMethod()
        {
            // Simulate some work
            Thread.Sleep(2000);

            // Print a message
            Console.WriteLine("Worker thread completed");
        }
    }
}
