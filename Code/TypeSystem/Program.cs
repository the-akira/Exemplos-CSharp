using System;

namespace TypeSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Int
            int a = 10;
            int b = a + 5;
            Console.WriteLine("{0} - {1} = {2}",b,a,b - a);

            // Float
            float c = 10.5F;
            Console.WriteLine(typeof(float));
            Console.WriteLine(c.GetType());

            // Class
            Animal bob = new Animal();
            Dog billy = new Dog();
            Console.WriteLine(bob.GetType());
            Console.WriteLine(billy is Animal);

            // Bool
            bool on = true;

            if (on)
            {
                Console.WriteLine("Ligado");
            }
            else
            {
                Console.WriteLine("Desligado");
            }

            // Decimal
            decimal max = decimal.MaxValue;
            decimal min = decimal.MinValue;

            Console.WriteLine("Max Decimal: " + max);
            Console.WriteLine("Min Decimal: " + min);

            // Char
            char nota = 'A';
            Console.WriteLine(nota);

            // Long
            long number = 1999;

            // String
            string s = "A resposta é " + number.ToString();
            Console.WriteLine(s);

            // Array
            int[] nums = { 1, 2, 3, 4, 5 };
            Type type = nums.GetType();
            Console.WriteLine(type);

            // Byte
            Console.WriteLine("Max Byte = " + byte.MaxValue);

            // Double
            Console.WriteLine("Min Double = " + double.MinValue);
        }
    }

    public class Animal { }

    public class Dog : Animal { }
}