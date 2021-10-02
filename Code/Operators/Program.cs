using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 5;
            Console.WriteLine($"{x} + {y} = {x+y}");
            Console.WriteLine($"{x} - {y} = {x-y}");
            Console.WriteLine($"{x} * {y} = {x*y}");
            Console.WriteLine($"{x} / {y} = {x/y}");
            Console.WriteLine($"{x} % {y} = {x%y}");

            // Increment
            x++;
            Console.WriteLine(x);
            Console.WriteLine(++x);

            // Decrement
            Console.WriteLine(--y);
            Console.WriteLine(y--);
            Console.WriteLine(y);
        }
    }
}