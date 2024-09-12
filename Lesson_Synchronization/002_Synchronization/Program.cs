namespace _002_Synchronization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //asynchron
            Counter counter1 = new Counter();
            var tasks = new List<Task>();
            for (int i = 0; i < 1000; i++)
            {
                tasks.Add(Task.Run(() => counter1.Increment()));
            }
            for (int i = 0; i < 1000; i++)
            {
                tasks.Add(Task.Run(() => counter1.Decrement()));
            }
            Task.WaitAll(tasks.ToArray());
            Console.WriteLine(counter1.Count);
            Console.ReadKey();
        }
    }
    public class Counter
    {
        public object lockObject = new object();
        public int Count { get; set; }
        public void Increment()
        {
            lock (lockObject)
            {
                Count++;
            }
        }
        public void Decrement()
        {
            lock (lockObject)
            {
                Count--;
            }
        }
    }
}
