using System;
using System.Collections.Generic;
using System.Linq;

namespace Take
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] notas = { 59, 82, 70, 56, 92, 98, 85, 99 };

            IEnumerable<int> top3Notas = notas.OrderByDescending(nota => nota).Take(3);

            Console.WriteLine("As 3 melhores notas são:");
            foreach (int nota in top3Notas)
            {
                Console.WriteLine(nota);
            }
        }
    }
}