using System;
using System.Collections.Generic;

namespace ListsOfOtherTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            var fibonacciNumbers = new List<int> { 1, 1 };
            //var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
            //var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

            //fibonacciNumbers.Add(previous + previous2);

            //foreach (var item in fibonacciNumbers)
            //    Console.WriteLine(item);

            while (fibonacciNumbers.Count < 20)
            {
                var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
                var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

                fibonacciNumbers.Add(previous + previous2);

                foreach (var item in fibonacciNumbers)
                    Console.WriteLine(item);
            }

            //Try and write the code to generate the first 20 numbers in the sequence. (As a hint, the 20th Fibonacci number is 6765.)


        }
    }
}
