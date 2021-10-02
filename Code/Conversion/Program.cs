using System;

namespace Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            double myDouble = 13.37;
            int myInt;

            // Explicit Conversion
            // cast double to int
            myInt = (int)myDouble;
            Console.WriteLine(myInt);

            // Implicit Conversion
            int num = 12390532;
            long bigNum = num;
            Console.WriteLine(bigNum);

            float myFloat = 13.37F;
            double myNewDouble = myFloat;
            Console.WriteLine(myNewDouble);

            // typeConversion
            string myString = myDouble.ToString();
            Console.WriteLine("Valor = " + myString);

            // Parsing a String to an Integer
            string str1 = "15";
            string str2 = "13";
            string str3 = "C#";

            int num1 = Int32.Parse(str1);
            int num2 = Int16.Parse(str2);
            Console.WriteLine(num1 + num2);
           
            if(Int32.TryParse(str3, out _))
                Console.WriteLine("Sucesso");
            else
                Console.WriteLine("Erro!");

            // Convert
            int meuInt = 10;
            double meuDouble = 5.25;
            bool meuBool = true;

            Console.WriteLine(Convert.ToString(meuInt)); // Convert int to string
            Console.WriteLine(Convert.ToDouble(meuInt)); // Convert int to double
            Console.WriteLine(Convert.ToInt32(meuDouble)); // Convert double to int
            Console.WriteLine(Convert.ToString(meuBool)); // Convert bool to string
        }
    }
}