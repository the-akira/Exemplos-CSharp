using System;

namespace Mathematics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Ceiling: {Math.Ceiling(15.2)}");
            Console.WriteLine($"Floor: {Math.Floor(15.7)}");
            Console.WriteLine($"Round Up: {Math.Round(9.90)}");
            Console.WriteLine($"Round Down: {Math.Round(9.20)}");
            Console.WriteLine($"Raiz Quadrada de 25: {Math.Sqrt(25)}");
            Console.WriteLine($"2 Elevado na 5: {Math.Pow(2,5)}");
            Console.WriteLine($"Pi = {Math.PI}");
            Console.WriteLine($"Valor absoluto de -3 = {Math.Abs(-3)}");
        }
    }
}