namespace _005_Threads_Priorities
{
    //Inside the Program class, there are two static variables defined:
    //count and break.
    //The count variable is used to keep track of the number of iterations in the Worker method,
    //while the break variable is used as a flag to control the loop in the Worker method.
    internal class Program
    {
        //When a variable is marked with the [ThreadStatic] attribute,
        //each thread will have its own separate copy of that variable.
        //This means that each thread can independently modify and access its own
        //version of the variable without affecting the values of the variable in other threads.
        [ThreadStatic]
        private static int count = 0;
        private static volatile bool @break = false;
        static void Main(string[] args)
        {
            var threads = Enum.GetValues(typeof(ThreadPriority))
                .Cast<ThreadPriority>()
                .OrderByDescending(p => p)
                .Select(priority => new Thread(Worker) { Priority = priority, Name = priority.ToString() })
                .ToList();

            threads.ForEach(t => t.Start());

            Thread.Sleep(20000);
            @break = true;
        }

        private static void Worker()
        {
            while (!@break)
            {
                count++;
            }

            decimal value = (decimal)count / 1000;
            Console.WriteLine($"{Thread.CurrentThread.Name} - {Math.Round(value, 0)}");
        }
    }
}

