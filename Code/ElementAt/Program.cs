using System;
using System.Collections.Generic;
using System.Linq;

namespace ElementAt
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Gabriel", "Rafael", "Miguel", "Joel", "Samuel", "Uriel" };

            Random random = new Random(DateTime.Now.Millisecond);

            string name = names.ElementAt(random.Next(0, names.Length));

            Console.WriteLine("O nome escolhido aleatoriamente é: '{0}'.", name);
        }
    }
}