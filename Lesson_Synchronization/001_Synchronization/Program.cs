namespace _001_Synchronization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // synchron
            Counter counter = new Counter();
            for (int i = 0; i < 1000; i++)
            {
                counter.Increment();
            }
            for (int i = 0; i < 1000; i++)
            {
                counter.Decrement();
            }
            Console.WriteLine(counter.Count);

            Console.WriteLine("--------------------------");

            ////asynchron
            //Counter counter1 = new Counter();
            //var tasks = new List<Task>();
            //for (int i = 0; i < 1000; i++)
            //{
            //    tasks.Add(Task.Run(() => counter1.Increment()));
            //}
            //for (int i = 0; i < 1000; i++)
            //{
            //    tasks.Add(Task.Run(() => counter1.Decrement()));
            //}
            //Task.WaitAll(tasks.ToArray());
            //Console.WriteLine(counter1.Count);
            //Console.ReadKey();
        }
    }
    public class Counter
    {
        public int Count { get; set; }
        public void Increment()
        {
            Count++;
        }
        public void Decrement()
        {
            Count--;
        }
    }
}
