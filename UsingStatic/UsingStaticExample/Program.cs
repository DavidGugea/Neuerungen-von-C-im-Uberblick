using System;
using static System.Math; // You simply don't have to write Math.Sqrt for example anymore
// using static System.Math is the same like from math import * in python 3 for example

namespace UsingStaticExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sqrt(9));
            Console.WriteLine(Abs(-2));
            Console.WriteLine(Abs(2));
        }
    }
}
