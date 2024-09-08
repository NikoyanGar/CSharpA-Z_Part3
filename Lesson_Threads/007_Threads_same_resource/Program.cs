namespace _007_Threads_same_resource
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Counter counter = new Counter();
            Thread thread1 = new Thread(() => counter.IncrementCounter());
            Thread thread2 = new Thread(() => counter.IncrementCounter());

            thread1.Start();
            thread2.Start();

            thread1.Join();
            thread2.Join();

            Console.WriteLine("Counter value: " + counter.Value);
        }
    }

    internal class Counter
    {
        public int Value { get; set; }
        public void IncrementCounter()
        {
            for (int i = 0; i < 100000; i++)
            {
                Value++;
            }
        }
    }
}
