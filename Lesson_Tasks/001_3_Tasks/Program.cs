namespace _001_3_Tasks
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Main start");

            string? userInput = string.Empty;
            do
            {
                Console.WriteLine("enter command: ");
                userInput = Console.ReadLine();
                Task<int> taskWithResult1 = Task.Run(() => CalculateLength(userInput));
                Console.WriteLine($"command: {userInput}");
                //Do some work
                var length = await taskWithResult1;
                Console.WriteLine($"Length: {length}");
            }
            while (userInput != "exit");
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
