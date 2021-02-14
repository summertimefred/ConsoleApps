using System;

namespace BranchesAndLoops
{
    class Program
    {
        static void Main(string[] args)
        {

            int total = 0;

            // Please add up the numbers from 1 to 20 and print it out
            for (int i = 1; i < 21; i++)
            {
                total = total + i;
                Console.WriteLine($"i = {i} total = {total}");


            }



            int sum = 0;
            for (int number = 1; number < 21; number++)
            {
                if (number % 3 == 0)
                {
                    sum = sum + number;
                }
            }
            Console.WriteLine($"The sum is {sum}");
        }
    }
}
