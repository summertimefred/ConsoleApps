using System;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int counter = 0; counter < 10; counter++)
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
            }


            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Hello World! The counter is {i}");
            }

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine($"Hello World! The counter is {i}");
            }
        
        }
    }
}
