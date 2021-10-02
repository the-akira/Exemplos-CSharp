using System;
using System.Collections.Generic;
using System.Linq;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<float> numbers = new List<float> { 43.68F, 1.25F, 583.7F, 6.5F };

            float sum = numbers.Sum();

            Console.WriteLine("A soma dos números é {0}", sum);
        }
    }
}