using System;

namespace Rand
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Arremesso de moeda: {(rand.NextDouble() < 0.5 ? "cara" : "coroa")}");
            }
        }
    }
}