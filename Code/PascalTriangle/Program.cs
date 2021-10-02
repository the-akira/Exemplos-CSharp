using System;

namespace PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Triângulo de Pascal");
            Console.Write("Informe o número de linhas: ");
            string input = Console.ReadLine();

            try
            {
                int n = Convert.ToInt32(input);

                for (int i = 0; i < n; i++)
                {
                    int c = 1;
                    for (int j = 0; j < n - i; j++)
                        Console.Write("   ");

                    for (int k = 0; k <= i; k++)
                    {
                        Console.Write("   {0:D} ", c);
                        c = c * (i - k) / (k + 1);
                    }
                    Console.Write("\n\n");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Necessário informar um número!");
            }
        }
    }
}