namespace _001_4_Threads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Start a new thread to perform work
            Thread workerThread = new Thread(DoWork);
            workerThread.Start();

            // Continue with main thread (user interaction thread)
            Console.WriteLine("Main thread is running.");

            // Read input from console
            string input = Console.ReadLine();
            Console.WriteLine("You entered: " + input);

            // Wait for the worker thread to complete
            workerThread.Join();

            Console.WriteLine("Main thread finished.");
        }

        static void DoWork()
        {
            Console.WriteLine("Worker thread is running.");
            // Perform some work here...
            Thread.Sleep(3000); // Simulating work by sleeping for 3 seconds
            Console.WriteLine("Worker thread finished.");
        }
    }
}
