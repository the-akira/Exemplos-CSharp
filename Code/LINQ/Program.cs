using System;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 4, 3, 2, 1, 10, 27, 0, 6, 8 };

            Console.WriteLine($"Array:");
            foreach (var number in numbers)
                Console.WriteLine($"{number}");

            Console.WriteLine($"Tamanho do array: {numbers.Length}");

            // Menores do que 5 (Versão 1)
            var lowNums1 = from n in numbers where n < 5 select n;
            Console.WriteLine($"Menores do que 5:");
            foreach (var lowNum in lowNums1)
                Console.WriteLine($"{lowNum}");      

            // Menores do que 5 (Versão 2)
            var lowNums2 = numbers.Where(n => n < 5);
            Console.WriteLine($"Menores do que 5:");
            foreach (var lowNum in lowNums2)
                Console.WriteLine($"{lowNum}");        

            // Ordenando uma lista de palavras pelo comprimento    
            string[] words = { "banana", "abacaxi", "limão", "melância", "uva" };

            // Versão 1
            var sortedWords1 = from w in words orderby w.Length select w;
            Console.WriteLine($"Lista ordenada por comprimento:");
            foreach (var sortedWord in sortedWords1)
                Console.WriteLine($"{sortedWord}");  

            // Versão 2
            var sortedWords2 = words.OrderBy(w => w.Length);
            Console.WriteLine($"Lista ordenada por comprimento:");
            foreach (var sortedWord in sortedWords2)
                Console.WriteLine($"{sortedWord}"); 
        }
    }
}