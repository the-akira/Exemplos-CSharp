using System;

namespace Quick
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10]
            {
                1, 5, 4, 11, 20, 8, 2, 98, 90, 16
            };
             
            QuickSort(arr, 0, arr.Length - 1);
            Console.WriteLine("Valores Ordenados:");
            foreach (var item in arr)
                Console.WriteLine(item);
        }

        private static void QuickSort(int[] arr, int start, int end)
        {
            int i;
            if (start < end)
            {
                i = Partition(arr, start, end);
                QuickSort(arr, start, i - 1);
                QuickSort(arr, i + 1, end);
            }
        }

        private static int Partition(int[] arr, int start, int end)
        {
            int p = arr[end];
            int i = start - 1;

            for (int j = start; j <= end - 1; j++)
            {
                if (arr[j] <= p)
                {
                    i++;
                    (arr[i], arr[j]) = (arr[j], arr[i]);
                }
            }
            (arr[i + 1], arr[end]) = (arr[end], arr[i + 1]);
            return i + 1;
        }
    }
}