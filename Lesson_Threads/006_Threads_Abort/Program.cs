namespace _006_Threads_Abort
{
    internal class Program
    {
        static void Main()
        {
            var thread = new Thread(Function);
            //Console.WriteLine($"thread.IsBackground : {thread.IsBackground}");
            thread.Start();

            Thread.Sleep(2000);

            //thread.Abort();
            thread.Interrupt();
            //thread.Join();

            Thread.Sleep(10000);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n" + new string('_', 80));
            Console.ReadKey();
        }

        private static void Function()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            while (true)
            {
                try
                {
                    Thread.Sleep(10);
                    Console.Write(".");
                }
                catch (ThreadAbortException ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\nThreadAbortException, State: {Thread.CurrentThread.ThreadState}");

                    for (int i = 0; i < 160; i++)
                    {
                        Thread.Sleep(20);
                        Console.Write(".");
                    }

                    Console.ForegroundColor = ConsoleColor.Green;

                    // If we don't call ResetAbort, the ex. will be re thrown after catch
                    //Thread.ResetAbort();
                    //break;
                }
                catch (ThreadInterruptedException ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\nThreadInterruptedException, State: {Thread.CurrentThread.ThreadState}");

                    for (int i = 0; i < 160; i++)
                    {
                        Thread.Sleep(20);
                        Console.Write(".");
                    }

                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                }
            }
        }
    }
}
