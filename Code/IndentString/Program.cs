using System;

namespace IndentString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Indent(0) + "Versões");
            Console.WriteLine(Indent(2) + "Versão 1");
            Console.WriteLine(Indent(4) + "Versão 1.1");
            Console.WriteLine(Indent(4) + "Versão 1.2");
            Console.WriteLine(Indent(6) + "Versão 1.2.1");
            Console.WriteLine(Indent(2) + "Versão 2");
            Console.WriteLine(Indent(4) + "Versão 2.1");
            Console.WriteLine(Indent(4) + "Versão 2.2");
        }

        private static string Indent(int count)
        {
            return "".PadLeft(count);
        }
    }
}