using System;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

namespace NullOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Person person = new Person() { Name = "X" };
            Person person = null;
            // not a problem even if person is null. But if we say string name = person.Name and person is null then we will get NullReferenceException error.
            // If we use ?. we won't get any error, and if person is null and we still want to string name to have a value and not null then we can use the ?? operator
            string name = person?.Name ?? "Ioannis";

            Console.WriteLine(name);
        }
    }
    class Person
    {
        public string Name { get; set; }
    }
}
