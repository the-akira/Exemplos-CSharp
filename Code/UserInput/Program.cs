using System;

namespace UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe um número inteiro: ");
            string userInput = Console.ReadLine();

            try
            {
                int userInputAsInt = int.Parse(userInput);
            }
            catch (FormatException)
            {
                Console.WriteLine("Erro de Formato. Por favor informe o formato correto.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("O número informado é muito longo ou muito curto para um int32.");
            }
            finally
            {
                Console.WriteLine($"Você informou {userInput}");
            }
        }
    }
}