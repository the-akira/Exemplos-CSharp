using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iterative:");
            for (int i = 0; i < 15; i++)
                Console.WriteLine(FibonacciIteratively(i));

            Console.WriteLine("Recursive:");
            for (int i = 0; i < 15; i++)
                Console.WriteLine(FibonacciRecursively(i));
        }

        private static int FibonacciIteratively(int n)
        {
            int result = 0;
            int previous = 1;

            for (int i = 0; i < n; i++)
            {
                int temp = result;
                result = previous;
                previous = temp + previous;
            }
            return result;
        }

        private static int FibonacciRecursively(int n)
        {
            if (n == 0)
                return 0;
            else if (n == 1)
                return 1;
            else
                return FibonacciRecursively(n - 2) + FibonacciRecursively(n - 1);
        }
    }
}