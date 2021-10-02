using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1;
            double num2;
            double answer = 0;
            string operand;
            bool running = true;

            while (running)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("Informe um número: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Informe outro número: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Selecione o operando (+, -, /, *) [x para sair]: ");
                    operand = Console.ReadLine();
     
                    switch (operand)
                    {
                        case "-":
                            answer = num1 - num2;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"{num1} - {num2} = {answer}");
                            break;
                        case "+":
                            answer = num1 + num2;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"{num1} + {num2} = {answer}");
                            break;
                        case "/":
                            answer = num1 / num2;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"{num1} / {num2} = {answer}");
                            break;
                        case "*":
                            answer = num1 * num2;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"{num1} * {num2} = {answer}");
                            break;
                        case "x":
                            running = false;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Opção incorreta");
                            break;
                    }                   
                }

                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Você deve informar um número");
                }
            }
        }
    }
}