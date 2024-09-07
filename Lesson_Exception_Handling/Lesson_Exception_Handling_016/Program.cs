namespace Lesson_Exception_Handling_016
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Example method that can throw exceptions
            try
            {
                DoSomething("argument");
                DoSomething(null);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("ArgumentNullException: " + ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("ArgumentException: " + ex.Message);
            }
            catch (Exception ex)// to first catch for demonstration purposes
            {
                Console.WriteLine("ArgumentException: " + ex.Message);
            }

            try
            {
                DivideByZero(10, 0);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("DivideByZeroException: " + ex.Message);
            }
            catch (Exception ex)// to first catch for demonstration purposes
            {
                Console.WriteLine("ArgumentException: " + ex.Message);
            }
        }

        static void DoSomething(string argument)
        {
            if (argument == null)
            {
                throw new ArgumentNullException(nameof(argument), "Argument cannot be null.");
            }

            if (argument.Length == 0)
            {
                throw new ArgumentException("Argument cannot be empty.", nameof(argument));
            }

            // Perform some operation with the argument
        }

        static void DivideByZero(int dividend, int divisor)
        {
            if (divisor == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }

            int result = dividend / divisor;

            // Perform some operation with the result
        }
    }
}
