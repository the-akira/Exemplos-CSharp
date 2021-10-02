using System;
using System.Collections.Generic;
using System.Linq;

namespace Distinct
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ages = new List<int> { 21, 46, 46, 55, 17, 21, 55, 55 };

            IEnumerable<int> distinctAges = ages.Distinct();

            Console.WriteLine("Idades distintas:");
            foreach (int age in distinctAges)
            {
                Console.WriteLine(age);
            }
        }
    }
}