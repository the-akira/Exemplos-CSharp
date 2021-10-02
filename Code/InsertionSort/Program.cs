﻿using System;

namespace Insertion
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10]
            {
                1, 5, 4, 11, 20, 8, 2, 98, 90, 16
            };
             
            InsertionSort(arr);
            Console.WriteLine("Valores Ordenados:");
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine(arr[i]);
        }

        private static void InsertionSort(int[] arr)
        {
            int j, temp;
            for (int i = 1; i <= arr.Length - 1; i++)
            {
                temp = arr[i];
                j = i -1;
                while (j >= 0 && arr[j] > temp)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = temp;
            }
        }
    }
}