namespace _001_5_Threads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Create a new thread and start it
            Thread thread = new Thread(() =>
            {
                string str = "Example string";
                int length = GetLength(str);
                Console.WriteLine($"Length of the string: {length}");
            });
            thread.Start();

            // Continue with the main thread
            Console.WriteLine("Main thread continues...");

            // Wait for the worker thread to finish
            thread.Join();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        static int GetLength(string str)
        {
            Console.WriteLine("Worker thread is running.");
            // Perform some work here...
            Thread.Sleep(3000); // Simulating work by sleeping for 3 seconds
            Console.WriteLine("Worker thread finished.");
            return str.Length;
        }
    }
}
