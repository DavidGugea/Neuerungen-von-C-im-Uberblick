using System;

namespace InRefExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            function_raw(x);
            Console.WriteLine(x);
        }
        static void function_ref(ref int argument)
        {
            argument++;
            Console.WriteLine(argument);
        }
        static void function_in(in int argument)
        {
            // "argument" is readonly now so therefore, argument++ is wrong
            Console.WriteLine(argument);
        }
        static void function_raw(int argument)
        {
            argument++;
            Console.WriteLine(argument);
        }
    }
}
