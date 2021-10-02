using System;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                int number;
                Console.Write("Informe um número positivo: ");
                number = Math.Abs(Convert.ToInt32(Console.ReadLine()));

                if (checkForPrime(number, 2))
                    Console.WriteLine("O número {0} é primo.",number);
                else
                    Console.WriteLine("O número {0} não é primo.",number);
            }
            catch (FormatException)
            {
                Console.WriteLine("Você deve informar um número inteiro positivo.");
            }
        }

        static bool checkForPrime(int n, int i)
        {
            if (n <= 2)
                return (n == 2) ? true : false;
            if (n % i == 0)
                return false;
            if (i * i > n)
                return true;

            return checkForPrime(n, i + 1);
        }
    }
}