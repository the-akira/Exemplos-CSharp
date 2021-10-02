using System;

namespace Delegates
{
    public delegate int AddDelegate(int x, int y);
    public delegate string GreetingsDelegate(string name);

    class Program
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public static string Greetings(string name)
        {
            return $"Hello {name}!";
        }

        static void Main(string[] args)
        {
            Program obj = new Program();

            AddDelegate ad = new AddDelegate(obj.Add);
            GreetingsDelegate gd = new GreetingsDelegate(Program.Greetings);

            Console.WriteLine(ad(10,10));
            string GreetingsMessage = gd("Gabriel");
            Console.WriteLine(GreetingsMessage);
        }
    }
}