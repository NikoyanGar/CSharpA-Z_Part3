namespace Lesson_Erors_Bugs_Exceptions
{
    //Errors, Bugs, and Exceptions
    //Errors: These are issues in the code that prevent the program from running correctly.They can be syntax errors, logical errors, or runtime errors.
    //Bugs: These are flaws in the code that cause it to behave unexpectedly. Bugs can lead to errors and exceptions.
    //Exceptions: These are events that occur during the execution of a program, disrupting its normal flow.
    //Exceptions are typically unexpected and need to be handled to prevent the program from crashing.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            LogicalErrorMethod();
        }

        // Method to demonstrate a syntax error
        static void SyntaxErrorMethod()
        {
            // This line contains a syntax error
            Console.WriteLine("This is a syntax error");
        }

        // Method to demonstrate a logical error
        static void LogicalErrorMethod()
        {
            int num1 = 10;
            int num2 = 20;
            int num3 = 30;

            // Logical error: Incorrect formula for average
            int average = (num1 + num2 + num3) / 2;//3

            Console.WriteLine($"The average is: {average}");
        }

        // Method to demonstrate a runtime error
        static void ExceptionMethod()
        {
            int[] numbers = { 1, 2, 3 };

            // This line contains a runtime error
            int value = numbers[3];

            Console.WriteLine("Value: " + value);
        }
    }
}
