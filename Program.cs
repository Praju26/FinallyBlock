using System;

namespace FinallyBlock
{
    //C# program to demonstrate the finally 
    //block in exception handling
    class ExceptionDemo
    {
        void PrintHello()
        {
            Console.WriteLine("Hello World");
        }
        static void Main()
        {
            try
            {
                ExceptionDemo E = new ExceptionDemo();

                E = null;
                E.PrintHello();
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Finally block executed");
            }
        }
    }

}





