using System;
using System.Collections.Generic;
using System.Linq;

namespace Zip
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] heroes = { "Batman", "Superman", "Spiderman" };
            string[] names = { "Bruce Wayne", "Clark Kent", "Peter Parker" };

            var heroesAndNames = heroes.Zip(names, (first, second) => first + " -> " + second);

            foreach (var item in heroesAndNames)
                Console.WriteLine(item);
        }
    }
}