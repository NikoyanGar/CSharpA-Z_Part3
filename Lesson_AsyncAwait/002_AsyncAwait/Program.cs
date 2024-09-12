namespace _002_AsyncAwait
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
        static Task RunHeavyProcess()
        {
            return Task.Run(() => HeavyProcess())
                .ContinueWith(completedTask => Console.WriteLine(completedTask.Result));
        }
        //await keyword means.start HeavyProcess but don't just wait here for it to be finished.
        //while it is running, do other work. etc go to caller method and do other work.
        //Don't process the line after await keyword before the result of HeavyProcess is ready.
        //static Task RunHeavyProcess()
        //{
        //    var result = await HeavyProcess(); 
        //    Console.WriteLine(result);
        //}
        static string HeavyProcess()
        {
            Console.WriteLine("Heavy process started");
            Thread.Sleep(5000);
            Console.WriteLine("Heavy process finished");
            return "Done";
        }
    }
}
