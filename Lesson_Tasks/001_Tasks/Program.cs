namespace _001_Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Thread.CurrentThread.Name = "Main";
            // Create a task and supply a user delegate by using a lambda expression. 
            var task = new Task(WorkerMethod);
            //var task1 = new Task(new Action(() => WorkerMethod()));
            // Continue with the main thread

            // Wait for the worker task to complete
            task.Start();
                        // Output a message from the calling thread.
            Console.WriteLine("Hello from thread '{0}'.", Thread.CurrentThread.Name);

            Console.ReadLine();
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
