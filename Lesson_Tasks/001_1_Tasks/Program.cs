namespace _001_1_Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Number of Cores: {Environment.ProcessorCount}");
            Console.WriteLine($"Current Managed Thread ID: {Thread.CurrentThread.ManagedThreadId}");

            Task thread = new Task(() => PrintPluses(20));
            Task thread1 = new Task(() => PrintMinuss(20));
            //PrintPluses(20);
            //PrintMinuss(20);
            thread.Start();
            thread1.Start();
            Console.ReadKey();
        }
        public static void PrintPluses(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Thread.Sleep(20);
                Console.Write("+");
            }
        }
        public static void PrintMinuss(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Thread.Sleep(20);
                Console.Write("-");
            }
        }
    }
}

