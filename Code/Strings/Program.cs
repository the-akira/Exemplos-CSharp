using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // String Concatenation in C#
            string nome = "Miguel";
            string sobrenome = "Rafael";
            string nomeCompleto = nome + " " + sobrenome;
            Console.WriteLine(nomeCompleto);

            // Escape Character Sequences in C#
            Console.WriteLine("Escrevendo \"aspas\"");

            // String Interpolation
            int id = 77;
            string numeroMultiplicado = $"O ID multiplicado é {id * 100}.";
            Console.WriteLine(numeroMultiplicado);

            // .toUpper() in C#
            string frase = "O Rato Roeu a Roupa do Rei de Roma";
            Console.WriteLine(frase.ToUpper());

            // .ToLower() in C#
            string pensamento = "\"Penso, Logo Existo\"";
            Console.WriteLine(pensamento.ToLower());

            // String Length in C#
            string palavra = "pneumoultramicroscopicossilicovulcanoconiótico";
            Console.WriteLine($"Tamanho da palavra {palavra} = {palavra.Length}");

            // IndexOf() in C#
            string str = "Python";
            int index = str.IndexOf("P");
            Console.WriteLine("O valor de índice do caracter 'P' é {0}",index);

            // Substring() in C#
            string phrase = "C# é uma linguagem de programação legal";
            Console.WriteLine(phrase.Substring(0,18));

            // Bracket Notation
            string valor = "Universo";
            char primeiro = valor[0];
            char segundo = valor[1];
            char ultimo = valor[valor.Length -1];
            Console.WriteLine($"Palavra = {valor}");
            Console.WriteLine($"1º: {primeiro}\n2º: {segundo}\nÚltimo: {ultimo}");
        }
    }
}