using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathDoubles
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 7;
            int b = 4;
            int c = 3;
            int d = (a + b) / c;
            int e = (a + b) % c;
            Console.WriteLine($"quotient: {d}");
            Console.WriteLine($"remainder: {e}");

            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"The range of integers is {min} to {max}");

            int what = max + 3;
            Console.WriteLine($"An example of overflow: {what}");


            double da = 5;
            double db = 4;
            double dc = 2;
            double dd = (da + db) / dc;
            Console.WriteLine(dd);


            double dda = 19;
            double ddb = 23;
            double ddc = 8;
            double ddd = (dda + ddb) / ddc;
            Console.WriteLine(ddd);

            
            double dmax = double.MaxValue;
            double dmin = double.MinValue;
            Console.WriteLine($"The range of double is {dmin} to {dmax}");

            double third = 1.0 / 3.0;
            Console.WriteLine(third);


        }
    }
}
