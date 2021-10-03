using System;
using System.IO;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var calculator = new Calculator();
                var result = calculator.Divide(5,0);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Não é possível dividir por 0");
            }
            finally
            {
                Console.WriteLine("Finally é sempre executado!");
            }

            try
            {
                using(var streamReader = new StreamReader(@"file.txt"))
                {
                    var content = streamReader.ReadToEnd();
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Arquivo não encontrado");
            }

            try
            {
                int[] numbers = {1, 2, 3};
                Console.WriteLine(numbers[3]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}