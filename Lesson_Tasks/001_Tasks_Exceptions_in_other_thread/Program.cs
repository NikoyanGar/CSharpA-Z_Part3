namespace _001_Tasks_Exceptions_in_other_thread
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var thread = new Thread(MethodThatThrowsException);
            thread.Start();

            //try
            //{
            //    var thread = new Thread(MethodThatThrowsException);
            //    thread.Start();
            //}
            //catch (Exception ex)
            //{

            //    
            //}
            Thread.Sleep(1000);
            Console.WriteLine("Main finished");
            Console.ReadKey();
        }


        static void MethodThatThrowsException()
        {
            throw new Exception("Exception in MethodThatThrowsException");
        }
    }

}
