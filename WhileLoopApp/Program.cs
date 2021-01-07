using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoopApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;
            while (counter < 1001)
            {
                Console.WriteLine("Hello World! The counter is:" + counter);
                counter = counter + 1;

                if (counter == 501)
                    break;
            }
        }
    }
}
