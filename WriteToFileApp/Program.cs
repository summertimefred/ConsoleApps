using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WriteToFileApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter outputFile = new StreamWriter("log.txt"))
            {
                outputFile.WriteLine("Hi this is Donald Trump");
            }

        }
    }
}
