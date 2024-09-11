namespace _001_3_Threads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating threads manually
            Thread thread1 = new Thread(DoWork);
            Thread thread2 = new Thread(DoWork);

            thread1.Start("Thread 1");
            thread2.Start("Thread 2");

            // Using the ThreadPool
            ThreadPool.QueueUserWorkItem(DoWork, "ThreadPool 1");
            ThreadPool.QueueUserWorkItem(DoWork, "ThreadPool 2");

            Console.WriteLine("Main thread is doing some other work...");

            // Wait for the manually created threads to finish
            thread1.Join();
            thread2.Join();

            Console.WriteLine("All threads have finished their work.");
        }

        static void DoWork(object threadName)
        {
            Console.WriteLine($"Thread '{threadName}' is starting its work...");
            Thread.Sleep(2000); // Simulate some work being done
            Console.WriteLine($"Thread '{threadName}' has finished its work.");
        }
    }
}
