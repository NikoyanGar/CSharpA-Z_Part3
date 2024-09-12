namespace _001_AsyncronyVsMultithread
{
    //Debug it
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"main start in thread Id:{Thread.CurrentThread.ManagedThreadId}");
            var task = RunHeavyProcess();
            Console.WriteLine("Doing other Work");
            Console.WriteLine("Doing even more other Work");
            Console.ReadKey();
        }
        static async Task RunHeavyProcess()
        {
            Console.WriteLine($"RunHeavyProcess start in thread Id:{Thread.CurrentThread.ManagedThreadId}");
            string result = await HeavyProcess();
            Console.WriteLine($"RunHeavyProcess END in thread Id:{Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine(result);
        }

        static async Task<string> HeavyProcess()
        {
            Console.WriteLine($"HeavyProcess start in thread Id:{Thread.CurrentThread.ManagedThreadId}");
            //Thread.Sleep(5000);
            await Task.Delay(5000);
            Console.WriteLine($"HeavyProcess END in thread Id:{Thread.CurrentThread.ManagedThreadId}");
            return "Done";
        }
    }
}
