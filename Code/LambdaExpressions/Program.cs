using System;
using System.Collections.Generic;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            // args => expression
            Func<int, int> square = number => number * number;
            Console.WriteLine("3² = {0}",square(3));

            // (args, args) => expression
            Func<int, int, int> multiplyTwoNumbers = (a, b) => a * b;
            int a = 20;
            int b = 20;
            Console.WriteLine("{0} x {1} = {2}",a,b,multiplyTwoNumbers(a,b));

            Console.WriteLine("Números pares:");
            List<int> numbers = new List<int>() {36, 71, 12, 15, 29, 18, 27, 17};
            List<int> even = numbers.FindAll(x => (x % 2) == 0);
            foreach (var number in even)
                Console.WriteLine(number);

            Console.WriteLine("Índice do primeiro elemento ímpar:");
            List<int> elements = new List<int>() { 10, 20, 33, 40 };
            int oddIndex = elements.FindIndex(x => x % 2 != 0);
            Console.WriteLine(oddIndex);

            // Action
            Action value = () => Console.WriteLine("Hello World!");
            value.Invoke();

            // Part A: use a expressão do método delegate.
            Func<int, int> test1 = delegate (int x) { return x + 1; };
            Console.WriteLine(test1.Invoke(10));
            
            // Part B: use a expressão do método delegado sem lista de parâmetros.
            Func<int> test2 = delegate { return 15 + 15; };
            Console.WriteLine(test2.Invoke());

            // Encontrar Elemento
            var array = new int[] { 10, 20, 30 };
            var result = Array.Find(array, element => element == 27) > 0 ? true : false;
            Console.WriteLine($"Elemento encontrado -> {result}");            
        }
    }
}