namespace _001_Threads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a new thread and specify the method to be executed
            Thread t = new Thread(WorkerMethod);
            Console.WriteLine($"Жив ли поток? {t.IsAlive}");
            Console.WriteLine($"Фоновый ли поток? {t.IsBackground}");
            Console.WriteLine($"ID потока: {t.ManagedThreadId}");
            // Start the thread
            t.Start();



            // Wait for the worker thread to complete
            t.Join();
            Console.WriteLine($"Состояние после завершения: {t.ThreadState}");
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
