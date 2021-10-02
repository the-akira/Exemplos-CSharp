using System;

namespace Throw
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };

            try 
            {
                Console.WriteLine(GetNumber(numbers,10));
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Índice inválido!");
            }

            try
            {
                var a = Division(15,0);
                Console.WriteLine(a);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Impossível dividir por zero!");
            }

            int GetNumber(int[] arr, int index)
            {
                if (index < 0 || index >= arr.Length)
                {
                    throw new IndexOutOfRangeException();
                }
                return arr[index];
            }

            static double Division(int x, int y)
            {
                if (y == 0)
                {
                    throw new DivideByZeroException();
                }
                else
                {
                    return x / y;
                }
            }
        }
    }
}