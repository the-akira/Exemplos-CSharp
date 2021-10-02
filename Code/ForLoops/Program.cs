using System;

namespace ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("for Loop:");
            for (int i = 10; i > 0; i--)
                Console.WriteLine(i);

            Console.WriteLine("break:");
            for (int i = 0; i < 10; i++)
            {
                if (i == 6)
                    break;
                Console.WriteLine(i);
            }

            Console.WriteLine("continue:");
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 1)
                    continue;
                Console.WriteLine(i);
            }

            string[] linguagens = { "Python", "C#", "JavaScript", "Haskell" };
            foreach (string linguagem in linguagens)
            {
                Console.WriteLine(linguagem);
            }
        }
    }
}