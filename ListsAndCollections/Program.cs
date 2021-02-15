using System;
using System.Collections.Generic;

namespace ListsAndCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string> { "<name>", "Brandon", "Matthew", "Fred" };
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine($"Hello {names[i].ToUpper()}!");
            }



            names.Add("Crystal");
            names.Add("Ryan");
            names.Remove("Fred");

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine($"List size = {names.Count}");

            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);
            Console.WriteLine(names[3]);
            Console.WriteLine(names[4]);
            Console.WriteLine(names[5]);

        }
    }
}
