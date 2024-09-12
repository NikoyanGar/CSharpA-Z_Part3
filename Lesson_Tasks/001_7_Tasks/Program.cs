namespace _001_7_Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Task task = Task.Run(() => CalculateLength("Hello"))
                .ContinueWith(taskWithResult => Console.WriteLine(taskWithResult
                .Result)).ContinueWith(completed =>
                {
                    Console.WriteLine($"Start Second continuation in ManagedThreadId: {Thread.CurrentThread.ManagedThreadId}");
                    Thread.Sleep(3000);
                    Console.WriteLine($"Finished Second continuation in ManagedThreadId: {Thread.CurrentThread.ManagedThreadId}");
                });

            var tasks = new[]
            {
                Task.Run(() => CalculateLength("Hello")),
                Task.Run(() => CalculateLength("Hello1")),
                Task.Run(() => CalculateLength("Hello22"))
            };

            var contiunationTask = Task.Factory.ContinueWhenAll(tasks, completedTasks =>
            {
                Console.WriteLine(string.Join(", ", completedTasks.Select(task => task.Result)));
            });

            //var taskWhenAll = Task.WhenAll(tasks).ContinueWith(completed =>
            //{
            //    Console.WriteLine($"Start WhenAll continuation in ManagedThreadId: {Thread.CurrentThread.ManagedThreadId}");
            //    Thread.Sleep(3000);
            //    foreach (var task in tasks)
            //    {
            //        Console.WriteLine($"Task {task.Id} result: {task.Result}");
            //    }
            //    Console.WriteLine($"Finished WhenAll continuation in ManagedThreadId: {Thread.CurrentThread.ManagedThreadId}");
            //});
        }
        public static int CalculateLength(string? text)
        {
            if (text == null)
            {
                return 0;
            }
            Console.WriteLine($"Start CalculateLength in ManagedThreadId: {Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(3000);
            Console.WriteLine("CalculateLength finished");
            return text.Length;
        }
    }
}
