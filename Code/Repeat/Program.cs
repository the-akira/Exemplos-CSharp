using System;
using System.Collections.Generic;
using System.Linq;

namespace Repeat
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<string> strings = Enumerable.Repeat("Programação é legal!", 9);

            foreach (String str in strings)
            {
                Console.WriteLine(str);
            }
        }
    }
}