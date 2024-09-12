namespace _003_AsyncAwait
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var task = RunHeavyProcess();
            Console.WriteLine("Doing other Work");
            Console.WriteLine("Doing even more other Work");
            Console.ReadKey();
        }
        static async Task RunHeavyProcess()
        {
            Console.WriteLine("RunHeavyProcess start");
            string result = await HeavyProcess();
            Console.WriteLine(result);

        }

        static async Task<string> HeavyProcess()
        {
            Console.WriteLine("Heavy process started");
            Thread.Sleep(5000);
            Console.WriteLine("Heavy process finished");
            return "Done";
        }
    }
}
