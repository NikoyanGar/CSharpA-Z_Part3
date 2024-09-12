namespace _001_5_Tasks
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //await Task.Run(() =>
            //{
            //    Console.WriteLine("Hello, World!");
            //}).ContinueWith((task) =>
            //{
            //    Console.WriteLine("Task completed!");
            //});

            var taskcontinue =
                Task.Run(() => CalculateLength("Hi all"))
                .ContinueWith((taskResult) =>
                {
                    Console.WriteLine($"lenght is :{taskResult.Result}");
                });
            //await taskcontinue;
        }
        public static int CalculateLength(string? text)
        {
            if (text == null)
            {
                return 0;
            }
            Console.WriteLine($"Start CalculateLength in ManagedThreadId: {Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(3000);
            return text.Length;
        }
    }
}
