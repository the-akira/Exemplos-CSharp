using System;
using System.Collections.Generic;
using System.Linq;

namespace MinMax
{
    class Program
    {
        static void Main(string[] args)
        {
            int?[] numbers = { null, 5, 9, -2, 13, 25, 1, 0, 55 };

            int? max = numbers.Max();
            int? min = numbers.Min();

            Console.WriteLine("O maior número é: {0}", max);
            Console.WriteLine("O menor número é: {0}", min);
        }
    }
}