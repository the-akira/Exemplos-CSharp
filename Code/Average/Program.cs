using System;
using System.Collections.Generic;
using System.Linq;

namespace Average
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> notas = new List<int> { 78, 92, 100, 37, 81, 25, 45, 90 };

            double average = notas.Average();

            Console.WriteLine($"A média das notas é {average}");
        }
    }
}