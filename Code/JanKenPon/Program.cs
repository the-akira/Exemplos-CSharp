using System;
using System.Collections.Generic;

namespace JanKenPon
{
    class Program
    {
        static void Main(string[] args)
        {
            var item = new List<string>{ "pedra", "papel", "tesoura" };
            bool playing = true;

            do
            {
                var random = new Random();
                int index = random.Next(item.Count);
                string machineChoice = item[index];

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("# Pedra\n# Papel\n# Tesoura\n# Sair");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Digite a opção desejada:");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string playerChoice = Console.ReadLine().ToLower();

                if (machineChoice == playerChoice)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Ocorreu um empate!");
                }
                else if (playerChoice == "pedra")
                {
                    if (machineChoice == "papel")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Você perdeu! {machineChoice} cobre {playerChoice}");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Parabéns, você venceu! {playerChoice} quebra {machineChoice}");
                    }
                }
                else if (playerChoice == "papel")
                {
                    if (machineChoice == "tesoura")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Você perdeu! {machineChoice} corta {playerChoice}");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Parabéns, você venceu! {playerChoice} esmaga {machineChoice}");
                    }
                }
                else if (playerChoice == "tesoura")
                {
                    if (machineChoice == "pedra")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Você perdeu! {machineChoice} quebra {playerChoice}");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Parabéns, você venceu! {playerChoice} corta {machineChoice}");
                    }
                }
                else if (playerChoice == "sair")
                {
                    playing = false;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Jogada inválida, verifique se digitou a opção correta!");
                }
                Console.Write("\n");
            } while(playing);
        }
    }
}