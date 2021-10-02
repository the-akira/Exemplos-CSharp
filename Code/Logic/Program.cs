using System;

namespace Logic
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;

            if (x > y)
            {
                Console.WriteLine($"{x} maior do que {y}");
            }
            else
            {
                Console.WriteLine($"{y} maior do que {x}");
            }

            bool chovendo = true;

            if (chovendo)
            {
                Console.WriteLine("Ficar me casa.");
            }
            else
            {
                Console.WriteLine("Sair de casa.");
            }

            int hora = 22;

            if (hora < 10)
            {
                Console.WriteLine("Bom dia!");
            }
            else if (hora < 18)
            {
                Console.WriteLine("Boa tarde!");
            }
            else
            {
                Console.WriteLine("Boa noite!");
            }

            bool online = false;
            string result = online ? "Você está online!" : "Vocẽ está offline!";
            Console.WriteLine(result);
        }
    }
}