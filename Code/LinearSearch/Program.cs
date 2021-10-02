using System;

namespace LinearSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10]
            {
                1, 2, 4, 11, 20, 28, 48, 84, 96, 106 
            };

            int index = SequentialSearch(arr, 20);
            Console.WriteLine($"Índice do valor 20 no array é = {index}");
        }

        private static int SequentialSearch(int[] arr, int searchNumber)
        {
            arr[arr.Length - 1] = searchNumber;

            int i;
            for (i = 0; arr[i] != searchNumber; i++);
            return (i < arr.Length - 1) ? i : -1;
        }
    }
}