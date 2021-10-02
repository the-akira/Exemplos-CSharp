using System;

namespace Encapsulation
{
    public class Person
    {
        private string name;
        private int age;

        public string getInfo()
        {
            return $"Name: {this.name}, Age: {this.age}";
        }

        public void setPerson(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.setPerson("Bob",25);
            Console.WriteLine(person.getInfo());
        }
    }
}