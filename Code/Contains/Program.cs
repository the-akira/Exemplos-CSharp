using System;
using System.Linq;

namespace Contains
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] alimentos = { "feijão", "arroz", "batata", "cenoura", "pão" };
            string alimento = "arroz";
            bool temArroz = alimentos.Contains(alimento);

            Console.WriteLine("O array {0} {1}", temArroz ? "tem" : "não tem", alimento);
        }
    }
}