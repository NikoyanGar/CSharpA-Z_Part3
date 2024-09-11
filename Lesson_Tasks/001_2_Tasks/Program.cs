namespace _001_2_Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task taskWithotResult = new Task(() => Console.WriteLine("Hello, World!"));
            //taskWithotResult.Start();
            //taskWithotResult.GetAwaiter().GetResult();
            Console.WriteLine("Main start");
            Task<int> taskWithResult1 = Task.Run(() => CalculateLength("Hello, World!"));
            var res = taskWithResult1.Result;//blocking operation
            Console.WriteLine("Main end");
            Console.ReadKey();
        }
        public static int CalculateLength(string text)
        {
            Console.WriteLine($"Start CalculateLength in ManagedThreadId: {Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(1000);
            return text.Length;
        }
    }
}
