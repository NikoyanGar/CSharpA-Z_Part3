namespace _001_1_Threads
{
    //Run and see threads view too
    //debug->threads
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Number of Cores: {Environment.ProcessorCount}");
            Console.WriteLine($"Current Managed Thread ID: {Thread.CurrentThread.ManagedThreadId}");

            PrintPluses(20);
            PrintMinuss(20);
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
