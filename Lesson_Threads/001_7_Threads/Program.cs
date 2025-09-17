namespace _001_7_Threads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Main Thread ID: {Thread.CurrentThread.ManagedThreadId}");

            //Thread t = new Thread(() =>
            //{
            //    try
            //    {
            //        Console.WriteLine($"Current Managed Thread ID: {Thread.CurrentThread.ManagedThreadId}");

            //        throw new Exception("ex message");
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine($"Exseption: {ex.Message}");
            //    }
            //});

            //Exception threadEx = null;

            //Thread t = new Thread(() =>
            //{
            //    throw new Exception("exception");
            //});
            //t.Start();
            //t.Join();

            //Console.WriteLine(threadEx.Message);
            //t.Start();
            //t.Join(); // ждём завершения потока

            //if (threadEx != null)
            //{
            //    throw threadEx; // пробрасываем в главный поток
            //}


            //⚠️ Минус: такие обработчики не предотвращают падение приложения — они только дают возможность залогировать ошибку.
            AppDomain.CurrentDomain.UnhandledException += (sender, e) =>
            {
                Console.WriteLine($"sdgnsdijagnijgnidjagnidgnidgijdngidngijfndijnfgijdf");
            };

            new Thread(() => throw new Exception("ex")).Start();


            Console.WriteLine("Hello, World!");
        }
    }
}
