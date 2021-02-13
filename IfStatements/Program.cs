using System;

namespace IfStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 6;

            bool something = a + b > 10;
            if (a + b > 10)
                Console.WriteLine("The answer is greater than 10.");

            if (something)
                Console.WriteLine("The answer is greater than 10.");

            if (a + b > 10)
                Console.WriteLine("The answer is greater than 10.");
            else
                Console.WriteLine("The answer is NOT greater than 10.");




        }
    }
}
