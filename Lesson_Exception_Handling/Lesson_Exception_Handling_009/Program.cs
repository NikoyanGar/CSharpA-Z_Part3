﻿namespace Lesson_Exception_Handling_009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Method(0);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finished Recursive Method.");
            }

            Console.ReadLine();
        }

        static void Method(int i)
        {
            Console.WriteLine(i);
            Method(++i);
        }
    }
}
