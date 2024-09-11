namespace _001_6_Threads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread firstThread = new Thread(Method1);
            Thread secondThread = new Thread(Method2);

            // Definition of a variable used to store the output of Method3
            string resultThread = string.Empty;
            // Using a lambda expression for the definition of a new Thread
            Thread thirdThread = new Thread(() => { resultThread = Method3(); });

            firstThread.Start();
            thirdThread.Start();
            secondThread.Start();
            //secondThread.Join();
            // We need to use Join in order to take the parameter in output
            thirdThread.Join();

            Console.WriteLine($"The result of Method3 is: {resultThread}");
        }

        private static void Method1()
        {
            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine($"Method1 {i}");
                Thread.Sleep(2000);
            }
        }

        private static void Method2()
        {
            for (int i = 6; i < 11; i++)
            {
                Console.WriteLine($"Method2 {i}");
                Thread.Sleep(2000);
            }
        }

        private static string Method3()
        {
            int result = 0;
            for (int i = 1; i < 5; i++)
            {
                result += i;
                Thread.Sleep(1000);
            }

            return $"The total is: {result}";
        }
    }
}
