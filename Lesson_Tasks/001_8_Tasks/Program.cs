namespace _001_8_Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main start");
            var task = Task.Run(() => NeverEndingTask());
            Console.WriteLine("Main finished");
            Console.ReadKey();
        }
        static void NeverEndingTask()
        {
            while (true)
            {
                Console.WriteLine("NeverEndingTask working");
                Thread.Sleep(1000);
            }
        }
    }
}
