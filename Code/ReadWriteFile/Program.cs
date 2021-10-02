using System;
using System.Linq;
using System.IO;

namespace ReadWriteFile
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ler o arquivo como uma string
            string text = System.IO.File.ReadAllText(@"textFile.txt");
            Console.WriteLine("Conteúdo do arquivo:\n{0}",text);

            // Ler cada linha do arquivo como um array de strings
            string[] lines = System.IO.File.ReadAllLines(@"textFile.txt");
            foreach (string line in lines)
                Console.WriteLine("\t" + line);

            string[] linhas = { "linha 1", "linha 2", "linha 3" };
            File.WriteAllLines(@"File1.txt", linhas);

            using(StreamWriter file = new StreamWriter(@"File2.txt"))
            {
                foreach (string linha in linhas)
                {
                    if (linha.Contains("2"))
                    {
                        file.WriteLine(linha);
                    }
                }
            }

            using(StreamWriter file = new StreamWriter(@"File2.txt", true))
            {
                file.WriteLine("Linha adicional!");
            }
        }
    }
}