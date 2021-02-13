using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string songLyrics = "You say goodbye, and I say hello";

            var result = songLyrics.Contains("goodbye");

            Console.WriteLine(result);
            //Console.WriteLine(songLyrics.Contains("greetings"));
        }
    }
}
