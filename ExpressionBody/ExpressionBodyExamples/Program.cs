using System;

namespace ExpressionBodyExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Person David = new Person("David", 17);

            Console.WriteLine(David.GetInfo());
            David.SayHello();
        }
    }
    public class Person
    {
        private string Name { get; set; }
        private int Age { get; set; }

        public string GetInfo() => $"{this.Name} is {this.Age} years old";
        public void SayHello() => Console.WriteLine($"{this.Name} : hello");

        public Person() { }
        public Person(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }
    }
}
