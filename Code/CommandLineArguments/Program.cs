using System;

namespace CommandLineArguments
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Número de argumentos: " + args.Length);
            foreach (string argument in Environment.GetCommandLineArgs())
            {
                Console.WriteLine("Arg: " + argument);
            }
        }
    }
}