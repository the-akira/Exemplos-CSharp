using System;
using System.Collections.Generic;
using System.Linq;

namespace FilteringData
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "the", "quick", "brown", "fox", "jumps" }; 

            IEnumerable<string> query1 = from word in words where word.Length == 3 select word;  

            Console.WriteLine("Palavras de comprimento 3:");
            foreach (string str in query1)
                Console.WriteLine(str);

            int[] numbers = { 1, 3, 5, 7, 25, 8, 13, 44 }; 

            IEnumerable<int> query2 = from number in numbers where number >= 8 select number;  

            Console.WriteLine("Números maiores ou iguais a 8");
            foreach (int num in query2)
                Console.WriteLine(num);
        }
    }
}