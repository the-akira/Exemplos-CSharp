using System;

namespace CharactersFrequency
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Rato Roeu a Roupa do Rei de Roma";
            char checkCharacter = 'R';
            int count = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if(str[i] == checkCharacter)
                {
                    ++count;
                }
            }
            Console.WriteLine("Número de {0} = {1}",checkCharacter,count);
        }
    }
}