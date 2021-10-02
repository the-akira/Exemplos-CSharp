using System;
using System.Collections.Generic;
using System.Linq;

namespace Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 8, 7, 6, 5, 4, 3, 2, 1 };

            int[] reversed = numbers.Reverse().ToArray();

            foreach (int number in reversed)
            {
                Console.Write(number + " ");
            }
        }
    }
}