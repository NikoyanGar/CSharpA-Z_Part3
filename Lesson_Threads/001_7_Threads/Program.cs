namespace _001_7_Threads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(() =>
            {
                try
                {
                    throw new Exception("Ошибка в потоке!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"[Поток] Исключение: {ex.Message}");
                }
            });
            t.Start();

            //Exception threadEx = null;

            //Thread t = new Thread(() =>
            //{
            //    try
            //    {
            //        throw new Exception("Ошибка в рабочем потоке!");
            //    }
            //    catch (Exception ex)
            //    {
            //        threadEx = ex; // сохраняем
            //    }
            //});

            //t.Start();
            //t.Join(); // ждём завершения потока

            //if (threadEx != null)
            //{
            //    throw threadEx; // пробрасываем в главный поток
            //}


            //⚠️ Минус: такие обработчики не предотвращают падение приложения — они только дают возможность залогировать ошибку.
            //AppDomain.CurrentDomain.UnhandledException += (sender, e) =>
            //{
            //    Console.WriteLine($"Глобальный перехват: {((Exception)e.ExceptionObject).Message}");
            //};

            //new Thread(() => throw new Exception("Ошибка")).Start();


            Console.WriteLine("Hello, World!");
        }
    }
}
