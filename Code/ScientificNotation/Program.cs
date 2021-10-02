using System;

namespace ScientificNotation
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1 = 12345.67890123;
            Console.WriteLine("Formato Padrão: {0}", number1);
            Console.WriteLine($"Notação Científica: {string.Format("{0:#.##E+0}", number1)}");
            Console.Write("\n");
             
            int number2 = 123456789;
            Console.WriteLine("Formato Padrão: {0}", number2);
            Console.WriteLine($"Notação Científica: {string.Format("{0:#.##E+0}", number2)}");
            Console.Write("\n");
             
            double number3 = 1234567.890123;
            Console.WriteLine("Formato Padrão: {0}", number3);
            Console.WriteLine($"Notação Científica: {string.Format("{0:#.##E+00}", number3)}");
        }
    }
}