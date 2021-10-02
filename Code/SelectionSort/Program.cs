using System;

namespace Selection
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10]
            {
                1, 5, 4, 11, 20, 8, 2, 98, 90, 16
            };
             
            SelectionSort(arr);
            Console.WriteLine("Valores Ordenados:");
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine(arr[i]);
        }

        private static void SelectionSort(int[] arr)
        {
            int i, j, min;
            for (i = 0; i < arr.Length; i++)
            {
                min = i;
                for (j = 0; j < arr.Length; j++)
                {
                    if (arr[j] > arr[min])
                    {
                        min = j;
                        Swap(ref arr[i], ref arr[min]);
                    }
                }
            }
        }

        private static void Swap(ref int x, ref int y)
        {
            (x, y) = (y, x);
        }
    }
}