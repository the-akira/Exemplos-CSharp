using System;

namespace Enums
{
    class Program
    {
        enum Months
        {
          Janeiro,     // 0
          Fevereiro,   // 1
          Março,       // 2
          Abril,       // 3
          Maio,        // 4
          Junho,       // 5
          Julho,       // 6
          Agosto,      // 7
          Setembro,    // 8
          Outubro,     // 9
          Novembro,    // 10
          Dezembro     // 11
        }

        enum Level
        {
            Easy,
            Medium,
            Hard
        }

        static void Main(string[] args)
        {
            int myNum = (int) Months.Abril;
            Console.WriteLine(myNum);

            Level myVar = Level.Medium;
            switch(myVar) 
            {
                case Level.Easy:
                    Console.WriteLine("Easy level");
                    break;
                case Level.Medium:
                    Console.WriteLine("Medium level");
                    break;
                case Level.Hard:
                    Console.WriteLine("Hard level");
                    break;
            }
        }
    }
}