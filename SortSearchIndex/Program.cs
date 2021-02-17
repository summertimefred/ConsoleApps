using System;
using System.Collections.Generic;

namespace SortSearchIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string> { "<name>", "Brandon", "Matthew", "Fred" };

            names.Add("Maria");
            names.Add("Bill");
            names.Remove("Ana");
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            var index = names.IndexOf("Matthew");
            if (index != -1)
                Console.WriteLine($"The name {names[index]} is at index {index}");

            var notFound = names.IndexOf("Not Found");
            Console.WriteLine($"When an item is not found, IndexOf returns {notFound}");


            names.Sort();
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
        }
    }
}
