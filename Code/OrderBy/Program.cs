using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderBy
{
    class Program
    {
        static void Main(string[] args)
        {
            Pet[] pets = {
                new Pet { Name="Bob", Age=10 },
                new Pet { Name="Billy", Age=15 },
                new Pet { Name="Kiki", Age=7 },
                new Pet { Name="Rex", Age=5 },
                new Pet { Name="Bruce", Age=11 }
            };

            IEnumerable<Pet> query = pets.OrderBy(pet => pet.Age);

            Console.WriteLine("Pets ordenados por idade:");
            foreach (Pet pet in query)
            {
                Console.WriteLine("{0} - {1}", pet.Name, pet.Age);
            }
        }
    }

    class Pet
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}