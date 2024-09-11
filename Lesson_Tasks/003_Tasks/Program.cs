namespace _003_Tasks
{
    internal class Program
    {
        // Main method
        static async Task Main(string[] args)
        {
            // Create a new Task object with the Worker method
            Task task = new Task(Worker);

            // Print the initial status of the task
            Console.WriteLine($"Task Status: {task.Status}");
            Console.WriteLine($"Task IsCompleted: {task.IsCompleted}");
            Console.WriteLine($"Task IsCanceled: {task.IsCanceled}");
            Console.WriteLine($"Task IsFaulted: {task.IsFaulted}");

            Console.WriteLine("---------------------------------------");

            // Start the task
            task.Start();

            // Print the status of the task after starting
            Console.WriteLine($"Task Status: {task.Status}");
            Console.WriteLine($"Task IsCompleted: {task.IsCompleted}");
            Console.WriteLine($"Task IsCanceled: {task.IsCanceled}");
            Console.WriteLine($"Task IsFaulted: {task.IsFaulted}");
            Console.WriteLine("---------------------------------------");

            // Wait for the task to complete
            task.GetAwaiter().GetResult();

            // Print the final status of the task
            Console.WriteLine($"Task Status: {task.Status}");
            Console.WriteLine($"Task IsCompleted: {task.IsCompleted}");
            Console.WriteLine($"Task IsCanceled: {task.IsCanceled}");
            Console.WriteLine($"Task IsFaulted: {task.IsFaulted}");

            Console.ReadLine();
        }

        // Worker method
        static void Worker()
        {
            // Print the start message with the current task ID
            Console.WriteLine("Worker() # " + Task.CurrentId + " Start.");

            // Perform some work in a loop
            for (int count = 0; count < 10; count++)
            {
                Thread.Sleep(500);

                // Print the current count and task ID
                Console.WriteLine("Worker() #" + Task.CurrentId + " count: " + count);
            }

            // Print the end message with the current task ID
            Console.WriteLine("Worker() # " + Task.CurrentId + " End.");
        }
    }
}
