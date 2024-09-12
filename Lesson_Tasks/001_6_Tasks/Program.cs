namespace _001_6_Tasks
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Main start");

            Task task = Task.Run(() => CalculateLength("Hello"))
                .ContinueWith(taskWithResult => Console.WriteLine(taskWithResult
                .Result));

            string? userInput = string.Empty;
            do
            {
                Console.WriteLine("enter command: ");
                userInput = Console.ReadLine();

            }
            while (userInput != "exit");
            Console.WriteLine("Main finished");
            Console.ReadKey();
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
