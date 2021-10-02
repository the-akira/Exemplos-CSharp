using System;
using System.Collections.Generic;
using System.Linq;

namespace Range
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> squares = Enumerable.Range(1, 10).Select(x => x * x);

            foreach (int num in squares)
            {
                Console.WriteLine(num);
            }
        }
    }
}