using System;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("while:");
            int i = 0;
            while (i < 15)
            {
                i++;
                if (i % 2 == 0)
                    continue;
                Console.WriteLine(i);
            }

            Console.WriteLine("do while:");
            int j = 0;
            do
            {
                Console.WriteLine(++j);
            } while(j < 10);
        }
    }
}