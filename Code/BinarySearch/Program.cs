using System;
using System.Collections.Generic;
using System.Linq;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10]
            {
                1, 2, 4, 11, 20, 28, 48, 84, 96, 106
            };

            int index1 = arr.ToList().BinarySearch(20);
            int index2 = BinarySearchIterative(arr, 20);
            int index3 = BinarySearchRecursive(arr, 20, 0, arr.Length - 1);
            Console.WriteLine($"Índice do valor 20 na lista é {index1.ToString()} (usando .NET Frameowork)");
            Console.WriteLine($"Índice do valor 20 na lista é {index2.ToString()} (usando BinarySearchIterative)");
            Console.WriteLine($"Índice do valor 20 na lista é {index3.ToString()} (usando BinarySearchRecursive)");
        }

        private static int BinarySearchIterative(int[] arr, int searchNumber)
        {
            int left = 0;
            int right = arr.Length - 1;
            int middle;

            while (left <= right)
            {
                middle = (left + right) / 2;
                switch (Compare(arr[middle], searchNumber))
                {
                    case -1:
                        left = middle + 1;
                        break;
                    case 0:
                        return middle;
                    case 1:
                        right = middle - 1;
                        break;
                }
            }
            return -1;
        }

        private static int BinarySearchRecursive(int[] arr, int searchNumber, int left, int right)
        {
            int middle;
            while (left <= right)
            {
                middle = (left + right) / 2;
                switch (Compare(arr[middle], searchNumber))
                {
                    case -1:
                        return BinarySearchRecursive(arr, searchNumber, middle + 1, right);
                    case 0:
                        return middle;
                    case 1:
                        return BinarySearchRecursive(arr, searchNumber, left, middle - 1); 
                }
            }
            return -1;
        }

        private static int Compare(int x, int y)
        {
            return x < y ? -1 : (y < x ? 1 : 0);
        }
    }
}