namespace _001_Tasks_Lifecycle
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            MyClass myClass = new MyClass();

            // Start a task that completes successfully
            Task task1 = Task.Run(() => myClass.MyMethod());
            Console.WriteLine($"Task 1 Status: {task1.Status}");

            // Start a task that throws an exception
            Task task2 = Task.Run(() => myClass.ThrowEx());
            Console.WriteLine($"Task 2 Status: {task2.Status}");

            // Start a never-ending task
            Task task3 = Task.Run(() => myClass.NeverEndingTask());
            Console.WriteLine($"Task 3 Status: {task3.Status}");

            try
            {

                await Task.WhenAll(task1, task2, task3);
            }
            catch (Exception ex)
            {

                //throw;
            }
            // Wait for the tasks to complete
            Console.ReadKey();
        }
    }
    public class MyClass
    {
        public void MyMethod()
        {
            Console.WriteLine("MyMethod");
        }

        public void ThrowEx()
        {
            throw new Exception("Task Faulted");
        }

        public void NeverEndingTask()
        {
            while (true)
            {
                Console.WriteLine("NeverEndingTask working");
                Thread.Sleep(1000);
                //break;
            }
        }
    }

}
