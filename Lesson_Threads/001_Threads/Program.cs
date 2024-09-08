namespace _001_Threads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a new thread and specify the method to be executed
            Thread thread = new Thread(WorkerMethod);

            // Start the thread
            thread.Start();

            // Continue with the main thread
            Console.WriteLine("Hello, World!");

            // Wait for the worker thread to complete
            thread.Join();
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
